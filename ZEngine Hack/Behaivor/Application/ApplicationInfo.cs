using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack.Behaivor.Application
{
    class ApplicationInfo
    {
        public static Version APPLICATION_VERSION   = new Version(3, 20, 011, 41);
        public static Version C_APPLICATION_VERSION = new Version(1, 0, 11, 328);

        public static class API
        {
            internal static string USERNAME = "zehack_adm_new";
            internal static string PASSWORD = "Cfvjcbqbkmz1112589635";
            public static string TARGET = "http://api.zehack.ru/ZELab/";
            public static string USER_TARGET = TARGET + "Activates/";
            public static string ADOWNLOADS_TARGET = TARGET + "Downloads/";
            public static string UPDATES_LDR_TARGET = TARGET + "Updates/LDR/";
            public static string UPDATES_HS_TARGET = TARGET + "Updates/HS/";
            public static string NEWS_ZE_TARGET = TARGET + "News/ZE/";
            public static string NEWS_BH_TARGET = TARGET + "News/BH/";
        }
    }
}
