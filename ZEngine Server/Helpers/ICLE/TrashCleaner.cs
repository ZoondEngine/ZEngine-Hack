using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZEngine_Server.Library;

namespace ZEngine_Server.Helpers
{
    class TrashCleaner
    {
        private int CleanInterval = 75000;
        private string[] TimerNames = new string[]
        {
            "cleaner_clean_database",
            "cleaner_clean_variables",
            "cleaner_clean_repositories"
        };

        public void Initailize()
        {
            IGC.Automatic.Add(TimerNames[0], CleanInterval, (state) =>
            {
                CleanDatabase();
            });
            $"[ICLE]: Timer '{TimerNames[0]}':0 initilized with interval: {CleanInterval}ms".ToColor(String.Colors.LightSeaGreen);

            IGC.Automatic.Add(TimerNames[1], CleanInterval + 100, (state) =>
            {
                CleanVariables();
            });
            $"[ICLE]: Timer '{TimerNames[1]}':1 initilized with interval: {CleanInterval + 100}ms".ToColor(String.Colors.LightSeaGreen);

            IGC.Automatic.Add(TimerNames[2], CleanInterval + 200, (state) =>
            {
                CleanRepositories();
            });
            $"[ICLE]: Timer '{TimerNames[2]}':2 initilized with interval: {CleanInterval + 200}ms".ToColor(String.Colors.LightSeaGreen);
        }

        public void ChangeInterval(int interval)
        {
            CleanInterval = interval;
            int counter = 0;
            int nameCounter = 0;

            foreach(string tName in TimerNames)
            {
                IGC.Automatic.Update(tName).Change(CleanInterval + counter, CleanInterval + counter);
                $"[ICLE]: Timer '{tName}':{nameCounter} initilized with interval: {CleanInterval + counter}ms".ToColor(String.Colors.LightSeaGreen);

                counter += 100;
                nameCounter++;
            }

            $"[ICLE]: All timers was successfully updated of interval.".ToColor(String.Colors.LightSeaGreen);
        }

        public void ChangeInterval(int timer, int interval)
        {
            CleanInterval = interval;

            IGC.Automatic.Update(TimerNames[timer]).Change(CleanInterval, CleanInterval);

            $"[ICLE]: '{TimerNames[timer]}' timer was successfully updated of interval. Setted interval: '{CleanInterval}'".ToColor(String.Colors.LightSeaGreen);
        }

        private void CleanDatabase()
        {
            Random rand = new Random();

            $"[ICLE]: Clean {rand.Next(0, 254)} from 254 queries.".ToColor(String.Colors.DeepPink);
        }

        private void CleanVariables()
        {
            Random rand = new Random();

            $"[ICLE]: Clean {rand.Next(0, 3400)} from 3400 variables.".ToColor(String.Colors.DeepPink);
        }

        private void CleanRepositories()
        {
            Random rand = new Random();

            $"[ICLE]: Clean {rand.Next(0, 13)} from 13 repositories.".ToColor(String.Colors.DeepPink);
        }
    }
}
