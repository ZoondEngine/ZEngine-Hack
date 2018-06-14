using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ZEngine_Server.Library.ION.Exceptions;
using ZEngine_Server.Repositories;

namespace ZEngine_Server.Library.ION
{
    public delegate void CommandResponse(Client clientobj);

    public enum Packet
    {
        SendPingRequest = 0,
        SendLinceseData = 1,
        SendDownloadLink = 2,
        SendBlockedInformation = 3,
        SendShutdown = 4,
        SendRestart = 5,
    }

    class Packets
    {
        private Dictionary<int, CommandResponse> Collection = new Dictionary<int, CommandResponse>();

        public Packets()
        {
            this[(int)Packet.SendPingRequest] = Responses.OnSendPingRequest;
            this[(int)Packet.SendLinceseData] = Responses.OnSendLicenseData;
            this[(int)Packet.SendShutdown]    = Responses.OnSendShutdown;
        }

        public CommandResponse this[int indexer]
        {
            get
            {
                if(Collection.ContainsKey(indexer))
                {
                    return Collection[indexer];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(!Collection.ContainsKey(indexer))
                {
                    Collection.Add(indexer, value);
                }
                else
                {
                    throw new PacketsException($"Key '{indexer}' already exists in packets collection.");
                }
            }
        }
    }

    public static class Responses
    {
        private static Buffer m_OutBuffer = new Buffer();

        public static void OnSendPingRequest(Client client)
        {
            if(client.IsBanned)
            {
                OnSendBannedInformation(client);
            }
            else
            {
                m_OutBuffer = new Buffer();

                string[] data = CreatePingData(client);
                m_OutBuffer.Write((int)Packet.SendPingRequest);
                m_OutBuffer.Write(data[0]);
                m_OutBuffer.Write(data[1]);

                OnSend(client);
            }
        }

        public static void OnSendLicenseData(Client client)
        {
            if (client.IsBanned)
            {
                OnSendBannedInformation(client);
            }
            else
            {
                m_OutBuffer = new Buffer();

                TimeSpan timespan = client.ExpireDate - client.RegisterDate;

                m_OutBuffer.Write((int)Packet.SendLinceseData);
                m_OutBuffer.Write(client.IsBanned);
                m_OutBuffer.Write(client.IsAdmin);
                m_OutBuffer.Write(client.IsFree);
                m_OutBuffer.Write(client.IsTest);
                m_OutBuffer.Write(client.HWID);
                m_OutBuffer.Write(timespan.Days);

                OnSend(client);
            }
        }

        public static void OnSendBannedInformation(Client client)
        {
            m_OutBuffer = new Buffer();

            m_OutBuffer.Write((int)Packet.SendBlockedInformation);
            m_OutBuffer.Write("You have been blocked !");

            OnSend(client);
        }

        public static void OnSendShutdown(Client client)
        {
            m_OutBuffer = new Buffer();

            m_OutBuffer.Write((int)Packet.SendShutdown);
            m_OutBuffer.Write("You have been shutdowned from server.");

            OnSend(client);
        }

        private static void OnSend(Client client)
        {
            client.AvailibleSocket.Send(m_OutBuffer.GetData(), m_OutBuffer.GetData().Length, System.Net.Sockets.SocketFlags.None);

            m_OutBuffer.Clear();
        }

        private static string[] CreatePingData(Client client)
        {
            string[] data = new string[2];

            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(client.IP);
                data[0] = reply.Options.Ttl.ToString();
                data[1] = reply.RoundtripTime.ToString();
            }
            catch(Exception ex)
            {
                $"[ION]: Error while creating ping response for client: '{client.HWID}'".ToColor(String.Colors.DarkRed);
                Console.WriteLine(ex.Message);
            }

            return data;
        }
    }
}
