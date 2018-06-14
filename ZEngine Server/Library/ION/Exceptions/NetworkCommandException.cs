using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server.Library.ION.Exceptions
{
    class NetworkCommandException : Exception
    {
        public NetworkCommandException(string message) : base(message) { }
    }
}
