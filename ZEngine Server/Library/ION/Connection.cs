using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace ZEngine_Server.Library.ION
{
    class Connection
    {
        private static int Port = 8789;
        private static string IPAddr = "127.0.0.1";
        private static byte[] m_OutBuffer = new byte[4096];
        private static byte[] m_InBuffer  = new byte[4096];

        private Socket m_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static IPAddress m_Address = IPAddress.Parse(IPAddr);
        private IPEndPoint m_EndPoint = new IPEndPoint(m_Address, Port);
        private static MemoryStream m_OutStream = new MemoryStream(m_OutBuffer);
        private static MemoryStream m_InStream  = new MemoryStream(m_InBuffer);

        private BinaryReader m_BinaryReader = new BinaryReader(m_InStream);
        private BinaryWriter m_BinaryWriter = new BinaryWriter(m_OutStream);

        public bool Listen()
        {
            m_Socket.Bind(m_EndPoint);
            m_Socket.SetIPProtectionLevel(IPProtectionLevel.EdgeRestricted);
            m_Socket.Listen(350);

            while(true)
            {
                Socket client = m_Socket.Accept();
            }
        }
    }
}
