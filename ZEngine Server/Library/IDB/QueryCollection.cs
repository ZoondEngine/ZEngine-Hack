using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEngine_Server.Library.IDB.Exceptions;

namespace ZEngine_Server.Library.IDB
{
    class QueryCollection
    {
        private Dictionary<string, string> Collection = new Dictionary<string, string>();

        public const string UNDEFINED_QUERY = "NON_QUERY";

        public string this[string key]
        {
            get
            {
                if (Collection.ContainsKey(key))
                {
                    return Collection[key];
                }
                else
                {
                    return UNDEFINED_QUERY;
                }
            }

            set
            {
                if(!Collection.ContainsKey(key))
                {
                    Collection.Add(key, value);
                }
                else
                {
                    throw new KeyExistsInCollectionException($"Key {key} is exists in query collection");
                }
            }
        }

        public void InitializeCollection()
        {
            Collection.Add("select_all_from_clients", "SELECT * FROM clients");
            Collection.Add("select_all_from_clients_where_name", "SELECT * FROM clients WHERE name='?'");
            Collection.Add("select_all_from_clients_where_ip", "SELECT * FROM clients WHERE ip='?'");
            Collection.Add("select_all_from_clients_where_hwid", "SELECT * FROM clients WHERE hwid='?'");
            Collection.Add("insert_to_clients", "INSERT INTO clients (ban, admin, test, free, ch_key, register_date, expire_date, hwid, name, discord, ip) " +
                                                "VALUES ('?', '?', '?','?', '?', '?', '?', '?','?', '?','?')");
            Collection.Add("update_clients_where_hwid", "UPDATE clients SET ban='?', admin='?', test='?', free='?', ch_key='?', register_date='?', expire_date='?', hwid='?'," +
                    "name='?', discord='?',ip='?' WHERE hwid='?'");

            //Payments queries
            Collection.Add("select_all_from_payments", "SELECT * FROM payments");
        }

        public bool Add(string key, string value)
        {
            if(!Collection.ContainsKey(key))
            {
                Collection.Add(key, value);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(string key)
        {
            if(Collection.ContainsKey(key))
            {
                Collection.Remove(key);

                return true;
            }
            else
            {
                return false;
            }
        }

        public Dictionary<string, string> GetCollection()
        {
            return Collection;
        }
    }
}
