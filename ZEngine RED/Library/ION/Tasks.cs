using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_RED.Library.ION
{
    public delegate void ParametrizedActionTask(Buffer buff);

    public enum TaskType
    {
        Disconnect = 999,
        UpdateConnectionInfo = 0,
        UpdateClientInfo = 1,
        AppendDownloadLink = 2,
        ShowBlockedInformation = 3,
    }

    class Tasks
    {
        public static class Actions
        {
            public static void Disconnect(Buffer buffobj)
            {
                IGC.ControlDispatcher.Invoke(IGC.GeneralForm, () =>
                {
                    IGC.GeneralForm.Lock();
                });

                IGC.Network.DisableModule();
                IGC.Network.ConnectAsync();
            }

            public static void UpdateConnectionInfo(Buffer buffobj)
            {
                IGC.ControlDispatcher.Invoke(IGC.GeneralForm, () =>
                {
                    IGC.GeneralForm.Unlock();
                });

                string[] data = new string[2];

                data[0] = buffobj.Read<string>();
                data[1] = buffobj.Read<string>();

                IGC.ControlDispatcher.Invoke(IGC.GeneralForm, () =>
                {
                    IGC.GeneralForm.UpdateConnectionStatus(data[0]+"мс", data[1]+"мс");
                });
            }

            public static void UpdateClientInfo(Buffer buffobj)
            {
                string[] data = new string[6];
                data[0] = buffobj.Read<bool>().ToString();
                data[1] = buffobj.Read<bool>().ToString();
                data[2] = buffobj.Read<bool>().ToString();
                data[3] = buffobj.Read<bool>().ToString();
                data[4] = buffobj.Read<string>();
                data[5] = buffobj.Read<int>().ToString();

                IGC.Client.CreateFromArray(data);
                if(IGC.Client.Days > 0)
                {
                    IGC.MessageConnectionS.SetResult(true, "Соединение установлено");
                }
                else
                {
                    IGC.MessageConnectionS.SetResult(false, "Ошибка лицензии: 0x013CDF1");

                    Environment.Exit(0);
                }
            }

            public static void ShowBlockedInfo(Buffer buffobj)
            {
                string data = buffobj.Read<string>();

                MessageBox.Show($"BANNED! \nMESSAGE:{data}");

                Environment.Exit(0);
            }
        }

        public Dictionary<int, ParametrizedActionTask> ParametrizedActionsCollection = new Dictionary<int, ParametrizedActionTask>();

        public Tasks()
        {
            ParametrizedActionsCollection.Add((int)TaskType.Disconnect, Actions.Disconnect);
            ParametrizedActionsCollection.Add((int)TaskType.UpdateConnectionInfo, Actions.UpdateConnectionInfo);
            ParametrizedActionsCollection.Add((int)TaskType.UpdateClientInfo, Actions.UpdateClientInfo);
            ParametrizedActionsCollection.Add((int)TaskType.ShowBlockedInformation, Actions.ShowBlockedInfo);
        }

        public void Invoke(int command, Buffer buff)
        {
            if (ParametrizedActionsCollection.ContainsKey(command))
            {
                ParametrizedActionsCollection[command].Invoke(buff);
            }
        }
    }
}
