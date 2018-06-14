using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZEngine_RED.Library.IOD.Exceptions;

namespace ZEngine_RED.Library.IOD
{
    class Dispatcher
    {
        public delegate void AsyncAction();
        public delegate void DispatcherInvoker(Form form, AsyncAction a);

        private Form m_InitializeWindow;

        public void InitializeObjects(Form[] windows)
        {
            m_InitializeWindow = (InitializeWindow)windows[0];
        }

        public void Invoke(Form form, AsyncAction action)
        {
            if (!form.InvokeRequired)
            {
                action();
            }
            else
            {
                form.Invoke((DispatcherInvoker)Invoke, form, action);
            }
        }

        public T CrossWindow<T>()
        {
            if(typeof(T) == typeof(InitializeWindow))
            {
                if(m_InitializeWindow == null)
                {
                    throw new CrossAccessException("Object 'InitializeWindow' has been a null.");
                }
                else
                {
                    return (T)(object)m_InitializeWindow;
                }
            }
            else
            {
                throw new CrossAccessException($"Incorrect type '{typeof(T)}' for cross acces to object.");
            }
        }
    }
}
