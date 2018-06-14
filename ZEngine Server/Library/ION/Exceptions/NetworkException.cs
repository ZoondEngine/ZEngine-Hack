using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server.Library.ION.Exceptions
{
    class NetworkException : Exception
    {
        public NetworkException(string message) : base(message) { }
    }
}
