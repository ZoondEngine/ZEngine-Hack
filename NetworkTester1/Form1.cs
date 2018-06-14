using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace NetworkTester1
{
    public partial class Form1 : Form
    {
        static MemoryStream stream = new MemoryStream();
        BinaryReader reader = new BinaryReader(stream);
        BinaryWriter writer = new BinaryWriter(stream);
        Socket sock = new Socket(SocketType.Stream, ProtocolType.Tcp);
        byte[] buffer = new byte[255];

        public Form1()
        {
            InitializeComponent();

            Connect();
        }

        private void Connect()
        {
            //sock.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8789));

            sock.Connect(new IPEndPoint(IPAddress.Parse("77.82.86.211"), 8789));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writer.Write(0);
            writer.Write("Hello !");
            sock.Send(stream.ToArray());

            ReceiveAsync();
        }

        private async void ReceiveAsync()
        {
            int size = await ReceiveTask();
            if (size != 0)
            {
                MemoryStream _in = new MemoryStream(buffer);
                BinaryReader _inReader = new BinaryReader(_in);

                int packetId = _inReader.ReadInt32();
                if (packetId == 2)
                {
                    textBox1.Text = _inReader.ReadString();
                }
                else if(packetId == 3)
                {
                    MessageBox.Show(_inReader.ReadString(), "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Environment.Exit(0);
                }
                else if(packetId == 0)
                {
                    textBox1.Text = packetId + "|";
                    textBox1.Text += _inReader.ReadBoolean() + "|";
                    textBox1.Text += _inReader.ReadBoolean() + "|";
                    textBox1.Text += _inReader.ReadBoolean() + "|";
                    textBox1.Text += _inReader.ReadBoolean() + "|";
                    textBox1.Text += _inReader.ReadString() + "|";
                    textBox1.Text += _inReader.ReadInt32() + "";
                }
            }
            else
            {
                textBox1.Text = "Error occured !";
            }

            ReceiveAsync();
        }

        private Task<int> ReceiveTask()
        {
            return Task.Run(() =>
            {
                int size = sock.Receive(buffer);

                return size;
            });
        }
    }
}
