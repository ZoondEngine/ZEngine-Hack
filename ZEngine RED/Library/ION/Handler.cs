using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using ZEngine_RED.Library.ION.Exceptions;

namespace ZEngine_RED.Library.ION
{
    class Handler
    {
        private Socket m_Socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint m_EndPoint = new IPEndPoint(IPAddress.Parse("77.82.86.211"), 8789);
        //private IPEndPoint m_EndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8789);
        private Packets m_PacketsObj = new Packets();
        private Tasks m_TasksObj = new Tasks();
        private Thread m_PingingThread;

        private byte[] m_InBuffer = new byte[255];
        private byte[] m_OutBuffer = new byte[255];
        private bool IsLockedPing = false;

        public bool IsConnected = false;

        public async void ConnectAsync()
        {
            if(m_Socket == null)
            {
                m_Socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            }

            IGC.ControlDispatcher.Invoke(IGC.MessageConnectionS, () =>
            {
                IGC.MessageConnectionS.SetText("Установка соединения ...");
            });

            bool result = await ConnectAsyncTask();
            if(result)
            {
                IGC.ControlDispatcher.Invoke(IGC.MessageConnectionS, () =>
                {
                    IGC.MessageConnectionS.SetText("Получение данных ...");
                });

                IGC.Network.SendAsync(PacketType.SendAuthRequest);

                m_PingingThread = new Thread(AssertPinging);
                m_PingingThread.Start();
            }
            else
            {
                IGC.ControlDispatcher.Invoke(IGC.MessageConnectionS, () =>
                {
                    IGC.MessageConnectionS.SetResult(false, "Не удалось установить соединение");
                });
            }

            IsConnected = result;
        }

        private Task<bool> ConnectAsyncTask()
        {
            bool result = false;

            return Task.Run(() =>
            {
                try
                {
                    m_Socket.Connect(m_EndPoint);

                    result = m_Socket.Connected;
                }
                catch(Exception ex)
                {
                    result = false;

                    MessageBox.Show(ex.Message);

                    IGC.ControlDispatcher.Invoke(IGC.MessageConnectionS, () =>
                    {
                        IGC.MessageConnectionS.SetResult(false, ex.Message);
                    });
                }

                return result;
            });
        }

        public async void SendAsync(PacketType packet)
        {
            bool result = await SendAsyncTask((int)packet);
            if(result)
            {
                ReceiveAsync();
            }
            else
            {
                throw new NetworkException("Incorrect sending result");
            }
        }

        private Task<bool> SendAsyncTask(int packet)
        {
            return Task.Run(() =>
            {
                if(m_PacketsObj.Invoke(packet, m_Socket))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        private async void ReceiveAsync()
        {
            int size = await ReceiveAsyncTask();
            if(size != 0)
            {
                IsLockedPing = true;
                Buffer buffobj = new Buffer(m_InBuffer);
                int commandId = buffobj.Read<int>();

                m_TasksObj.Invoke(commandId, buffobj);

                IsLockedPing = false;
            }
            else
            {
                ReceiveAsync();
            }
        }

        private Task<int> ReceiveAsyncTask()
        {
            return Task.Run(() => {
                int size = 0;

                try
                {
                    size = m_Socket.Receive(m_InBuffer);
                    IsLockedPing = true;
                }
                catch(Exception)
                {
                    Thread.Sleep(2000);
                    SendAsync(PacketType.SendPing);

                    size = 0;
                }

                return size;
            });
        }

        private void AssertPinging()
        {
            while(!IsLockedPing)
            {
                Thread.Sleep(1500);
                SendAsync(PacketType.SendPing);
            }
        }

        public void DisableModule()
        {
            try
            {
                m_PingingThread.Abort();
                m_PingingThread = null;
            }
            catch(Exception) { }
            finally
            {
                m_Socket.Dispose();
            }
        }

        /*
        private void SetInitializeText(bool isProcessed, string text, int prc = 0)
        {
            var window = IGC.ControlDispatcher.CrossWindow<InitializeWindow>();
            if (isProcessed)
            {
                IGC.ControlDispatcher.Invoke(window, () =>
                {
                    window.InitilizeState(InitializeState.Processed, text, prc);
                });
            }
            else
            {
                IGC.ControlDispatcher.Invoke(window, () =>
                {
                    window.InitilizeState(InitializeState.Stopped, text, prc);
                });
            }
        }
        */
    }
}
