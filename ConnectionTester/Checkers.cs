using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTester
{
    public class Checkers
    {
        public delegate void ConnectionDelegate();

        public event ConnectionDelegate OnConnect;
        public event ConnectionDelegate OnDisconnect;

        public Checkers()
        {
            Bootstrap.Automatic.Add("Connection", 2000, (sender, args) =>
            {
                if(!Bootstrap.Ethernet.IsConnected)
                    Bootstrap.Ethernet.Connect();

                if (Bootstrap.Ethernet.IsConnected)
                {
                    OnConnect?.Invoke();
                }
                else
                {
                    OnDisconnect?.Invoke();
                }
            });
        }

        public void StartAll()
        {
            foreach (var timer in Bootstrap.Automatic.GetTimerList().Values)
            {
                timer.Start();
            }
        }

        public void StopAll()
        {
            foreach (var timer in Bootstrap.Automatic.GetTimerList().Values)
            {
                timer.Stop();
            }
        }

        public void StartConnection()
        {
            Bootstrap.Automatic.Update("Connection").Start();
        }

        public void StopConnection()
        {
            Bootstrap.Automatic.Update("Connection").Stop();
        }
    }
}
