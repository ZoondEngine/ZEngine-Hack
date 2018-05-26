using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ObooltNet;

namespace ConnectionTester.Library
{
    /// <summary>
    /// Структура, хранящая в себе данные, 
    /// которые былы получены на запрос загрузки данных.
    /// </summary>
    struct Download
    {
        /// <summary>
        /// Результат запроса на загрузку данных.
        /// </summary>
        public bool   Result   { get; private set; }

        /// <summary>
        /// Сообщение полученное на запрос о загрузке.
        /// </summary>
        public string Message  { get; private set; }

        /// <summary>
        /// Временный пользователь для подключения к серверу загрузки.
        /// </summary>
        public string User     { get; private set; }

        /// <summary>
        /// Временный пароль для подключения к серверу загрузки.
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Адрес сервера загрузки.
        /// </summary>
        public string URL      { get; private set; }

        /// <summary>
        /// Заполняет структуру указанными данными.
        /// </summary>
        /// <param name="result">Результат</param>
        /// <param name="msg">Сообщение</param>
        /// <param name="user">Пользователь</param>
        /// <param name="pass">Пароль</param>
        /// <param name="url">URL-адрес</param>
        public void Parse(string result, string msg, string user, string pass, string url)
        {
            Parse(Boolean.Parse(result), msg, user, pass, url);
        }

        /// <summary>
        /// Заполняет структуру указанными данными.
        /// </summary>
        /// <param name="result">Результат</param>
        /// <param name="msg">Сообщение</param>
        /// <param name="user">Пользователь</param>
        /// <param name="pass">Пароль</param>
        /// <param name="url">URL-адрес</param>
        public void Parse(bool result, string msg, string user, string pass, string url)
        {
            Result = result; Message = msg; User = user; Password = pass; URL = url;
        }
    }

    /// <summary>
    /// Структура, хранящая в себе дынные,
    /// которые были получены в результате запроса
    /// на авторизацию.
    /// </summary>
    struct Auth
    {
        /// <summary>
        /// Результат запроса.
        /// </summary>
        public bool Result    { get; private set; }

        /// <summary>
        /// Сообщение, обосновывающее результат.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Заполняет структуру указанными данными.
        /// </summary>
        /// <param name="result">Результат</param>
        /// <param name="msg">Сообщение</param>
        public void Parse(string result, string msg)
        {
            Parse(Boolean.Parse(result), msg);
        }

        /// <summary>
        /// Заполняет структуру указанными данными.
        /// </summary>
        /// <param name="result">Результат</param>
        /// <param name="msg">Сообщение</param>
        public void Parse(bool result, string msg)
        {
            Result = result; Message = msg;
        }
    }

    /// <summary>
    /// Структура, хранящая в себе данные,
    /// полученные в результате запроса на 
    /// получение данных.
    /// </summary>
    struct Data
    {
        /// <summary>
        /// Результат запроса.
        /// </summary>
        public bool Result      { get; private set; }

        /// <summary>
        /// Количество активных дней.
        /// </summary>
        public int  AllowedDays { get; private set; }

        /// <summary>
        /// Роль пользователя.
        /// </summary>
        public int  Role        { get; private set; }

        /// <summary>
        /// Заполняет структуру указанными данными.
        /// </summary>
        /// <param name="result">Результат запроса</param>
        /// <param name="days">Активные дни</param>
        /// <param name="role">Роль пользователя</param>
        public void Parse(string result, string days, string role)
        {
            Parse(Boolean.Parse(result), Int32.Parse(days), Int32.Parse(role));
        }

        /// <summary>
        /// Заполняет структуру указанными данными.
        /// </summary>
        /// <param name="result">Результат запроса</param>
        /// <param name="days">Активные дни</param>
        /// <param name="role">Роль пользователя</param>
        public void Parse(bool result, int days, int role)
        {
            Result = result; AllowedDays = days; Role = role;
        }
    }

    struct Request
    {
        public string Opcode  { get; private set; }
        public string Message { get; private set; }
        public string HWID    { get; private set; }

        public void Structurize(string opcode, string msg, string hwid)
        {
            Opcode = opcode; Message = msg; HWID = hwid;
        }

        public override string ToString()
        {
            return $"{Opcode},{Message}|{HWID}";
        }
    }

    class Net
    {
        #region Events
        public delegate void ReceiveDelegate();

        public event ReceiveDelegate OnReceived;
        #endregion

        #region Structure objects
        private Download     m_DownloadStruct = new Download();
        private Auth         m_AuthStruct     = new Auth();
        private Data         m_DataStruct     = new Data();
        private Request      m_RequestStruct  = new Request();
        #endregion

        #region Library objects
        public NetConnection ActiveConnection { get; private set; }

        private Sypher.RC4 Encoder = new Sypher.RC4(Encoding.ASCII.GetBytes("fbacfd138cc537b60600eded6301c95c742b4f01"));
        private Sypher.RC4 Decoder = new Sypher.RC4(Encoding.ASCII.GetBytes("fbacfd138cc537b60600eded6301c95c742b4f01"));
        #endregion

        #region Fields
        public bool          IsConnected      { get; private set; }
        public bool          IsReceive        { get; private set; }
        public bool          IsBuzy           { get; private set; }

        public string        ReceivedData     { get; private set; }
        public string        ServerAddress    { get; private set; }
        public int           ServerPort       { get; private set; }
        #endregion

