using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using ZEngine_Server.Repositories;
using ObooltNet;
using ZEngine_Server.Helpers;

namespace ZEngine_Server.Library
{
    class Connection
    {
        private NetConnection Instance = new NetConnection();
        private Dictionary<string, Client> Connections = new Dictionary<string, Client>();
        private ClientDatabase Database = new ClientDatabase();
        private PayDatabase Pay = new PayDatabase();
        private Sypher.RC4 RC4_Encoder = new Sypher.RC4(Encoding.ASCII.GetBytes("fbacfd138cc537b60600eded6301c95c742b4f01"));
        private Sypher.RC4 RC4_Decoder = new Sypher.RC4(Encoding.ASCII.GetBytes("fbacfd138cc537b60600eded6301c95c742b4f01"));

        private string Packet;

        private bool IsListened;
        private string Info;

        public bool IsErrorAction;

        #region Command Handlers

        public void ShowP2PAll()
        {
            if(Connections.Count == 0)
            {
                "[P2P] >> There is no connection to the server".Error();

                return;
            }

            "========= [START P2P ALL] ========= ".Database();

            foreach (var client in Connections)
            {
                $"[CLIENT: {client.Value.Instance<Client.Personal>().Name}]: ".Core();
                $"IP: {client.Value.Instance<Client.Connection>().IPAddress}\nDiscord: {client.Value.Instance<Client.Personal>().Discord}\nHWID: {client.Value.Instance<Client.Activate>().HWID}".Database();
                $"BANNED: {client.Value.Instance<Client.Status>().IsBanned}\nADMIN: {client.Value.Instance<Client.Status>().IsAdmin}\nFREE: {client.Value.Instance<Client.Activate>().IsFree}\n".Database();
            }

            "========= [END P2P ALL] ========= ".Database();
        }

        public void ShowP2POne(string ip)
        {
            if(IsUserConnected(ip))
            {
                "[USER INFORMATION]: ".Database();

                $"User IP: {Connections[ip].Instance<Client.Connection>().IPAddress}".Database();
                $"User Discord: {Connections[ip].Instance<Client.Personal>().Discord}".Database();
                $"User HWID: {Connections[ip].Instance<Client.Activate>().HWID}".Database();

                "[END USER INFORMATION]".Database();
            }
            else
            {
                $"[P2P] >> Client: '{ip}' not finded in connections list.".Error();

                return;
            }
        }

        #endregion 

        public Connection()
        {
            Connections.Clear();

            IsListened = false;
            IsErrorAction = false;

            InitializeEvents();
        }

