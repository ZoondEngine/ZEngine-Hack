using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server.Library.IDB.Exceptions
{
    class KeyExistsInCollectionException : Exception
    {
        public KeyExistsInCollectionException(string message) : base(message) { }
    }
}
