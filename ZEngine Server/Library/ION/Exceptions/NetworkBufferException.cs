using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server.Library.ION.Exceptions
{
    class NetworkBufferException : Exception
    {
        public NetworkBufferException(string message) : base(message) { }
    }
}
