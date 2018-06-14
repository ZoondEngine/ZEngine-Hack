using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_RED
{
    public enum InitializeState
    {
        Processed = 0,
        Stopped = 1
    }

    public partial class InitializeWindow : Form
    {
        public InitializeWindow()
        {
            InitializeComponent();

            IGC.ControlDispatcher.InitializeObjects(new Form[] { this });
            IGC.Network.ConnectAsync();
        }

        private void InitializeWindow_Shown(object sender, EventArgs e)
        {
            IGC.Network.SendAsync(Library.ION.PacketType.SendAuthRequest);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void InitilizeState(InitializeState state, string text, int progress = 0)
        {
            if(state == InitializeState.Processed)
            {
                InitializeProgressBar.Visible = true;
            }
            else
            {
                InitializeProgressBar.Visible = false;
            }

            InitializeProgressBar.Value = progress;
            InitializeText.Text = text;
        }
    }
}
