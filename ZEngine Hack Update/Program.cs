using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[*] Updating application...");

            WebClient client = new WebClient
            {
                Credentials = new NetworkCredential("zehack_adm_new", "Cfvjcbqbkmz1112589635")
            };

           
            if (File.Exists("ZEngine Hack.exe"))
            {
                Console.WriteLine("[*] Old version file deleted.");

                try
                {
                    Process general = Process.GetProcessesByName("ZEngine Hack.exe")[0];
                    if (general != null)
                    {
                        Console.WriteLine("[!] Finded general process. Waiting ...");
                        general.WaitForExit();
                    }
                }
                catch(Exception) { }

                try
                {
                    File.Delete("ZEngine Hack.exe");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"[!] {e.Message}");
                }
            }

            Console.WriteLine("[*] Downloading new version application...");
            try
            {
                client.DownloadFile(new Uri("http://api.zehack.ru/ZELab/Updates/LDR/client.exe"), "ZEngine Hack.exe");
            }
            catch(Exception)
            {
                Console.WriteLine($"[!] File not found !");
            }

            Console.WriteLine("[*] Done !");
            Console.WriteLine("[*] Please press 'ENTER' for exit or 'R' for restart");
            ConsoleKeyInfo key = Console.ReadKey();

            if(key.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
            else if(key.Key == ConsoleKey.R)
            {
                Main(args);
            }
        }
    }
}
