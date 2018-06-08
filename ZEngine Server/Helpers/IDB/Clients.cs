using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEngine_Server.Library.IDB;
using MySql.Data.MySqlClient;

namespace ZEngine_Server.Helpers.IDB
{
    class Clients : Database
    {
        public Clients()
        {
            InitializeDatabase();
        }

        public bool CreateNewUser(string[] data)
        {
            string[] parameters = new string[]
            {
                "False", "False", "False", "False", $"{GenerateCheatKey()}",
                $"{DateTime.Now.Date}", $"{DateTime.Now.Date.AddDays(Int32.Parse(data[4]))}",
                $"{data[0]}", $"{data[1]}", $"{data[2]}", $"{data[3]}"
            };

            return Exact<bool>(p_QueryCollection["insert_to_clients"], parameters);
        }

        public bool CreateFromPay(string hwid)
        {
            //DEVELOPMENT
            return false;
        }

        public bool UpdateUser(string hwid, string[] parameters)
        {
            return Exact<bool>(p_QueryCollection["update_clients_where_hwid"], parameters);
        }

        public string[] LoadUser(string hwid)
        {
            string[] user = null;
            MySqlDataReader reader = Exact<MySqlDataReader>(p_QueryCollection["select_all_from_clients_where_hwid"], new string[] { hwid });

            while(reader.Read())
            {
                if(reader[0] != null)
                {
                    string[] data = new string[11]
                    {
                        (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (string)reader[5],
                        (string)reader[6], (string)reader[7], (string)reader[8], (string)reader[9], (string)reader[10],
                        (string)reader[11]
                    };

                    user = new string[data.Length];
                    user = data;
                }
            }

            reader.Close();

            return user;
        }

        public bool IsLoadeableUser(string hwid)
        {
            return Exact<bool>(p_QueryCollection["select_all_from_clients_where_hwid"], new string[] { hwid });
        }

        public string GetHwidByIP(string ip)
        {
            if (Exact<bool>(p_QueryCollection["select_all_from_clients_where_ip"], new string[] { ip }))
            {
                var reader = Exact<MySqlDataReader>(p_QueryCollection["select_all_from_clients_where_ip"], new string[] { ip });
                string hwid = string.Empty;

                while(reader.Read())
                {
                    if(reader[0] != null)
                    {
                        hwid = (string)reader[8];
                    }
                }

                reader.Close();

                return hwid;
            }
            else
            {
                return EMPTY_RESPONSE;
            }
        }

        private string GenerateCheatKey()
        {
            return "IKKA-13313-33314A-13VGF-13314";
        }
    }
}
