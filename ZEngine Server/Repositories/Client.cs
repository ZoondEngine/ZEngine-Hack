using System;
using ObooltNet;

namespace ZEngine_Server.Repositories
{
    class Client
    {
        #region Structs
        /// <summary>
        /// Подструктура хранения информации о статусе клиента.
        /// </summary>
        public struct Status
        {
            public bool IsBanned { get; private set; }
            public bool IsAdmin { get; private set; }
            public bool IsTesting { get; private set; }

            public void Boot()
            {
                IsBanned = false;
                IsAdmin = false;
                IsTesting = false;
            }

            public void Ban(bool val) => IsBanned = val;
            public void Admin(bool val) => IsAdmin = val;
            public void Test(bool val) => IsTesting = val;
            public Status Instance() => this;

            public void Parse(bool ban, bool admin, bool test)
            {
                IsBanned = ban; IsAdmin = admin; IsTesting = test;
            }
            public void Parse(string ban, string admin, string test)
            {
                Parse(Boolean.Parse(ban), Boolean.Parse(admin), Boolean.Parse(test));
            }
        }

        /// <summary>
        /// Подструктура хранения информации о лицензии клиента.
        /// </summary>
        public struct Activate
        {
            public bool IsFree { get; private set; }
            public string Key { get; private set; }
            public DateTime RegisterDate { get; private set; }
            public DateTime ExpireDate { get; private set; }
            public string HWID { get; private set; }

            public void Boot()
            {
                IsFree = false;
                Key = string.Empty;
                RegisterDate = DateTime.Now;
                ExpireDate = DateTime.Now;
            }

            public void Free(bool val) => IsFree = val;
            public void SetKey(string key) => Key = key;
            public void SetRegisterDate(DateTime date) => RegisterDate = date;
            public void SetExpireDate(DateTime date) => ExpireDate = date;
            public void SetHwid(string hwid) => HWID = hwid;
            public Activate Instance() => this;

            public void Parse(bool free, string key, DateTime regDate, DateTime expDate, string hwid)
            {
                IsFree = free; Key = key; RegisterDate = regDate; ExpireDate = expDate;
            }
            public void Parse(string free, string key, string regDate, string expDate, string hwid)
            {
                Parse(Boolean.Parse(free), key, DateTime.Parse(regDate), DateTime.Parse(expDate), hwid);
            }
        }

        /// <summary>
        /// Подструктура хранения информации о личных данных клиента.
        /// </summary>
        public struct Personal
        {
            public string Name { get; private set; }
            public string Discord { get; private set; }

            public void Boot()
            {
                Name = string.Empty;
                Discord = string.Empty;
            }

            public void SetName(string val) => Name = val;
            public void SetDiscord(string val) => Discord = val;
            public Personal Instance() => this;

            public void Parse(string name, string discord)
            {
                Name = name; Discord = discord;
            }
        }

        /// <summary>
        ///Подструктура хранения информации данных о подключении клиента.
        /// </summary>
        public struct Connection
        {
            public NetConnection ActiveConnection { get; private set; }
            public string IPAddress { get; private set; }

            public void Boot()
            {
                ActiveConnection = null;
                IPAddress = string.Empty;
            }

            public void SetConnection(NetConnection conn) => ActiveConnection = conn;
            public void SetIp(string ip) => IPAddress = ip.Split(':')[0];
            public Connection Instance() => this;
        }
        #endregion

        #region Class objects
        /// <summary>
        /// Предоставляет объект для работы с подструктурой хранения информации, которая хранит данные о статусе клиента.
        /// </summary>
        private Status m_StatusObject = new Status();

        /// <summary>
        /// Предоставляет объект для работы с подструктурой хранения информации, которая хранит данные о лицензии клиента.
        /// </summary>
        private Activate m_ActivateObject = new Activate();

        /// <summary>
        /// Предоставляет объект для работы с подструктурой хранения информации, которая хранит личные данные клиента.
        /// </summary>
        private Personal m_PersonalObject = new Personal();

        /// <summary>
        /// Предоставляет объект для работы с подструктурой хранения информации, которая хранит данные о подключении клиента.
        /// </summary>
        private Connection m_ConnectionObject = new Connection();
        #endregion

        #region Class fields
        /// <summary>
        /// Выводит сообщение об ошибке.
        /// </summary>
        public string Error;
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор по умолчанию. Передает аргумент инициализации в главный конструктор.
        /// </summary>
        public Client() : this(true) { }

