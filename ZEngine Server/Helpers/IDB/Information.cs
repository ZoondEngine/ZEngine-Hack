using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEngine_Server.Library.IDB;
using MySql.Data.MySqlClient;

namespace ZEngine_Server.Helpers.IDB
{
    class Information : Database
    {
        public Information()
        {
            InitializeDatabase();
        }

        public void ShowStartInformation()
        {
            var reader = Exact<MySqlDataReader>(p_QueryCollection["select_all_from_clients"], null);

            $"[IDB]: Scanning 'clients' database ...".ToColor(String.Colors.DarkCyan);

            int counter = 0;
            while(reader.Read())
            {
                if(reader[0] != null)
                {
                    $"[IDB]: User: '{reader[9]}(ID: {reader[0]})' founded. IP-Address: '{reader[11]}'".ToColor(String.Colors.Yellow);
                    counter++;
                }
            }

            $"[IDB]: Database 'clients' is normally. Founded users: '{counter}'".ToColor(String.Colors.ForestGreen);
            reader.Close();

            $"[IDB]: Scanning 'payments' database ...".ToColor(String.Colors.DarkCyan);
            if (p_QueryCollection["select_all_from_payments"] != QueryCollection.UNDEFINED_QUERY)
            {
                reader = Exact<MySqlDataReader>(p_QueryCollection["select_all_from_payments"], null);

                counter = 0;
                while (reader.Read())
                {
                    if (reader[0] != null)
                    {
                        $"[IDB]: Payment '{reader[4]}(ID: {reader[0]})' founded. IP: '{reader[6]}'".ToColor(String.Colors.Yellow);
                        counter++;
                    }
                }

                $"[IDB]: Database 'payments' is normally. Founded active payments: '{counter}'".ToColor(String.Colors.ForestGreen);
                reader.Close();
            }
            else
            {
                $"[IDB]: Database 'payments' needed a repair !".ToColor(String.Colors.IndianRed);
            }
        }
    }
}
