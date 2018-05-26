using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server
{
    class AppSettings
    {
        public static bool IsDebug = false;
        public static int DebugLevel = 0;

        public static class Urls
        {
            public static string User = "";
            public static string Pass = "";
            public static string Path = "http://zehack.ru/195.wmv";
        }

        public static class VersionInfo
        {
            public static string THREAD = "MASTER-THREAD";
            public static string FULL_VERSION = "v. 1.00.8.11 ALPHA";
            public static string VERSION = "v 1.01";
            public static string DATE = DateTime.Today.ToShortDateString();
            public static string STAGE = "PRE-ALPHA";
        }
    }
}