        /// <summary>
        /// Конструктор ручного объявления инициализации
        /// </summary>
        /// <param name="boot">Инициализировать структуры хранения данных ?</param>
        public Client(bool boot)
        {
            if(boot)
            {
                m_StatusObject.Boot();
                m_ActivateObject.Boot();
                m_PersonalObject.Boot();
                m_ConnectionObject.Boot();
            }
        }
        #endregion

        #region Public
        /// <summary>
        /// Добавляет информацию о подключении клиента в соответствующую подструктуру данных.
        /// </summary>
        /// <param name="conn">Объект подключения</param>
        public void PushConnection(NetConnection conn)
        {
            m_ConnectionObject.SetConnection(conn);
            m_ConnectionObject.SetIp(conn.RemoteEndPoint.ToString());
        }

        /// <summary>
        /// Читает полученную "сырую" строку от адресата и записывает прочитанные данные в указанное хранилище.
        /// </summary>
        /// <typeparam name="T">Хранилище для сохранения (Status, Activate, Personal)</typeparam>
        /// <param name="raw">"сырая" строка для чтения</param>
        /// <returns>bool</returns>
        public bool Read<T>(string raw) where T : struct
        {
            try
            {
                string[] nonParts = raw.Split('!');
                nonParts = nonParts[1].Split('[');

                if (typeof(T) == typeof(Status))
                {
                    if(GetPart<Status>(nonParts) != string.Empty)
                    {
                        return Save<Status>(GetPart<Status>(nonParts));
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(typeof(T) == typeof(Activate))
                {
                    if(GetPart<Activate>(nonParts) != string.Empty)
                    {
                        return Save<Activate>(GetPart<Activate>(nonParts));
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(typeof(T) == typeof(Personal))
                {
                    if (GetPart<Personal>(nonParts) != string.Empty)
                    {
                        return Save<Personal>(GetPart<Personal>(nonParts));
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    Error = $"InvalidCast__Type: '{typeof(T).ToString()}' not exists.";

                    return false;
                }
            }
            catch(Exception ex)
            {
                Error = ex.Message;

                return false;
            }
        }

        /// <summary>
        /// Выполняет создание клиента по умолчанию с полученными при регистрации данными.
        /// </summary>
        /// <param name="data">Данные полученные с регистрации</param>
        /// <param name="connection">Объект подключения клиента</param>
        public void CreateDefaultUser(string[] data, NetConnection connection)
        {
            try
            {
                //Initialize default status data
                m_StatusObject.Ban(false); m_StatusObject.Admin(false); m_StatusObject.Test(false);

                //Initialize default license data
                m_ActivateObject.Free(false); m_ActivateObject.SetKey(data[1]); m_ActivateObject.SetRegisterDate(DateTime.Parse(data[2]));
                m_ActivateObject.SetExpireDate(DateTime.Parse(data[3]));

                //Initialize default personal data
                m_PersonalObject.SetName(data[4]); m_PersonalObject.SetDiscord(data[5]);

                //Initialize default connection data
                PushConnection(connection);
            }
            catch(Exception ex)
            {
                ex.Message.Error();
                data[1].Error();
            }
        }

        /// <summary>
        /// Присваивает значение переменной IsBanned согласно указанному.
        /// </summary>
        /// <param name="val">Забанить пользователя ?</param>
        public void BanUser(bool val)
        {
            m_StatusObject.Ban(val);
        }

        /// <summary>
        /// Обновляет строку HWID пользователя.
        /// </summary>
        /// <param name="hwid">Код компьютера</param>
        public void UpdateUserHwid(string hwid)
        {
            m_ActivateObject.SetHwid(hwid);
        }

        /// <summary>
        /// Выполняет создание клиента согласно полученным из базы данных данным.
        /// </summary>
        /// <param name="data">Данные из базы данных</param>
        /// <param name="connection">Объект подключения клиента</param>
        public void CreateUserFromDatabase(string[] data)
        {
            //Initialize default status data
            m_StatusObject.Ban(Boolean.Parse(data[0])); m_StatusObject.Admin(Boolean.Parse(data[1])); m_StatusObject.Test(Boolean.Parse(data[2]));

            //Initialize default license data
            m_ActivateObject.Free(Boolean.Parse(data[3])); m_ActivateObject.SetKey(data[4]); m_ActivateObject.SetRegisterDate(DateTime.Parse(data[5]));
            m_ActivateObject.SetExpireDate(DateTime.Parse(data[6])); m_ActivateObject.SetHwid(data[7]);

            //Initialize default personal data
            m_PersonalObject.SetName(data[8]); m_PersonalObject.SetDiscord(data[9]);

            //Initialize default connection data
            m_ConnectionObject.SetIp(data[10]);
        }

        /// <summary>
        /// Перехваченный метод. Представляет хранимые данные в виде строки.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string status, activate, personal;

            status = $"[STATUS:{m_StatusObject.IsBanned}|{m_StatusObject.IsAdmin}|{m_StatusObject.IsTesting}]";
            activate = $"[ACTIVATE:{m_ActivateObject.IsFree}|{m_ActivateObject.Key}|{m_ActivateObject.RegisterDate}|{m_ActivateObject.ExpireDate}|{m_ActivateObject.HWID}]";
            personal = $"[PERSONAL:{m_PersonalObject.Name}|{m_PersonalObject.Discord}]";

            return $"CLIENT!{status},{activate},{personal}";
        }
        #endregion

        #region Instance
        /// <summary>
        /// Возвращает указанный экземпляр объекта хранилища.
        /// </summary>
        /// <typeparam name="T">Тип хранилища</typeparam>
        /// <returns>T</returns>
        public T Instance<T>()
        {
            if(typeof(T) == typeof(Status))
            {
                return (T)(object)m_StatusObject.Instance();
            }
            else if(typeof(T) == typeof(Activate))
            {
                return (T)(object)m_ActivateObject.Instance();
            }
            else if(typeof(T) == typeof(Personal))
            {
                return (T)(object)m_PersonalObject.Instance();
            }
            else if(typeof(T) == typeof(Connection))
            {
                return (T)(object)m_ConnectionObject.Instance();
            }
            else
            {
                return default(T);
            }
        }
        #endregion

        #region For database
        /// <summary>
        /// Получает все данные в строковом представлении для указанного хранилища.
        /// </summary>
        /// <typeparam name="T">Хранилище (Status, Activate, Personal, Connection)</typeparam>
        /// <returns>string</returns>
        public string GetRepository<T>()
        {
            if(typeof(T) == typeof(Status))
            {
                return $"{m_StatusObject.IsAdmin},{m_StatusObject.IsBanned},{m_StatusObject.IsTesting}";
            }
            else if(typeof(T) == typeof(Activate))
            {
                return $"{m_ActivateObject.IsFree},{m_ActivateObject.Key},{m_ActivateObject.RegisterDate},{m_ActivateObject.ExpireDate}, {m_ActivateObject.HWID}";
            }
            else if(typeof(T) == typeof(Personal))
            {
                return $"{m_PersonalObject.Name},{m_PersonalObject.Discord}";
            }
            else if(typeof(T) == typeof(Connection))
            {
                return m_ConnectionObject.IPAddress;
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion

        #region Instruments
        /// <summary>
        /// Сохраняет прочитанные данные с указанное хранилище.
        /// </summary>
        /// <typeparam name="T">Хранилище для сохранения (Status, Activate, Personal)</typeparam>
        /// <param name="raw">Строка для сохранения</param>
        /// <returns>bool</returns>
        private bool Save<T>(string raw)
        {
            string[] splPart = raw.Split('|');

            try
            {
                if (typeof(T) == typeof(Status))
                {
                    m_StatusObject.Parse(splPart[0], splPart[1], splPart[2]);

                    return true;
                }
                else if (typeof(T) == typeof(Activate))
                {
                    m_ActivateObject.Parse(splPart[0], splPart[1], splPart[2], splPart[3], splPart[4]);

                    return true;
                }
                else if (typeof(T) == typeof(Personal))
                {
                    m_PersonalObject.Parse(splPart[0], splPart[1]);

                    return true;
                }
                else
                {
                    Error = $"InvalidCast__Type: '{typeof(T).ToString()}' not exists.";

                    return false;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;

                return false;
            }

        }

        /// <summary>
        /// Получает часть строки, соответствующую данным из указанного хранилища.
        /// </summary>
        /// <typeparam name="T">Хранилище (Status, Activate, Personal)</typeparam>
        /// <param name="allParts">"сырая" строка</param>
        /// <returns>string</returns>
        private string GetPart<T>(string[] allParts)
        {
            if (typeof(T) == typeof(Status))
            {
                string saveable = allParts[0].Replace("STATUS:", "").Replace("]", "");

                return saveable;
            }
            else if (typeof(T) == typeof(Activate))
            {
                allParts = allParts[1].Split('[');
                string saveable = allParts[0].Replace("ACTIVATE:", "").Replace("]", "");

                return saveable;
            }
            else if (typeof(T) == typeof(Personal))
            {
                allParts = allParts[2].Split('[');
                string saveable = allParts[0].Replace("STATUS:", "").Replace("]", "");

                return saveable;
            }
            else
            {
                Error = $"InvalidCast__Type: '{typeof(T).ToString()}' not exists.";

                return string.Empty;
            }
        }
        #endregion
    }
}
