using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Server.Library
{
    public static class CmdActions
    {
        private static Dictionary<string, string> Commands = new Dictionary<string, string>()
        {
            {"/help", "Показать помощь по списку комманд"},
            {"/disconnect", "Отключить клиента(-ов). Например /disconnect all"},
            {"/cmd", "Команды управления модулем <COMMANDER>. Например /cmd start"},
            {"/client", "Команды управление клинтом. Например /client ban 127.0.0.1 reason"},
            {"/msg", "Команда отправки сообщения пользователю(-ям). Например /msg 127.0.0.1[-all] msgText"},
        };

        public static void OnHelp()
        {
            foreach(var command in Commands)
            {
                $"[COMMANDER] >> HELP :: {command.Key} - {command.Value}".Core();
            }
        }

        public static void OnDisconnectOne(string ip, string what)
        {
            Program.Connection.DisconnectOneClient(ip);
        }

        public static void OnDisconnectAll()
        {
            "[COMMANDER] >> All users disconnected manually.".Debug();
        }

        public static void OnP2PAll()
        {
            Program.Connection.ShowP2PAll();
        }

        public static void OnP2POne(string ip)
        {
            Program.Connection.ShowP2POne(ip);
        }

        public static void OnMsgAll(string what)
        {
            Program.Connection.ResponseMessagesAll(what);

            $"[COMMANDER] >> Message sent to all. Msg: '{what}'".Debug();
        }

        public static void OnMsgOne(string ip, string what)
        {
            Program.Connection.ResponseMessage(ip, what);

            $"[COMMANDER] >> Message sent to client: '{ip}'. Msg: '{what}'".Debug();
        }

        public static void OnBan(string ip, string what)
        {
            Program.Connection.Ban(ip, what);

            $"[COMMANDER] >> Client: '{ip}' has been banned. Reason: '{what}'".Warning();
        }

        public static void OnUnban(string ip)
        {
            if(Program.Connection.Unban(ip))
            {
                $"[COMMANDER] >> Client: '{ip}' already unbanned.".Success();
            }
            else
            {
                $"[COMMANDER] >> Client: '{ip}' not finded in database.".Error();
            }
        }

        internal static void OnCreateUser(string nickname, string hwid, string ipaddr, string license, string admin)
        {
            //Creating user ...
            if(Program.Connection.CreateUser(nickname, hwid, ipaddr, Int32.Parse(license), Boolean.Parse(admin)))
            {
                $"[COMMANDER] User '{nickname}' has been successfully created. License time: '{license}':hwid('{hwid}')".Success();
            }
            else
            {
                $"[COMMANDER] Ureacheable error for creating user. Incorrect error while creating.".Error();
            }
        }
    }

    class Commander
    {
        private Sypher.RC4 RC4_Encode = new Sypher.RC4(Encoding.ASCII.GetBytes("MyKey"));
        private Sypher.RC4 RC4_Decode = new Sypher.RC4(Encoding.ASCII.GetBytes("MyKey"));

        private bool IsListen = false;

        public static Commander Instance = new Commander();

        public void Start()
        {
            "[COMMANDER] >> Ready for listen tool commands. Enter '/help' ".Success();

            IsListen = true;

            Loop();
        }

        public void Stop()
        {
            "[COMMANDER] >> Module: 'Commander' is disabled.".Error();

            IsListen = false;

            Loop();
        }

        public void Loop()
        {
            while(IsListen)
            {
                string input = Console.ReadLine();

                if(!input.Contains("/"))
                {
                    $"[COMMANDER] >> Unknown command: '{input}'. Maybe doesn't exists '/' ?".Error();

                    Loop();
                }
                else
                {
                    Dispatch(input);
                }
            }
        }

        private void Dispatch(string dispatch)
        {
            string[] splitted = dispatch.Split(' ');

            if (!IsListen && splitted[0] != "/cmd")
            {
                return;
            }

            switch (splitted[0])
            {
                case "/help":
                    {
                        CmdActions.OnHelp();

                        break;
                    }

                case "/client":
                    {
                        if(splitted.Count() >= 2)
                        {
                            switch(splitted[1])
                            {
                                case "create":
                                    {
                                        if(splitted.Count() >= 7)
                                        {
                                            CmdActions.OnCreateUser(splitted[2], splitted[3], splitted[4], splitted[5], splitted[6]);
                                        }
                                        else
                                        {
                                            $"[COMMANDER] >> User '' has been not a created. Maybe incorrect syntax '/client create'. Example '/client create [-username] [-hwid] [-ipaddr] [-license] [-admin]'".Error();
                                        }

                                        break;
                                    }

                                case "ban":
                                    {
                                        if (splitted.Count() >= 4)
                                            CmdActions.OnBan(splitted[2], splitted[3]);
                                        else
                                            $"[COMMANDER] >> Incorrect syntax for command '/client ban'. Example /client ban 127.0.0.1 reason".Error();

                                        break;
                                    }

                                case "unban":
                                    {
                                        if (splitted.Count() >= 3)
                                            CmdActions.OnUnban(splitted[2]);
                                        else
                                            $"[COMMANDER] >> Incorrect syntax for command '/client unban'. Example /client unban 127.0.0.1".Error();

                                        break;
                                    }

                                case "p2p":
                                    {
                                        if(splitted.Count() >= 3)
                                        {
                                            switch(splitted[2])
                                            {
                                                case "all":
                                                    {
                                                        CmdActions.OnP2PAll();

                                                        break;
                                                    }

                                                default:
                                                    {
                                                        CmdActions.OnP2POne(splitted[2]);
                                                        
                                                        break;
                                                    }
                                            }
                                        }
                                        else
                                        {
                                            $"[COMMANDER] >> Incorrect syntax for command '/client p2p'. Example /client p2p all".Error();
                                        }

                                        break;
                                    }

                                default:
                                    {
                                        $"[COMMANDER] >> Unknown command: '{splitted[1]}'".Error();

                                        break;
                                    }
                            }
                        }

                        break;
                    }

                    //TEST
                case "/syph":
                    {
                        string textplain = "Non encrypted some text";
                        byte[] textbytes = Encoding.ASCII.GetBytes(textplain);
                        byte[] result = RC4_Encode.Encode(textbytes, textbytes.Length);
                        byte[] decryptedbytes = RC4_Decode.Decode(result, result.Length);
                        string decyptedtext = Encoding.ASCII.GetString(decryptedbytes);
                        string encryptedtext = Encoding.ASCII.GetString(result);

                        $"[COMMANDER] >> TEST SYPH: {encryptedtext}({result}) <=> {decyptedtext}({decryptedbytes})".Database();

                        break;
                    }

                case "/disconnect":
                    {
                        if (splitted.Count() >= 2)
                        {
                            switch (splitted[1])
                            {
                                case "all":
                                    {
                                        CmdActions.OnDisconnectAll();

                                        break;
                                    }

                                default:
                                    {
                                        if (splitted.Count() > 2)
                                        {
                                            CmdActions.OnDisconnectOne(splitted[1], splitted[2]);
                                        }
                                        else
                                        {
                                            $"[COMMANDER] >> Incorrect syntax for command: '{splitted[0]} {splitted[1]}'. Example: /disconnect 127.0.0.1".Error();
                                        }

                                        break;
                                    }
                            }
                        }
                        else
                        {
                            $"[COMMANDER] >> Invalid arguments for command: '{splitted[0]}'.".Error();
                        }

                        break;
                    }

                case "/database":
                    {
                        if(splitted[1].Count() < 0)
                        {
                            return;
                        }

                        switch(splitted[1])
                        {
                            case "clients":
                                {
                                    

                                    break;
                                }
                        }

                        break;
                    }

                case "/msg":
                    {
                        if (splitted[1].Count() >= 3) // 1. 2. 3. 4. 
                        {
                            switch (splitted[1])
                            {
                                case "all":
                                    {
                                        CmdActions.OnMsgAll(splitted[2]);

                                        break;
                                    }

                                default:
                                    {
                                        if (splitted[2].Count() > 2)
                                        {
                                            CmdActions.OnMsgOne(splitted[1], splitted[2]);
                                        }
                                        else
                                        {
                                            $"[COMMANDER] >> Incorrect syntax for command: '{splitted[0]} {splitted[1]}'. Example: /msg 127.0.0.1 Hello".Error();
                                        }

                                        break;
                                    }
                            }
                        }
                        else
                        {
                            $"[COMMANDER] >> Invalid arguments for command: '{splitted[0]}'.".Error();
                        }

                        break;
                    }

                case "/cmd":
                    {
                        if(splitted.Count() >= 2)
                        {
                            switch(splitted[1])
                            {
                                case "start":
                                    {
                                        Start();

                                        break;
                                    }

                                case "stop":
                                    {
                                        Stop();

                                        break;
                                    }

                                default:
                                    {
                                        $"[COMMANDER] >> Unknown syntax for command '{splitted[0]}'. Example: /cmd start".Error();

                                        break;
                                    }
                            }
                        }
                        else
                        {
                            $"[COMMANDER] >> Invalid arguments for command: '{splitted[0]}'.".Error();
                        }

                        break;
                    }

                default:
                    {
                        $"[COMMANDER] >> Unknown command: '{splitted[0]}'. Command doesn't exists.".Error();

                        break;
                    }
            }
        }
    }
}
