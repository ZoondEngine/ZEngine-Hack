using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZEngine_Server.Library.Database
{
    class Connection
    {
        private const string ConnectString = "server=localhost;user=root;database=zeserver;password=12589635;Convert Zero Datetime=True";
        private MySqlConnection Conn;
        private MySqlDataReader Reader;
        private string Info;
        private bool IsOpened = false;

        public Connection()
        {
            try
            {
                Conn = new MySqlConnection(ConnectString);

                if (AppSettings.IsDebug || AppSettings.DebugLevel == 3)
                    "[DATABASE] >> Connection initialized".Debug();

                Open();
            }
            catch(Exception e)
            {
                Info = $"[DATABASE] Couldn't open database connection. Reporting the developer\n[DB->ERROR] {e.Message}";
                Info.Error();
            }
        }

        private void Open()
        {
            if (!IsOpened)
            {
                try
                {
                    Conn.Open();
                    IsOpened = true;
                }
                catch(Exception e)
                {
                    $"[DATABASE] >> Couldn't opened connection: {e.Message}".Error();
                }
            }
        }

        public void Close()
        {
            if (IsOpened)
            {
                try
                {
                    Conn.Close();
                    IsOpened = false;
                }
                catch(Exception e)
                {
                    $"[DATABASE] >> Couldn't closed connection: {e.Message}".Error();
                }
            }
        }

        internal MySqlDataReader ReturneableQuery(string query)
        {
            Close();
            Open();

            MySqlCommand command = new MySqlCommand(query, Conn);

            if (AppSettings.IsDebug || AppSettings.DebugLevel == 3)
                $"[DATABASE] >> Execute [R] query '{query}'".Debug();

            try
            {
                Reader = command.ExecuteReader();

                return Reader;
            }
            catch (Exception e)
            {
                $"[DATABASE] Query error: '{e.Message}'".Error();

                Close();

                return null;
            }
        }

        internal void NonExecuteQuery(string query)
        {
            Close();
            Open();

            MySqlCommand command = new MySqlCommand(query, Conn);

            if (AppSettings.IsDebug || AppSettings.DebugLevel == 3)
                $"[DATABASE] >> Execute [N] query '{query}'".Debug();

            try
            {
                command.ExecuteNonQuery();

                Close();
            }
            catch (Exception e)
            {
                $"[DATABASE] Query error: '{e.Message}'".Error();

                Close();
            }
        }
    }
}
