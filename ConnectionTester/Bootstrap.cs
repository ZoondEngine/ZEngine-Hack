using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTester
{
    class Bootstrap
    {
        /// <summary>
        /// Возвращает объект для автоматизации фоновых процессов.
        /// </summary>
        internal static Library.Automatic Automatic = new Library.Automatic();

        /// <summary>
        /// Возвращает объект для взаимодействия с сетевой линией.
        /// </summary>
        internal static Library.Net       Ethernet  = new Library.Net();
    }
}
