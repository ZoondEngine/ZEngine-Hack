using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack.Library.Server
{
    class DataStore
    {
        public class Packet
        {
            private string ID, Action, Msg;

            public void Parse(string contents)
            {
                string[] cont = contents.Split('.');
                ID = cont[0];
                Action = cont[1];
                Msg = cont[2];
            }

            public override string ToString()
            {
                return $"{ID}.{Action}.{Msg}";
            }
        }

        public class Client
        {

        }
    }
}
