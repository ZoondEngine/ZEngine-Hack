using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOStack;
using IOStack.Exceptions;

namespace ZEngine_Server.Helpers
{
    class IOStackHelper
    {
        private Dictionary m_IOStackDictionary = new Dictionary();

        public IOStackHelper()
        {
            InitializeCommands();
        }

        public void InitializeCommands()
        {
            Dictionary<string, CommandTask>      uniqueCollection       = new Dictionary<string, CommandTask>();
            Dictionary<string, ParametrizedTask> parametrizedCollection = new Dictionary<string, ParametrizedTask>();
            Dictionary<string, string>           commandsDescriptions   = new Dictionary<string, string>();

            /*
             * Include commands here
             */

            //Unqiue commands
            uniqueCollection.Add("help", Tasks.UniqueTasks.OnHelp);
            uniqueCollection.Add("cmdtime", Tasks.UniqueTasks.OnCmdTime);
            uniqueCollection.Add("cmdstart", Tasks.UniqueTasks.OnCmdStart);
            uniqueCollection.Add("cmdstop", Tasks.UniqueTasks.OnCmdStop);

            //Parametrized commands
            parametrizedCollection.Add("cmdtime", Tasks.ParametrizedTasks.OnCmdTimeSet);
            parametrizedCollection.Add("timersetinterval", Tasks.ParametrizedTasks.OnTimerSetInterval);

            /*
             * End commands includes
             */

            /*
             * Commands descriptions here
             */
            commandsDescriptions.Add("/help", "For getting help about commands");
            commandsDescriptions.Add("/cmd time", "Show info about server time");
            commandsDescriptions.Add("/cmd time -p", "Set datetime information in server");
            commandsDescriptions.Add("/cmd start", "Start command listener module");
            commandsDescriptions.Add("/cmd stop", "Stop command listener module");
            commandsDescriptions.Add("/timer set interval -p [-l]", "Setting cleaner timer. Attr: [-l] switched type setting (once or all)");

            $"[IO]: Helper '{typeof(IOStackHelper).Name}' for module 'IO' initializing ...".ToColor(String.Colors.Blue);
            AddCommandDescriptionsCollection(commandsDescriptions);
            /*
             * End commands descriptions
             */

            //Musteable methods for adding
            AddUniqueStack(uniqueCollection);
            AddParametrizedStack(parametrizedCollection);

            Console.WriteLine();
        }

        public bool IsListen()
        {
            return Algorithm.Instance.IsListen;
        }

        public void Listen()
        {
            if(m_IOStackDictionary.Empty())
            {
                $"[IO]: There are no items in the collection.".ToColor(String.Colors.DarkRed);

                return;
            }

            if(Algorithm.Instance.IsListen)
            {
                $"[IO]: Module already listened.".ToColor(String.Colors.DarkRed);
            }
            else
            {
                Algorithm.Instance.Start(m_IOStackDictionary);
                $"[IO]: Module has been started successfully.".ToColor(String.Colors.DarkCyan);
            }
        }

        public void Destroy()
        {
            if (m_IOStackDictionary.Empty())
            {
                $"[IO]: There are no items in the collection.".ToColor(String.Colors.DarkRed);

                return;
            }

            if (!Algorithm.Instance.IsListen)
            {
                $"[IO]: Module already destroyed.".ToColor(String.Colors.DarkCyan);
            }
            else
            {
                Algorithm.Instance.Stop();

                $"[IO]: Module destroyed was successfully.".ToColor(String.Colors.DarkRed);
            }
        }

        public void AddCommandDescriptionsCollection(Dictionary<string, string> descriptions)
        {
            $"[IO]: Adding descriptions for all commands".ToColor(String.Colors.DarkCyan);

            foreach(var desc in descriptions)
            {
                m_IOStackDictionary.AddCommandDescription(desc.Key, desc.Value);
            }
        }

        public Dictionary<string, string> GetCommandsDescriptions()
        {
            return m_IOStackDictionary.GetCommandDescriptions();
        }

        public void AddUniqueStack(Dictionary<string, CommandTask> commandsModules)
        {
            foreach(var module in commandsModules)
            {
                AddUnique(module.Key, module.Value);
            }
        }

