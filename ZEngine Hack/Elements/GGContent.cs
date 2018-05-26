using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using ZEngine_Hack.Behaivor.Application;
using System.Diagnostics;

namespace ZEngine_Hack
{
    public partial class GGContent : UserControl
    {
        public GGContent()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Переходя по внешней ссылке, обязательно укажите при покупке откуда вы пришли\n\nПриятной игры", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start("https://discord.gg/3RV6b8f");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Переходя по внешней ссылке, обязательно укажите при покупке откуда вы пришли\n\nПриятной игры", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start("https://vk.com/club163293039");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Переходя по внешней ссылке, обязательно укажите при покупке откуда вы пришли\n\nПриятной игры", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start("https://yadi.sk/d/HTww0Aan3Td3MA");
        }
    }
}
