using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_RED.Library.ION
{
    public delegate void PacketDispatcher(Socket clientSock);

    public enum PacketType
    {
        SendPing = 0,
        SendAuthRequest = 1,
    }

    class Packets
    {
        public class Handlers
        {
            private Buffer m_OutBuffer;
            private Tasks m_Tasks = new Tasks();

            public void OnSendPing(Socket sock)
            {
                m_OutBuffer = new Buffer();

                m_OutBuffer.Write((int)PacketType.SendPing);

                Send(sock);
            }

            public void OnSendAuthRequest(Socket sock)
            {
                m_OutBuffer = new Buffer();

                m_OutBuffer.Write((int)PacketType.SendAuthRequest);

                Send(sock);
            }

            private void Send(Socket sock)
            {
                try
                {
                    sock.Send(m_OutBuffer.GetData(), m_OutBuffer.GetData().Length, SocketFlags.None);
                }
                catch(Exception)
                {
                    m_Tasks.Invoke(999, null);
                }

                m_OutBuffer.Clear();
            }
        }

        private Handlers m_Handlers = new Handlers();
        private Dictionary<int, PacketDispatcher> m_HandlersCollection = new Dictionary<int, PacketDispatcher>();

        public Packets()
        {
            m_HandlersCollection.Add((int)PacketType.SendPing, m_Handlers.OnSendPing);
            m_HandlersCollection.Add((int)PacketType.SendAuthRequest, m_Handlers.OnSendAuthRequest);
        }

        public bool Invoke(int command, Socket sock)
        {
            if(m_HandlersCollection.ContainsKey(command))
            {
                m_HandlersCollection[command].Invoke(sock);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
