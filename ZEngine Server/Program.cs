using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ZEngine_Server
{
    class Program
    {
        private static int OriginalRow, OriginalCol;

        static void Main(string[] args)
        {
            ShowLabel();
            ShowInfo();

            Includes();

            string line = Console.ReadLine();
            if(line == "/cmd start")
            {
                Main(args);
            }
            //Library.Commander.Instance.Start();
        }

        private static void Includes()
        {
            $"[STACK]: Module 'IDB' initializing ...".ToColor(String.Colors.Blue);
            IGC.DatabaseInfo.ShowStartInformation();
            Console.WriteLine();

            $"[STACK]: Module 'ICLE' initializing ...".ToColor(String.Colors.Blue);
            IGC.Cleaner.Initailize();
            Console.WriteLine();

            $"[STACK]: Module 'ION' loading ...".ToColor(String.Colors.Blue);
            IGC.Network.Listen();
            Console.WriteLine();

            $"[STACK]: Module 'IO' loading ...".ToColor(String.Colors.Blue);
            IGC.IOStack.Listen();
            Console.WriteLine();
        }

        private static void ShowLabel()
        {
            Console.WriteLine("██▀▀▀█▀▀▀█▀▀▀█▀▀▀█▀▀▀████████████████████████████████████████████████████████");
            Console.WriteLine("██─█─█─▀▀█─█─█─███─▀▀████████████████████████████████████████████████████████");
            Console.WriteLine("██─▄▄█─███─▀─█─███─██████████████████████████████████████████████████████████");
            Console.WriteLine("██▄███▄▄▄█▄█▄█▄▄▄█▄▄▄███(c)─ZEngine─Trademark.─2018─All─Rights─reserved.█████\n\n");
        }

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(OriginalCol + x, OriginalRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        private static void ShowInfo()
        {
            Console.WriteLine("======[SERVER INFORMATION]===================================================\n");
            Console.WriteLine("[PNAME]     >> ZEngine Server Application");
            Console.WriteLine($"[PVERSION]  >> {AppSettings.VersionInfo.THREAD}, {AppSettings.VersionInfo.FULL_VERSION}");
            Console.WriteLine("[PAUTHOR]   >> RED");
            Console.WriteLine($"[PSOLUTION] >> {AppSettings.VersionInfo.DATE} || {AppSettings.VersionInfo.STAGE}\n\n");

            ShowServerStatus();

            Console.WriteLine("\n\n======[SERVER JOURNALING]====================================================");
            OriginalRow = Console.CursorTop;
            OriginalCol = Console.CursorLeft;
            Console.WriteLine("Loading ...");
            Thread.Sleep(1000);
            WriteAt("           \n", 0, 0);
        }

        private static void ShowServerStatus()
        {
            Console.WriteLine("======[SERVER GENERIC MODULES]===============================================\n");
            Console.Write("RUND_SERVER >> "); "LISTENED".Success();

            Console.Write("ACX_PROVIDE >> "); "ACTIVATED".Success();
            Console.Write("PCK_TRAFFER >> "); "SUPPORTED".Success();
        }
    }
}
