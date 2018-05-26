using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack.Library.Conn
{
    class Obj
    {
        public enum ConnectionStatus
        {
            NotConnected,
            LimitedAccess,
            Connected
        }

        public static ConnectionStatus CheckInternet()
        {
            // Проверить подключение к dns.msftncsi.com
            try
            {
                IPHostEntry entry = Dns.GetHostEntry("api.zehack.ru");
                if (entry.AddressList.Length == 0)
                {
                    return ConnectionStatus.NotConnected;
                }
                else
                {
                    if (!entry.AddressList[0].ToString().Equals("77.82.86.211"))
                    {
                        return ConnectionStatus.LimitedAccess;
                    }
                }
            }
            catch
            {
                return ConnectionStatus.NotConnected;
            }

            // Проверить загрузку документа ncsi.txt
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.msftncsi.com/ncsi.txt");
            try
            {
                HttpWebResponse responce = (HttpWebResponse)request.GetResponse();

                if (responce.StatusCode != HttpStatusCode.OK)
                {
                    return ConnectionStatus.LimitedAccess;
                }
                using (StreamReader sr = new StreamReader(responce.GetResponseStream()))
                {
                    if (sr.ReadToEnd().Equals("Microsoft NCSI"))
                    {
                        return ConnectionStatus.Connected;
                    }
                    else
                    {
                        return ConnectionStatus.LimitedAccess;
                    }
                }
            }
            catch
            {
                return ConnectionStatus.NotConnected;
            }

        }
    }
}