        #region Initialization
        public Net()
        {
            ActiveConnection = new NetConnection();
            ActiveConnection.OnDisconnect += Disconnect;

            InitializeClassObjects();
        }

        private void Disconnect(object sender, NetConnection connection)
        {
            IsConnected = false;
        }

        public Net(NetConnection conn)
        {
            ActiveConnection = conn;

            InitializeClassObjects();
        }
        private void InitializeClassObjects()
        {
            IsConnected   = false;
            IsReceive     = false;
            IsBuzy        = false;

            ServerAddress = "127.0.0.1";
            ServerPort    = 8789;
        }
        #endregion

        #region Public methods
        public void Connect()
        {
            try
            {
                ActiveConnection.Connect(ServerAddress, ServerPort);

                IsConnected = true;
            }
            catch (Exception)
            {
                IsConnected = false;
            }
        }

        public void Disconnect()
        {
            ActiveConnection.Disconnect();
        }

        public void Send<T>(Request request)
        {
            if(IsBuzy || IsReceive)
            {
                return;
            }

            SetBuzy(true);
            Logger.Write(LogTypes.Network, $"Send packet: '{Encoding.ASCII.GetString(Encode(request.ToString()))}' to server. ");

            if (!IsConnected)
            {
                Connect();
            }

            ActiveConnection.OnDataReceived -= ReceiveDownload;
            ActiveConnection.OnDataReceived -= ReceiveAuth;
            ActiveConnection.OnDataReceived -= ReceiveData;

            if (typeof(T) == typeof(Download))
            {
                ActiveConnection.OnDataReceived += ReceiveDownload;
            }
            else if (typeof(T) == typeof(Auth))
            {
                ActiveConnection.OnDataReceived += ReceiveAuth;
            }
            else if (typeof(T) == typeof(Data))
            {
                ActiveConnection.OnDataReceived += ReceiveData;
            }
            else
            {
                Logger.Write(LogTypes.Network, $"Request incorrect packet type for return. Type: {typeof(T).ToString()}");

                return;
            }

            Send(request);
        }
        public T Instance<T>()
        {
            if (typeof(T) == typeof(Download))
            {
                return (T)(object)m_DownloadStruct;
            }
            else if (typeof(T) == typeof(Auth))
            {
                return (T)(object)m_AuthStruct;
            }
            else if (typeof(T) == typeof(Data))
            {
                return (T)(object)m_DataStruct;
            }
            else if(typeof(T) == typeof(Request))
            {
                return (T)(object)m_RequestStruct;
            }
            else
            {
                Logger.Write(LogTypes.Network, $"Request incorrect packet type for return. Type: {typeof(T).ToString()}");

                return (T)(object)null;
            }
        }
        #endregion

        #region Private methods
        private void Send(Request request)
        {
            /*
            byte[] encodeable = Encoding.ASCII.GetBytes(request.ToString());

            ActiveConnection.Send(Encoder.Encode(encodeable, encodeable.Length));
            */
            ActiveConnection.Send(Encoding.ASCII.GetBytes(request.ToString()));
        }

        private string[] Desinflate()
        {
            return ReceivedData.Split(',');
        }

        private void ReceiveDownload(object sender, NetConnection connection, byte[] e)
        {
            //IsReceive = true;

            if (Encoding.ASCII.GetString(e) == "")
            {
                IsReceive = false;

                return;
            }
            else
            {
                //byte[] decodeable = Decoder.Decode(e, e.Length);

                ReceivedData = Encoding.ASCII.GetString(e);
                m_DownloadStruct.Parse(Desinflate()[0], Desinflate()[1], Desinflate()[2], Desinflate()[3], Desinflate()[4]);
                SetBuzy(false);

                OnReceived?.Invoke();
            }
        }

        private void ReceiveAuth(object sender, NetConnection connection, byte[] e)
        {
            //IsReceive = true;

            if (Encoding.ASCII.GetString(e) == "")
            {
                IsReceive = false;

                return;
            }
            else
            {
                //byte[] decodeable = Decoder.Decode(e, e.Length);

                ReceivedData = Encoding.ASCII.GetString(e);
                m_AuthStruct.Parse(Desinflate()[0], Desinflate()[1]);
                SetBuzy(false);

                OnReceived?.Invoke();
            }
        }

        private void ReceiveData(object sender, NetConnection connection, byte[] e)
        {
            //IsReceive = true;

            if (Encoding.ASCII.GetString(e) == "")
            {
                IsReceive = false;

                return;
            }
            else
            {
                //byte[] decodeable = Decoder.Decode(e, e.Length);

                ReceivedData = Encoding.ASCII.GetString(e);
                m_DataStruct.Parse(Desinflate()[0], Desinflate()[1], Desinflate()[2]);
                SetBuzy(false);

                OnReceived?.Invoke();
            }
        }
        #endregion

        #region Cipher logic
        private byte[] Encode(string request)
        {
            byte[] data = Encoding.ASCII.GetBytes(request);

            return Encoder.Encode(data, data.Length);
        }
        private string Decode(byte[] data)
        {
            byte[] result = Decoder.Decode(data, data.Length);

            return Encoding.ASCII.GetString(result);
        }
        #endregion

        #region Fast val
        private void SetBuzy(bool val) => IsBuzy = val;
        #endregion
    }
}
