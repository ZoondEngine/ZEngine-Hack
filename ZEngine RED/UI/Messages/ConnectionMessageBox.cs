using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace ZEngine_RED.UI.Messages
{
    public partial class ConnectionMessageBox : MetroForm
    {
        private bool IsProcess = false;
        public bool IsShowed = false;

        public ConnectionMessageBox()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            IsProcess = true;
            StatusLabel.Text = text;
            Spinner.Visible = true;
        }

        public void SetResult(bool result, string text)
        {
            if(result)
            {
                Spinner.Style = MetroFramework.MetroColorStyle.Green;
                Style = MetroFramework.MetroColorStyle.Green;

                IsProcess = false;
            }
            else
            {
                Spinner.Style = MetroFramework.MetroColorStyle.Red;
                Style = MetroFramework.MetroColorStyle.Red;

                IsProcess = true;
            }

            StatusLabel.Text = text;
            Spinner.Visible = false;
        }

        public void WithAutoClosing()
        {
            new Thread(() =>
            {
                while(IsProcess)
                {

                }

                Thread.Sleep(2000);

                if(!IsShowed)
                {
                    return;
                }

                IGC.ControlDispatcher.Invoke(this, () =>
                {
                    Hide();
                });

            }).Start();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectionMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsShowed = false;

            if (IsProcess)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ConnectionMessageBox_Shown(object sender, EventArgs e)
        {
            IsShowed = true;
        }
    }
}
