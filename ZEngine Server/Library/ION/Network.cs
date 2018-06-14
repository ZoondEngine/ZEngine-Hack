using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ZEngine_Server.Repositories;
using ZEngine_Server.Library.ION.Exceptions;

namespace ZEngine_Server.Library.ION
{
    class Network
    {
        private int CountConnections = 350;
        private short Port = 8789;
        private IPAddress IP = IPAddress.Parse("192.168.15.200");
        //private IPAddress IP = IPAddress.Parse("127.0.0.1");
        private Socket m_SocketObject = new Socket(SocketType.Stream, ProtocolType.Tcp);
        private Dictionary<string, Client> ClientsCollection = new Dictionary<string, Client>();
        private Packets m_Packets = new Packets();

        public void Listen()
        {
            m_SocketObject.Bind(new IPEndPoint(IP, Port));
            m_SocketObject.Listen(CountConnections);
            $"[ION]: Server listented on '{IP.ToString()}:{Port}'. Waiting connections...".ToColor(String.Colors.DarkCyan);

            AcceptAsync();
        }

        private async void AcceptAsync()
        {
            if(m_SocketObject != null)
            {
                Socket client = await AcceptSocketTask();
                if (client != null)
                {
                    Client repo = new Client(client);
                    repo.CreateClientByIP(ParseIP(client.RemoteEndPoint));

                    try
                    {
                        if (repo.HWID != string.Empty)
                        {
                            if (!ClientsCollection.ContainsKey(repo.HWID))
                            {
                                ClientsCollection.Add(repo.HWID, repo);

                                $"[ION]: Client '{repo.Name}' accepted.".ToColor(String.Colors.ForestGreen);

                                ReceiveAsync(repo);
                            }
                            else
                            {
                                m_Packets[(int)Packet.SendShutdown].Invoke(repo);

                                $"Client '{repo.Name}' already connected. Client copy has been disconnected.".ToColor(String.Colors.DarkRed);
                            }
                        }
                        else
                        {
                            repo.Dispose();

                            $"[ION]: Client '{ParseIP(client.RemoteEndPoint)}' not accepted.".ToColor(String.Colors.DarkRed);
                        }
                    }
                    catch(Exception) { }
                }
                AcceptAsync();
            }
        }

        private Task<Socket> AcceptSocketTask()
        {
            return Task.Run(() =>
            {
                Socket client = m_SocketObject.Accept();

                return client;
            });
        }

        private async void ReceiveAsync(Client client)
        {
            if(client.AvailibleSocket != null)
            {
                int size = await ReceiveTask(client);
                if (size != 0)
                {
                    Buffer _inBuffer = new Buffer(client.ReceivingData);
                    int commandID = _inBuffer.Read<int>();
                    CommandResponse command = m_Packets[commandID];
                    if (command != null)
                    {
                        command.Invoke(client);
                    }
                    else
                    {
                        throw new NetworkException($"Received incorrect command '{commandID}'. Response undefined.");
                    }

                    _inBuffer.Clear();
                    ReceiveAsync(client);
                }
                else
                {
                    AppendDisconnect(client);
                }
            }
        }

        private Task<int> ReceiveTask(Client client)
        {
            return Task.Run(() =>
            {
                int size = 0;

                try
                {
                    size = client.AvailibleSocket.Receive(client.ReceivingData);
                }
                catch(SocketException)
                {
                    size = 0;
                }

                return size;
            });
        }

        public string ParseIP(EndPoint remotEndPoint)
        {
            return remotEndPoint.ToString().Split(':')[3].Replace("]", "");
        }

        private void AppendDisconnect(Client client)
        {
            string name = client.Name;
            ClientsCollection.Remove(client.HWID);

            client.Dispose();
            client = null;

            $"[ION]: Client '{name}' has been disconnected.".ToColor(String.Colors.DarkRed);
        }
    }
}
