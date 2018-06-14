using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_RED.Library.IOD.Exceptions
{
    class CrossAccessException : Exception
    {
        public CrossAccessException(string message) : base(message) { }
    }
}
