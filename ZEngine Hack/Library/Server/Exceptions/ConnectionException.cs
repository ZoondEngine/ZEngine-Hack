using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack.Library.Server.Exceptions
{
    class ConnectionException : Exception
    {
        public ConnectionException(string msg) :  base(msg) { }
    }
}
