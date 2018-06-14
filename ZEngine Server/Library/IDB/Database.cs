using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZEngine_Server.Library.IDB
{
    class Database
    {
        public const string EMPTY_RESPONSE           = "NON_RESPONSE";
        public const string EXECUTEABLE_REQUEST      = "REQUEST_OK";
        public const string NONEXECUTEABLE_REQUEST   = "REQUEST_ERROR";
        public const string UNEXISTS_CONNECTION_DATA = "UNKNOWN_CONN_DATA";

        protected bool IsConnected = false;

        protected Dictionary<string, string> p_Configuration = new Dictionary<string, string>();
        protected QueryCollection p_QueryCollection = new QueryCollection();
        protected MySqlConnection p_Connection;

        protected void InitializeDatabase()
        {
            IsConnected = Connect();

            if (IsConnected)
            {
                p_QueryCollection.InitializeCollection();
            }
        }

        protected T Exact<T>(string query, string[] args)
        {
            if(!IsConnected)
            {
                IsConnected = Connect();
            }

            if(NonParsed(query))
            {
                query = Parse(query, args);
            }

            return Exact<T>(query);
        }

        protected string Parse(string line, string[] args)
        {
            char[] chars = line.ToCharArray();

            int index = 0;
            string parsed = "";
            for(int i = 0; i < chars.Length; i++)
            {
                string symbol = chars[i].ToString();

                if(symbol == "?")
                {
                    symbol = args[index];
                    index++;
                }

                parsed += symbol;
            }

            return parsed;
        }

        protected bool NonParsed(string query)
        {
            if (query.Contains("?"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private T Exact<T>(string query)
        {
            if(typeof(T) == typeof(bool))
            {
                MySqlCommand command = new MySqlCommand(query, p_Connection);

                try
                {
                    command.ExecuteNonQuery();

                    return (T)(object)true;
                }
                catch (Exception ex)
                {
                    //$"[IDB]: Exception occured: {ex.Message}".ToColor(String.Colors.DarkRed);

                    return (T)(object)false;
                }
            }
            else if(typeof(T) == typeof(string))
            {
                MySqlCommand command = new MySqlCommand(query, p_Connection);

                try
                {
                    command.ExecuteNonQuery();

                    return (T)(object)EXECUTEABLE_REQUEST;
                }
                catch (Exception ex)
                {
                    //$"[IDB]: Exception occured: {ex.Message}".ToColor(String.Colors.DarkRed);

                    return (T)(object)NONEXECUTEABLE_REQUEST;
                }
            }
            else if(typeof(T) == typeof(int))
            {
                MySqlCommand command = new MySqlCommand(query, p_Connection);

                try
                {
                    command.ExecuteNonQuery();

                    return (T)(object)1;
                }
                catch (Exception ex)
                {
                    //$"[IDB]: Exception occured: {ex.Message}".ToColor(String.Colors.DarkRed);

                    return (T)(object)0;
                }
            }
            else if(typeof(T) == typeof(MySqlDataReader))
            {
                MySqlCommand command = new MySqlCommand(query, p_Connection);

                try
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    return (T)(object)reader;
                }
                catch (Exception ex)
                {
                    //$"[IDB]: Exception occured: {ex.Message}".ToColor(String.Colors.DarkRed);

                    return default(T);
                }
            }
            else
            {
                return default(T);
            }
        }

        private bool Connect()
        {
            if(IsConnected)
            {
                return true;
            }
            else
            {
                try
                {
                    p_Connection = new MySqlConnection(CreateConnectionArgs());
                    p_Connection.Open();
                    p_Connection.StateChange += P_Connection_StateChange;

                    return true;
                }
                catch(Exception ex)
                {
                    $"[EXCEPTION]: message: {ex.Message}, {ex.Source}:{ex.LineNumber()}".ToColor(String.Colors.DarkRed);
                    return false;
                }
            }
        }

        private void P_Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            p_Connection.Close();
            IsConnected = false;
            $"[IDB]: Connection state sucessfully restarted.".ToColor(String.Colors.Yellow);
        }

        private string CreateConnectionArgs(string[] args = null)
        {
            if (args == null)
            {
                AppendConfiguration();
                args = new string[4];
            }
            else
            {
                AppendConfiguration(args[0], args[1], args[2], args[3]);
            }

            p_Configuration.Values.CopyTo(args, 0);
            string line = Parse("server=?;user=?;database=?;password=?;Convert Zero Datetime=True", args);

            return line;
        }

        private void AppendConfiguration(
            string server     = "localhost",
            string user       = "root",
            string database   = "zeserver",
            string password   = "12589635"
            )
        {
            p_Configuration.Clear();

            try
            {
                p_Configuration.Add("property_server", server);
                p_Configuration.Add("property_user", user);
                p_Configuration.Add("property_database", database);
                p_Configuration.Add("property_password", password);
            }
            catch (Exception ex)
            {
                $"[EXCEPTION]: {ex.Message}:{ex.LineNumber()}".Error();
                foreach (var prop in p_Configuration)
                {
                    $"[DBG_TRACE]: {prop.Key} => {prop.Value}".ToColor(String.Colors.Aqua);
                }
            }
        }
    }
}
