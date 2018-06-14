using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_RED.UI.Messages
{
    public partial class License : Form
    {
        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Show(string descLbl, string descBox)
        {
            DescriptionLabel.Text = "Тип: " + descLbl;
            DescriptionBox.AppendText(descBox);

            ShowDialog();
        }

        public License()
        {
            InitializeComponent();
        }
    }
}
