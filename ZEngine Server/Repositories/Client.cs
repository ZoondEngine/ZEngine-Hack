using System;
using System.Collections.Concurrent;
using System.Net.Sockets;

namespace ZEngine_Server.Repositories
{
    public class Client
    {
        public bool IsBanned         { get; private set; }
        public bool IsAdmin          { get; private set; }
        public bool IsTest           { get; private set; }
        public bool IsFree           { get; private set; }
        public string CheatKey       { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public DateTime ExpireDate   { get; private set; }
        public string HWID           { get; private set; }
        public string Name           { get; private set; }
        public string Discord        { get; private set; }
        public string IP             { get; private set; }

        public Socket AvailibleSocket { get; private set; }
        public byte[] ReceivingData;

        public Client(Socket clientSocket)
        {
            ReinitializeRepo();

            AvailibleSocket = clientSocket;
            ReceivingData = new byte[byte.MaxValue];
        }

        private void ReinitializeRepo()
        {
            IsBanned = false;
            IsAdmin = false;
            IsTest = false;
            IsFree = false;
            CheatKey = string.Empty;
            RegisterDate = DateTime.MinValue;
            ExpireDate = DateTime.MinValue;
            HWID = string.Empty;
            Name = string.Empty;
            Discord = string.Empty;
            IP = string.Empty;
        }

        public void CreateClientByIP(string ip)
        {
            if(IGC.ClientsDatabase.IsLoadeableUser(IGC.ClientsDatabase.GetHwidByIP(ip)))
            {
                string[] fromDatabase = IGC.ClientsDatabase.LoadUser(IGC.ClientsDatabase.GetHwidByIP(ip));
                try
                {
                    AppendData(fromDatabase);
                }
                catch(Exception ex)
                {
                    Dispose();

                    $"[IRC]: Received undefined user data. Object disposed and reinitialized.".ToColor(String.Colors.DarkRed);
                    $"[IRC]: Old Exception: {ex.Message}".ToColor(String.Colors.DarkRed);
                }
            }
            else
            {
                $"[IRC]: User '{ip}' not found in database.".ToColor(String.Colors.DarkRed);
            }
        }

        public void CreateClientByHwid(string hwid)
        {
            if (IGC.ClientsDatabase.IsLoadeableUser(hwid))
            {
                string[] fromDatabase = IGC.ClientsDatabase.LoadUser(hwid);

                AppendData(fromDatabase);
            }
            else
            {
                $"[IRC]: User '{hwid}' not found in database.".ToColor(String.Colors.DarkRed);
            }
        }

        private void AppendData(string[] userdata)
        {
            IsBanned = Boolean.Parse(userdata[0]);
            IsAdmin = Boolean.Parse(userdata[1]);
            IsTest = Boolean.Parse(userdata[2]);
            IsFree = Boolean.Parse(userdata[3]);
            CheatKey = userdata[4];
            RegisterDate = DateTime.Parse(userdata[5]);
            ExpireDate = DateTime.Parse(userdata[6]);
            HWID = userdata[7];
            Name = userdata[8];
            Discord = userdata[9];
            IP = userdata[10];
        }

        public void Dispose()
        {
            ReinitializeRepo();

            if(AvailibleSocket != null)
            {
                AvailibleSocket.Close();
                AvailibleSocket = null;
            }

            ReceivingData = null;
            ReceivingData = new byte[byte.MaxValue];
        }
    }
}
