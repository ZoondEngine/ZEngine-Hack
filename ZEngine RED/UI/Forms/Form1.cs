using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using ZEngine_RED.Library.ION.Exceptions;

namespace ZEngine_RED.UI.Forms
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            IGC.GeneralForm = this;
            InitializeComponent();

            if(!IGC.Network.IsConnected)
            {
                IGC.Network.ConnectAsync();
                IGC.MessageConnectionS.WithAutoClosing();
                IGC.MessageConnectionS.ShowDialog();
            }
        }

        public void UpdateConnectionStatus(string ttl, string lifetime)
        {
            try
            {
                ConnStatusLabel.Text = $"Пинг: {ttl}, LT: {lifetime}";
            }
            catch(InvalidOperationException)
            {
                return;
            }
        }

        public void Lock()
        {
            StartButton.Enabled = false;
            UpdateConnectionStatus("n/a", "n/a");
        }

        public void Unlock()
        {
            StartButton.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IGC.Network.DisableModule();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
