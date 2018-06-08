using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//using System.Windows.Forms;

namespace ZEngine_Server.Library
{
    class Automatic
    {
        private Dictionary<string, Timer> Timers;

        public Automatic()
        {
            Timers = new Dictionary<string, Timer>();
        }

        public Timer Add(string name, int interval, TimerCallback action)
        {
            if(!Timers.ContainsKey(name))
            {
                /*
                Timer timer = new Timer
                {
                    Interval = interval
                };
                timer.Tick += action;
                */

                Timer timer = new Timer(action);
                timer.Change(interval, interval);

                Timers.Add(name, timer);

                return Update(name);
            }
            else
            {
                $"'Automatic': trying create already created action. Action: '{name}'".ToColor(String.Colors.DarkRed);

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
                $"'Automatic': trying delete already deleted action. Action: '{name}'".ToColor(String.Colors.DarkRed);
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
