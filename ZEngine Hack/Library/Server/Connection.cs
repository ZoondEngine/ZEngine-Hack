using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObooltNet;
using System.Windows.Forms;
using ZEngine_Hack.Library.Server.Exceptions;
using static ZEngine_Hack.Library.Server.DataStore;

namespace ZEngine_Hack.Library.Server
{
    class Connection
    {
        private const string SERVER_IP_ADDR = "127.0.0.1";
        private const int    SERVER_PORT    = 8789;

        private NetConnection Instance;
        private Packet SendPacket;

        public Packet ReceivePacket;
        public bool IsConnected { get; private set; }
        public Connection()
        {
            Instance = new NetConnection();
            ReceivePacket = new Packet();
            SendPacket = new Packet();

            IsConnected = false;
        }

        private void InitializeEvents() => Instance.OnDataReceived += Receive;

        public void Connect()
        {
            try
            {
                Instance.Connect(SERVER_IP_ADDR, SERVER_PORT);

                IsConnected = true;
            }
            catch(Exception e)
            {
                IsConnected = false;

                MessageBox.Show(e.Message);
            }
        }

        public void Disconnect()
        {
            if(IsConnected)
            {
                try
                {
                    Instance.Disconnect();

                    IsConnected = false;
                }
                catch(ConnectionException e)
                {
                    IsConnected = false;

                    MessageBox.Show(e.Message);
                }
            }
        }

        public void Send(string unparsedPacket)
        {
            if(IsConnected)
            {
                SendPacket.Parse(unparsedPacket);

                Instance.Send(Encoding.ASCII.GetBytes(SendPacket.ToString()));
            }
        }

        private void Receive(object sender, NetConnection connection, byte[] e)
        {
            ReceivePacket.Parse(Encoding.ASCII.GetString(e));
        }
    }
}
