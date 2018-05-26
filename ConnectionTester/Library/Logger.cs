using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTester.Library
{
    public enum LogTypes
    {
        Debug    = 0,
        Warning  = 1,
        Error    = 2,
        Core     = 3,
        Network  = 4,
        Database = 5
    }

    public static class Logger
    {
        private const string DIR = "Logs\\";

        private static Dictionary<LogTypes, string> LogFiles = new Dictionary<LogTypes, string>();

        public static void Write(LogTypes type, string what)
        {
            InitDictionary();

            if(!Directory.Exists(DIR))
            {
                Directory.CreateDirectory(DIR);
            }

            if(!File.Exists(DIR + LogFiles[type]))
            {
                File.Create(DIR + LogFiles[type]).Dispose();
            }

            File.AppendAllText(DIR + LogFiles[type], $"[{DateTime.Now.ToString()}] >> {what}\n");
        }

        private static void InitDictionary()
        {
            if (LogFiles.ContainsKey(LogTypes.Debug))
                return;

            LogFiles.Add(LogTypes.Debug, "info.dbg");
            LogFiles.Add(LogTypes.Warning, "warn.dbg");
            LogFiles.Add(LogTypes.Error, "err.dbg");
            LogFiles.Add(LogTypes.Core, "core.dbg");
            LogFiles.Add(LogTypes.Network, "network.dbg");
            LogFiles.Add(LogTypes.Database, "database.dbg");
        }
    }
}
