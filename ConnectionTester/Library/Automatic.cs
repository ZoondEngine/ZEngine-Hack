using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionTester.Library
{
    class Automatic
    {
        private Dictionary<string, Timer> Timers;

        public Automatic()
        {
            Timers = new Dictionary<string, Timer>();
        }

        public Timer Add(string name, int interval, EventHandler action)
        {
            if(!Timers.ContainsKey(name))
            {
                Timer timer = new Timer
                {
                    Interval = interval
                };
                timer.Tick += action;

                Timers.Add(name, timer);

                return Update(name);
            }
            else
            {
                Logger.Write(LogTypes.Error, $"'Automatic': trying create already created action. Action: '{name}'");

                return null;
            }
        }

        public void Delete(string name)
        {
            if(Timers.ContainsKey(name))
            {
                Timers.Remove(name);
            }
            else
            {
                Logger.Write(LogTypes.Error, $"'Automatic': trying delete already deleted action. Action: '{name}'");
            }
        }

        public Timer Update(string name)
        {
            if(Timers.ContainsKey(name))
            {
                return Timers[name];
            }
            else
            {
                return null;
            }
        }

        public Dictionary<string, Timer> GetTimerList()
        {
            return Timers;
        }
    }
}
