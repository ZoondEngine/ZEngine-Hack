using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObooltNet;

namespace ConnectionTester
{
    public partial class Form1 : Form
    {
        private NetConnection Instance;
        private Sypher.RC4 RC4_Encoder = new Sypher.RC4(Encoding.ASCII.GetBytes("fbacfd138cc537b60600eded6301c95c742b4f01"));
        private Sypher.RC4 RC4_Decoder = new Sypher.RC4(Encoding.ASCII.GetBytes("fbacfd138cc537b60600eded6301c95c742b4f01"));
        private string Packet;

        private int PORT = 8789;
        private string ADDR = "127.0.0.1";

        Library.Automatic Automatic = new Library.Automatic();

        public Form1()
        {
            InitializeComponent();
            Instance = new NetConnection();

            Instance.OnDataReceived += Instance_OnDataReceived;
        }

        private void Instance_OnDataReceived(object sender, NetConnection connection, byte[] e)
        {
            byte[] decrypted = RC4_Decoder.Decode(e, e.Length);
            Packet = Encoding.ASCII.GetString(decrypted);

            richTextBox1.AppendText(Packet);

            string[] response = Packet.Split('!');

            if(response[0] == "CLIENT")
            {
                DispatchData(e);
            }
            else if(response[0] == "AUTH")
            {
                DispatchAuth(e);
            }
            else if(response[0] == "MSG")
            {
                DispatchMessage(e);
            }
            else if(response[0] == "BAN")
            {
                DispatchBan();
            }
            else
            {
                richTextBox1.AppendText("Received incorrect response. Declined");
            }
        }

        private void DispatchData(byte[] e)
        {
            try
            {
                string[] response = Packet.Split('!');

                string[] status = response[1].Split(',')[0].Replace("[STATUS:", "").Replace("]", "").Split('|');
                string[] activate = response[1].Split(',')[1].Replace("[ACTIVATE:", "").Replace("]", "").Split('|');
                string[] personal = response[1].Split(',')[2].Replace("[PERSONAL:", "").Replace("]", "").Split('|');

                richTextBox1.AppendText($"=======START RESPONSE FROM {response[0]}========\n");

                richTextBox1.AppendText($"STATUS:\nIsBanned = {status[0]}\n");
                richTextBox1.AppendText($"IsAdmin  = {status[1]}\n");
                richTextBox1.AppendText($"Other    = {status[2]}\n");

                richTextBox1.AppendText($"ACTIVATE:\nIsFree -> {activate[0]}\nKey -> {activate[1]}\nRegister -> {activate[2]}\nExpire -> {activate[3]}\nHWID -> {activate[4]}\n");
                richTextBox1.AppendText($"PERSONAL:\nName -> {personal[0]}\nDiscord -> {personal[1]}\n");

                richTextBox1.AppendText("=======STOP  RESPONSE========\n");
            }
            catch(Exception ex)
            {
                richTextBox1.AppendText(ex.Message);
            }
        }

        private void DispatchAuth(byte[] e)
        {
            string[] response = Packet.Split('!');

            response = response[1].Split('|');

            if(response[0] == "NOT")
            {
                richTextBox1.AppendText($"Access declined. Reason: {response[1]}");
            }
            else
            {
                richTextBox1.AppendText($"Access accepted. Enjoy !");
            }
        }

        private void DispatchMessage(byte[] e)
        {
            string[] response = Packet.Split('!');

            MessageBox.Show($"{response[1]}", "Сообщение от сервера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DispatchBan()
        {
            string[] response = Packet.Split('!');

            MessageBox.Show($"Вы были забанены на проекте ZEngine.\nПричина: {response[1]}\n\nДля дополнительной информации обратитесь в службу поддержки.", "Вы были забанены", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string[] GetStatus(string raw)
        {
            string[] nonParts = raw.Split('!');
            nonParts = nonParts[1].Split('[');

            string[] saveable = nonParts[0].Replace("STATUS:", "").Replace("]", "").Split(',');

            return saveable;
        }

        private string[] GetActivate(string raw)
        {
            string[] nonParts = raw.Split('!');
            nonParts = nonParts[1].Split('[');

            string[] allParts = nonParts[1].Split('[');
            string[] saveable = allParts[0].Replace("ACTIVATE:", "").Replace("]", "").Split(',');

            return saveable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Instance.Connect(ADDR, PORT);
            }
            catch(Exception ex)
            {
                richTextBox1.AppendText(ex.Message + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(textBox1.Text);
                byte[] encryptedData = RC4_Encoder.Encode(data, data.Length);
                Instance.Send(encryptedData);
            }
            catch(Exception ex)
            {
                richTextBox1.AppendText(ex.Message + "\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Instance.Disconnect();
            }
            catch(Exception ex)
            {
                richTextBox1.AppendText(ex.Message + "\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Automatic.Add("Connection", 2000, (s, args) =>
            {
                Library.Logger.Write(Library.LogTypes.Core, "EVENT HAS BEEN JOINED !");
                MessageBox.Show("Event join successfully !");

            }).Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Automatic.Update("Connection").Stop();
            Automatic.Delete("Connection");
            
            MessageBox.Show("Event has been stopped and deleted !");
        }
    }
}