        internal bool CreateUser(string nickname, string hwid, string ipaddr, int days, bool admin)
        {
            if (Database.Load(ipaddr) == null)
            {
                Database.NonExecuteQuery("INSERT INTO " +
                    "clients " +
                    "(ban, admin, test, free, ch_key, register_date, expire_date, hwid, name, discord, ip) " +
                    "VALUES" +
                    $"('False', '{admin}', 'False'," +
                    $"'{admin}', '{GenerateKey()}', '{DateTime.Now.ToShortDateString()}', '{DateTime.Now.AddDays(days).ToShortDateString()}', '{hwid}'," +
                    $"'{nickname}', '{nickname}'," +
                    $"'{ipaddr}')");

                if (Database.Load(ipaddr) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private string GenerateKey()
        {
            throw new NullReferenceException();
        }

        private void InitializeEvents()
        {
            Instance.OnConnect += Instance_OnConnect;
            Instance.OnDataReceived += Instance_OnDataReceived;
            Instance.OnDisconnect += Instance_OnDisconnect;
        }

        private void Instance_OnDisconnect(object sender, NetConnection connection)
        {
            string ip = ParseIP(connection.RemoteEndPoint);

            if(IsUserConnected(ip))
            {
                Client discClient = Connections[ip];
                if(Database.Save(discClient))
                {
                    Connections[ip].Instance<Client.Connection>().ActiveConnection.Disconnect();

                    DisconnectOneClient(discClient);

                    if (AppSettings.IsDebug || AppSettings.DebugLevel == 1)
                        $"[NETWORK] >> Client: '{discClient.Instance<Client.Connection>().IPAddress}' disconnected from the server.".Success();
                }
                else
                {
                    $"[NETWORK] >> Disconnecting error while user saving. Name:'{discClient.Instance<Client.Personal>().Name}', IP:'{discClient.Instance<Client.Connection>().IPAddress}'".Error();

                    return;
                }
            }
            else
            {
                //$"[NETWORK] >> Trying disconnecting for disconnected client. IP: '{ip}'".Error();

                return;
            }
        }

        private void Instance_OnDataReceived(object sender, NetConnection connection, byte[] e)
        {
            //byte[] decodeable = RC4_Decoder.Decode(e, e.Length);
            Packet = Encoding.ASCII.GetString(e);

            if (Packet == "")
                return;
            else
            {
                Random rand = new Random();
                int randId = rand.Next(315, 65535);

                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[NETWORK] >> Receive->0x{randId.ToHex()} data '{Packet}' from '{ParseIP(connection.RemoteEndPoint)}'".Debug();

                SendResponse(ParseIP(connection.RemoteEndPoint));
            }
        }

        private void SendResponse(string ip)
        {
            if(!IsUserConnected(ip))
            {
                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[NETWORK] >> Try send data from disconnected client. Client: '{ip}'".Error();

                return;
            }

            string[] packet = GetPacket(Packet);
            string[] client = GetClient(Packet);

            Connections[ip].UpdateUserHwid(client[0]);

            if(packet[0] == "auth-opc")
            {
                ResponseAuth(Connections[ip]);
            }
            else if(packet[0] == "data-opc")
            {
                ResponseData(Connections[ip]);
            }
            else if(packet[0] == "download-opc")
            {
                ResponseDownloadResult(Connections[ip]);
            }

            if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                $"[NETWORK] >> Client: '{ip}'. Data received and responsed".Debug();
        }

        private void ResponseDownloadResult(Client client)
        {
            string data = "EMPTY";

            if(IsAllowToResponse(client) == "OK")
            {
                data = $"True,Allowed,{AppSettings.Urls.User},{AppSettings.Urls.Pass},{AppSettings.Urls.Path}";
            }
            else
            {
                data = $"False,Declined,null,null,null";
            }

            byte[] send = Encoding.ASCII.GetBytes(data);
            client.Instance<Client.Connection>().ActiveConnection.Send(send);
        }

        private void ResponseAuth(Client client)
        {
            string data = "EMPTY";

            if (IsAllowToResponse(client) == "OK")
            {
                data = "True,ACTIVE";

                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[P2P] >> {{ AUTH_OPCODE }} : Return 'True,ACTIVE'".Debug();
            }
            else
            {
                data = $"False,{IsAllowToResponse(client)}";

                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[P2P] >> {{ AUTH_OPCODE }} : Response for '{client.Instance<Client.Connection>().IPAddress}' declined. {IsAllowToResponse(client)}.".Error();
            }

            byte[] send = Encoding.ASCII.GetBytes(data);
            client.Instance<Client.Connection>().ActiveConnection.Send(send);
        }

        public void ResponseMessagesAll(string what)
        {
            foreach(var client in Connections)
            {
                string data = $"MSG!{what}";

                byte[] send = Encoding.ASCII.GetBytes(data);

                client.Value.Instance<Client.Connection>().ActiveConnection.Send(RC4_Encoder.Encode(send, send.Length));
            }
        }

        public void ResponseMessage(string ip, string msg)
        {
            if (IsUserConnected(ip))
            {
                ResponseMessage(Connections[ip], msg);
            }
            else
            {
                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    "[P2P] >> Try sent message to disconnected client. Declined.".Error();
            }
        }
        private void ResponseMessage(Client client, string msg)
        {
            string data = $"MSG!{msg}";

            byte[] send = Encoding.ASCII.GetBytes(data);
            client.Instance<Client.Connection>().ActiveConnection.Send(RC4_Encoder.Encode(send, send.Length));

            if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                $"[P2P] >> {{ MSG_OPCODE }} : Return '{data}'".Debug();
        }

        public void ResponseBan(string ip, string reason)
        {
            Client client = Connections[ip];

            string data = $"BAN!{reason}";
            byte[] send = Encoding.ASCII.GetBytes(data);

            client.Instance<Client.Connection>().ActiveConnection.Send(RC4_Encoder.Encode(send, send.Length));

            if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                $"[P2P] >> {{ BAN_OPCODE }} : Return '{data}' to '{ip}'".Debug();
        }

        private void ResponseData(Client client)
        {
            if (IsAllowToResponse(client) == "OK")
            {
                string data = $"True,{(client.Instance<Client.Activate>().ExpireDate - DateTime.Now).Days},0";

                byte[] send = Encoding.ASCII.GetBytes(data);
                client.Instance<Client.Connection>().ActiveConnection.Send(send);

                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[P2P] >> {{ DATA_OPCODE }} : Return '{data}'".Debug();
            }
            else
            {
                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[P2P] >> {{ DATA_OPCODE }} : Response for '{client.Instance<Client.Connection>().IPAddress}' declined. Not allow.".Error();
            }
        }

        private bool IsBanned(Client client)
        {
            if (client.Instance<Client.Status>().IsBanned && !client.Instance<Client.Status>().IsAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string IsAllowToResponse(Client client)
        {
            if(client.Instance<Client.Activate>().RegisterDate.CompareTo(DateTime.Today) == -1)
            {
                if(client.Instance<Client.Activate>().ExpireDate.CompareTo(DateTime.Today) == 1)
                {
                    if (!IsBanned(client))
                    {
                        return "OK";
                    }
                    else
                    {
                        return "BANNED";
                    }
                }
                else
                {
                    return "EXPIRED";
                }
            }
            else
            {
                return "INCORRECT";
            }
        }

        private void Instance_OnConnect(object sender, NetConnection connection)
        {
            string ip = ParseIP(connection.RemoteEndPoint);
            if (!IsUserConnected(ip))
            {
                if(Database.Load(ip) != null)
                {
                    Client newclient = Database.Load(ip);
                    if(newclient == null)
                    {
                        $"[DATABASE] >> Unknown error from database.".Error();

                        return;
                    }

                    newclient.PushConnection(connection);

                    Connections.Add(newclient.Instance<Client.Connection>().IPAddress, newclient);

                    $"[NETWORK] >> Client Name:'{newclient.Instance<Client.Personal>().Name}', IP:'{newclient.Instance<Client.Connection>().IPAddress}' successfully connected".Success();
                }
                else
                {
                    if(Pay.IsPay(ip))
                    {
                        Client newclient = new Client();

                        if(Pay.GetPayData(ip) != null)
                        {
                            newclient.CreateDefaultUser(Pay.GetPayData(ip), connection);

                            if (AppSettings.IsDebug || AppSettings.DebugLevel == 3)
                                $"[DATABASE] >> Client: '{ip}' created from pay database. Saving ...".Success();

                            Database.Save(newclient);

                            if(Database.Load(ip) != null)
                            {
                                Pay.Delete(ip);
                                Connections.Add(newclient.Instance<Client.Connection>().IPAddress, newclient);

                                $"[NETWORK] >> Client Name:'{newclient.Instance<Client.Personal>().Name}', IP:'{newclient.Instance<Client.Connection>().IPAddress}' successfully connected".Success();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            Pay.Error.Error();

                            return;
                        }
                    }
                    else
                    {
                        Pay.Error.Error();

                        return;
                    }
                }

                //Database.Dispose();
            }
            else
            {
                if (AppSettings.IsDebug || AppSettings.DebugLevel == 2)
                    $"[NETWORK] >> Client '{Connections[ip].Instance<Client.Connection>().IPAddress}' is already connected. Disconnecting ... ".Warning();

                Instance_OnDisconnect(sender, connection);
                //DisconnectOneClient(Connections[ip]);
            }
        }

        public void Listen()
        {
            if(!IsListened)
            {
                try
                {
                    Instance.Start(8789);

                    IsListened = true;

                    "[CORE] >> Server has been started on '[ANY_ADDRESSES]:8789'. Listen...".Core();
                }
                catch(Exception e)
                {
                    IsListened = false;

                    Info = $"[CORE] >> Server not a stopped. Please try again later.\n[ERROR] >> {e.Message}";
                    Info.Error();

                    IsErrorAction = true;
                }
            }
        }

        public void Stop()
        {
            if(IsListened)
            {
                try
                {
                    Instance.Stop();
                }
                catch(Exception) { }

                SaveAllClients();
                DisconnectAllClient();

                IsListened = false;

                "[CORE] >> Server has been stopped successfully.".Core();
            }
        }

        private string[] GetPacket(string packet)
        {
            return packet.Split('|')[0].Split(',');
        }

        private string[] GetClient(string packet)
        {
            return packet.Split('|')[1].Split(',');
        }

        public bool IsUserConnected(string ip)
        {
            if(Connections.ContainsKey(ip))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SaveAllClients()
        {
            foreach(var client in Connections)
            {
                Database.Instance(client.Value).Save();
            }
        }

        private void SaveOne(Client client)
        {
            Database.Instance(client).Save();
        }

        private void DisconnectAllClient()
        {
            SaveAllClients();

            foreach(var client in Connections)
            {
                client.Value.Instance<Client.Connection>().ActiveConnection.Disconnect();
            }

            Connections.Clear();
        }

        public void DisconnectOneClient(string ip)
        {
            if (IsUserConnected(ip))
                DisconnectOneClient(Connections[ip]);
            else
                $"[NETWORK] >> Client: '{ip}' not find in connections list.".Error();
        }
        private void DisconnectOneClient(Client client)
        {
            SaveOne(client);

            Connections.Remove(client.Instance<Client.Connection>().IPAddress);

            $"[NETWORK] >> Client: '{client.Instance<Client.Connection>().IPAddress}' has been disconnect manually.".Success();

            //Instance_OnDisconnect(this, client.Instance<Client.Connection>().ActiveConnection);
        }

        public void Ban(string ip, string reason)
        {
            Client client = null;

            if (IsUserConnected(ip))
            {
                client = Connections[ip];
            }
            else
            {
                if(Database.Load(ip) != null)
                {
                    client = Database.Load(ip);
                }
                else
                {
                    $"[DATABASE] >> Client: '{ip}' not find in database.".Error();

                    return;
                }
            }

            client.BanUser(true);

            SaveOne(Connections[ip]);
            ResponseBan(ip, reason);

            DisconnectOneClient(Connections[ip]);
        }

        public bool Unban(string ip)
        {
            Client client = null;

            if (IsUserConnected(ip))
            {
                client = Connections[ip];
            }
            else
            {
                if (Database.Load(ip) != null)
                {
                    client = Database.Load(ip);
                }
                else
                {
                    $"[DATABASE] >> Client: '{ip}' not find in database.".Error();

                    return false;
                }
            }

            client.BanUser(false);

            if (IsUserConnected(ip))
            {
                SaveOne(Connections[ip]);
                DisconnectOneClient(Connections[ip]);
            }
            else
            {
                Database.Save(client);
            }

            return true;
        }

        private string ParseIP(EndPoint point)
        {
            return point.ToString().Split(':')[0];
        }
    }
}
