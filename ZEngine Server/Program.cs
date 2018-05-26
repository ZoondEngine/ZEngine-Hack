using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ZEngine_Server
{
    class Program
    {
        public static Library.Connection Connection = new Library.Connection();

        static void Main(string[] args)
        {
            ShowLabel();
            ShowInfo();

            Connection.Listen();

            Library.Commander.Instance.Start();
        }

        private static void ShowLabel()
        {
            Console.WriteLine("██▀▀▀█▀▀▀█▀▀▀█▀▀▀█▀▀▀████████████████████████████████████████████████████████");
            Console.WriteLine("██─█─█─▀▀█─█─█─███─▀▀████████████████████████████████████████████████████████");
            Console.WriteLine("██─▄▄█─███─▀─█─███─██████████████████████████████████████████████████████████");
            Console.WriteLine("██▄███▄▄▄█▄█▄█▄▄▄█▄▄▄███(c)─ZEngine─Trademark.─2018─All─Rights─reserved.█████\n\n");
        }

        private static void ShowInfo()
        {
            Console.WriteLine("======[SERVER INFORMATION]===================================================\n");
            Console.WriteLine("[PNAME]     >> ZEngine Server Application");
            Console.WriteLine($"[PVERSION]  >> {AppSettings.VersionInfo.THREAD}, {AppSettings.VersionInfo.FULL_VERSION}");
            Console.WriteLine("[PAUTHOR]   >> ZEngine Laboratory");
            Console.WriteLine($"[PSOLUTION] >> {AppSettings.VersionInfo.DATE} || {AppSettings.VersionInfo.STAGE}\n\n");

            ShowServerStatus();

            Console.WriteLine("\n\n======[SERVER JOURNALING]====================================================\n");
        }

        private static void ShowServerStatus()
        {
            Console.WriteLine("======[SERVER GENERIC MODULES]===============================================\n");
            Console.Write("RUND_SERVER >> "); "STARTED".Success();
            Console.Write("ACX_PROVIDE >> "); "ACTIVATED".Success();
            Console.Write("PCK_TRAFFER >> "); "SUPPORTED".Success();
        }
    }
}
