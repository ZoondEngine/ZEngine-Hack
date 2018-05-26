using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEngine_Server.Library.Database;

namespace ZEngine_Server.Helpers
{
    class PayDatabase : Connection, IDisposable
    {
        public string IPAddress { get; private set; }
        public string HWID { get; private set; }
        public string Key { get; private set; }

        public string Error;

        public PayDatabase()
        {
            IPAddress = string.Empty;
            HWID = string.Empty;
            Key = string.Empty;
        }

        public bool IsPay()
        {
            if(IPAddress == string.Empty)
            {
                return false;
            }
            else
            {
                return IsPay(IPAddress);
            }
        }
        public bool IsPay(string ip)
        {
            bool find = false;

            try
            {
                string query = $"SELECT * FROM payments WHERE ip='{ip}'";
                var reader = ReturneableQuery(query);

                while (reader.Read())
                {
                    if (reader[0] != null)
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
            catch (Exception ex)
            {
                $"[DATABASE] >> {ex.Message}".Error();

                find = false;
            }

            if(!find)
            {
                Error = $"[DATABASE] >> Client: '{ip}' not found in payments database.";
            }

            return find;
        }

        public string[] GetPayData()
        {
            if(IPAddress == string.Empty)
            {
                return null;
            }
            else
            {
                return GetPayData(IPAddress);
            }
        }
        public string[] GetPayData(string ip)
        {
            try
            {
                string[] data = new string[7];
                string query = $"SELECT * FROM payments WHERE ip='{ip}'";
                var reader = ReturneableQuery(query);

                while(reader.Read())
                {
                    if (reader[0] == null)
                    {
                        break;
                    }
                    else
                    {
                        data[0] = reader[0].ToString();
                        data[1] = reader[1].ToString();
                        data[2] = reader[2].ToString();
                        data[3] = reader[3].ToString();
                        data[4] = reader[4].ToString();
                        data[5] = reader[5].ToString();
                        data[6] = reader[6].ToString();
                    }
                }

                reader.Close();

                if(data[0] == null)
                {
                    Error = $"[DATABASE] >> Client: '{ip}' not found in payments database.";

                    return null;
                }
                else
                {
                    return data;
                }
            }
            catch(Exception ex)
            {
                Error = "[PAYDB] >> " + ex.Message + ex.StackTrace;

                return null;
            }
        }

        public void Delete(string ip)
        {
            try
            {
                string query = $"DELETE FROM payments WHERE ip='{ip}'";
                NonExecuteQuery(query);
            }
            catch(Exception ex)
            {
                ex.Message.Error();
                ex.StackTrace.Error();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
