using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server
{
    public static class IGC
    {
        internal static Library.Automatic Automatic = new Library.Automatic();
        internal static Library.ION.Network Network = new Library.ION.Network();

        internal static Helpers.TrashCleaner Cleaner = new Helpers.TrashCleaner();
        internal static Helpers.IOStackHelper IOStack = new Helpers.IOStackHelper();
        internal static Helpers.IDB.Clients ClientsDatabase = new Helpers.IDB.Clients();
        internal static Helpers.IDB.Information DatabaseInfo = new Helpers.IDB.Information();
    }
}
