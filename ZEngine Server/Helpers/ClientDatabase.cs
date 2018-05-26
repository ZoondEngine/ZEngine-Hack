using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZEngine_Server.Library.Database;
using ZEngine_Server.Repositories;

namespace ZEngine_Server.Helpers
{
    class ClientDatabase : Connection, IDisposable
    {
        #region Class fields
        /// <summary>
        /// Объект хранилища клиента для совершения операций чтения/записи.
        /// </summary>
        private Client m_ClientRepository;

        /// <summary>
        /// Экземпляр объекта подключения к базе данных.
        /// </summary>
        private Connection Connection;
        #endregion

        #region Class objects
        /// <summary>
        /// Возвращает строковое представление о предыдущих ошибках.
        /// </summary>
        public string Error;
        #endregion

        #region Constructor
        /// <summary>
        /// Конструктор класса по умолчанию. Инициализирует объекты для работы.
        /// </summary>
        public ClientDatabase()
        {
            Connection = new Connection();

            Error = string.Empty;
        }
        #endregion

        #region Instance
        /// <summary>
        /// Предоставляет объект настоящего класса для работы с базой данных.
        /// </summary>
        /// <param name="client">Экзмепляр объекта хранилища клиента</param>
        /// <returns>ClieantDatabase</returns>
        public ClientDatabase Instance(Client client)
        {
            m_ClientRepository = client;

            return this;
        }
        #endregion

        #region Implementing methods
        /// <summary>
        /// Выполняет процедуру записи хранилища указанного клиента.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool Save(Client client)
        {
            m_ClientRepository = client;

            Client.Status status = m_ClientRepository.Instance<Client.Status>();
            Client.Activate activate = m_ClientRepository.Instance<Client.Activate>();
            Client.Personal personal = m_ClientRepository.Instance<Client.Personal>();
            Client.Connection connection = m_ClientRepository.Instance<Client.Connection>();

            if(Search(connection.IPAddress))
            {
                string query = "UPDATE " +
                    "clients " +
                    "SET " +
                    $"ban='{status.IsBanned}', admin='{status.IsAdmin}', test='{status.IsTesting}'," +
                    $"free='{activate.IsFree}', ch_key='{activate.Key}', register_date='{activate.RegisterDate}', expire_date='{activate.ExpireDate}', hwid='{activate.HWID}'," +
                    $"name='{personal.Name}', discord='{personal.Discord}'," +
                    $"ip='{connection.IPAddress}'" +
                    "WHERE " +
                    $"ip='{connection.IPAddress}'";

                if (ManualQuery(query))
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
                string query = "INSERT INTO " +
                    "clients " +
                    "(ban, admin, test, free, ch_key, register_date, expire_date, hwid, name, discord, ip) " +
                    "VALUES" +
                    $"('{status.IsBanned}', '{status.IsAdmin}', '{status.IsTesting}'," +                               
                    $"'{activate.IsFree}', '{activate.Key}', '{activate.RegisterDate}', '{activate.ExpireDate}', '{activate.HWID}'," +   
                    $"'{personal.Name}', '{personal.Discord}'," +                                                      
                    $"'{connection.IPAddress}')";

                if(ManualQuery(query))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Save()
        {
            if(m_ClientRepository != null)
            {
                return Save(m_ClientRepository);
            }
            else
            {
                $"[DATABASE] >> Trying to save empty repository.".Error();

                return false;
            }
        }

        /// <summary>
        /// Выполняет процедуру чтения из базы данных для указанного IP-адреса.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public Client Load(string ip)
        {
            if(Search(ip))
            {
                try
                {
                    var reader = ReturneableQuery($"SELECT * FROM clients WHERE ip='{ip}'");
                    while(reader.Read())
                    {
                        if(reader[0] != null)
                        {
                            m_ClientRepository = new Client();
                            string[] data = new string[11]
                            {
                                (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5],
                                (string)reader[6], (string)reader[7], (string)reader[8], (string)reader[9], (string)reader[10],
                                (string)reader[11]
                            };

                            m_ClientRepository.CreateUserFromDatabase(data);

                            reader.Close();

                            return m_ClientRepository;
                        }
                        else
                        {
                            reader.Close();

                            return null;
                        }
                    }
                }
                catch(Exception ex)
                {
                    $"[DATABASE] >> Error: {ex.Message}".Error();

                    return null;
                }
            }
            else
            {
                $"[DATABASE] >> Client: '{ip}' not found in database".Error();

                return null;
            }

            return m_ClientRepository;
        }
        #endregion

        #region Instruments
        /// <summary>
        /// Выполняет ручной запрос в базу данных.
        /// </summary>
        /// <param name="query">Строка запроса</param>
        /// <returns></returns>
        private bool ManualQuery(string query)
        {
            try
            {
                NonExecuteQuery(query);

                return true;
            }
            catch(Exception ex)
            {
                $"[DATABASE] >> Error: {ex.Message}".Error();

                return false;
            }
        }

        /// <summary>
        /// Производит поиск клиента с указанным IP-адресом в базе данных.
        /// </summary>
        /// <param name="ip">IP-адрес клиента</param>
        /// <returns></returns>
        private bool Search(string ip)
        {
            bool find = false;

            try
            {
                string query = $"SELECT * FROM clients WHERE ip='{ip}'";
                var reader = ReturneableQuery(query);

                while(reader.Read())
                {
                    if(reader[0] != null)
                    {
                        find = true;
                    }
                    else
                    {
                        find = false;
                    }

                    break;
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                $"[DATABASE] >> {ex.Message}".Error();

                find = false;
            }

            return find;
        }

        /// <summary>
        /// Выгружает из памяти все занятые классом объекты.
        /// </summary>
        public void Dispose()
        {
            Connection.Close();

            m_ClientRepository = null;
            Connection = null;

            Error = string.Empty;
        }
        #endregion
    }
}
