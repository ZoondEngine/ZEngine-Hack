using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZEngine_Hack
{
    class Provider
    {
        public static Library.Ini.Manager IniHandler = new Library.Ini.Manager("Application\\App.ini");
        //public static MHRebeller.Initializer HwidManager = new MHRebeller.Initializer();
        public static Library.IconVisualizer.Obj IconVisualizer = new Library.IconVisualizer.Obj();
        public static Library.Settinger.Obj Settinger = new Library.Settinger.Obj();
        public static Library.Server.Connection Connection = new Library.Server.Connection();
    }
}