        public void AddUnique(string command, CommandTask task)
        {
            if(m_IOStackDictionary.ExistsInUnique(command))
            {
                $"[IO]: Trying added now exists command. Error while adding.".ToColor(String.Colors.DarkRed);
            }
            else
            {
                m_IOStackDictionary.AddUniqueCommand(command, task);

                $"[IO]: Command '{command}' (unique) was successfully added.".ToColor(String.Colors.DarkCyan);
            }
        }

        public void AddParametrizedStack(Dictionary<string, ParametrizedTask> commandsModules)
        {
            foreach(var module in commandsModules)
            {
                AddParametrized(module.Key, module.Value);
            }
        }

        public void AddParametrized(string command, ParametrizedTask task)
        {
            if(m_IOStackDictionary.ExistsInParametrized(command))
            {
                $"[IO]: Trying added now exists command. Error while adding.".ToColor(String.Colors.DarkRed);
            }
            else
            {
                m_IOStackDictionary.AddParametrizedCommand(command, task);

                $"[IO]: Command '{command}' (parametrized) was successfully added.".ToColor(String.Colors.DarkCyan);
            }
        }
    }

    class Tasks
    {
        public static class Parameters
        {
            public static DateTime SettingDate = DateTime.Now;
        }

        public static class UniqueTasks
        {
            /// <summary>
            /// Метод-обработчик команды '/cmd time'
            /// </summary>
            public static void OnCmdTime()
            {
                string response = $"[IOStack]: DateTime information => " +
                    $"DATE[{Parameters.SettingDate.Day}/{Parameters.SettingDate.Month}/{Parameters.SettingDate.Year}] || " +
                    $"TIME[{Parameters.SettingDate.Hour}:{Parameters.SettingDate.Minute}:{Parameters.SettingDate.Second}]";

                response.ToColor(String.Colors.DarkCyan);
            }

            /// <summary>
            /// Метод-обработчик команды '/cmd stop'
            /// </summary>
            public static void OnCmdStop()
            {
                Algorithm.Instance.Stop();
            }

            /// <summary>
            /// Метод-обработчик команды '/cmd stop'
            /// </summary>
            public static void OnCmdStart()
            {
                Algorithm.Instance.Start();
            }

            public static void OnHelp()
            {
                Dictionary<string, string> descriptions = IGC.IOStack.GetCommandsDescriptions();

                $"[IO]: Availible commands: {descriptions.Count()} counts".ToColor(String.Colors.Blue);

                foreach(var command in descriptions)
                {
                    $"[IO]: {command.Key} - {command.Value}".ToColor(String.Colors.Olive);
                }
            }
        }

        public static class ParametrizedTasks
        {
            /// <summary>
            /// Метод-обработчик команды '/cmd time -p'
            /// </summary>
            /// <param name="args">Параметры команды</param>
            public static void OnCmdTimeSet(string[] args)
            {
                DateTime setting = new DateTime();

                $"[IOStack]: Enter the date (00/00/0000)".ToColor(String.Colors.DeepPink);
                Console.Write("> ");
                string date = Console.ReadLine();
                string[] parsedDate = date.Split('/');

                $"[IOStack]: Enter the time (00:00:00)".ToColor(String.Colors.DeepPink);
                Console.Write("> ");
                string time = Console.ReadLine();
                string[] parsedTime = time.Split(':');

                setting = DateTime.ParseExact(date + " " + time, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                $"[IOStack]: Setting date: {setting.Day}/{setting.Month}/{setting.Year} {setting.Hour}:{setting.Minute}:{setting.Second} successfully !".ToColor(String.Colors.ForestGreen);

                Parameters.SettingDate = setting;
            }

            public static void OnTimerSetInterval(string[] args)
            {
                try
                {
                    if (args[0].Contains("-l"))
                    {
                        $"[IOStack]: Enter the timer index: ".ToColor(String.Colors.DeepPink);
                        Console.Write("> ");
                        string index = Console.ReadLine();

                        $"[IOStack]: Enter new timer interval: ".ToColor(String.Colors.DeepPink);
                        Console.Write("> ");
                        string interval = Console.ReadLine();

                        IGC.Cleaner.ChangeInterval(Int32.Parse(index), Int32.Parse(interval));
                    }
                }
                catch(Exception)
                {
                    $"[IOStack]: Enter new interval: ".ToColor(String.Colors.DeepPink);
                    Console.Write("> ");
                    string cmd = Console.ReadLine();

                    IGC.Cleaner.ChangeInterval(Int32.Parse(cmd));
                }
            }
        }
    }
}
