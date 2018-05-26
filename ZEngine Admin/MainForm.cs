using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_Admin
{
    public partial class MainForm : Form
    {
        private Login LoginWindow;

        public MainForm()
        {
            InitializeComponent();

            LoginWindow = new Login(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sending report
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void HeadClosePictureButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HeadMinimizePictureButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            LoginWindow.Show();
        }
    }
}
