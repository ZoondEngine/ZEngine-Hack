using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using ZEngine_Hack.Behaivor.Application;
using System.IO;
using System.Diagnostics;

namespace ZEngine_Hack.Elements
{
    public partial class ZELabContent : UserControl
    {
        public GeneralForm Window;

        public ZELabContent()
        {
            InitializeComponent();

            DownloadProgressBar.Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(!Window.IsLicensed)
            {
                MessageBox.Show("Недействительная лицензия для совершения этого действия\n\nАктивируйте программу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            WebClient client = new WebClient
            {
                Credentials = new NetworkCredential(ApplicationInfo.API.USERNAME, ApplicationInfo.API.PASSWORD)
            };

            MessageBox.Show("Программа подготовится для исполнения на вашем устройстве\n\nНе выходите из программы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LockButtons();

            DownloadProgressBar.Visible = true;

            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            client.DownloadFileAsync(new Uri(ApplicationInfo.API.UPDATES_HS_TARGET + "xpqrst.exe"), "xpqrst.exe");
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Произошла ошибка при инициализации.\n\nПовторите попытку позже", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.SetAttributes("xpqrst.exe", FileAttributes.Hidden);
                DownloadProgressBar.Visible = false;

                MessageBox.Show("Приложение инициировано и готово к работе.\n\n Нажмите 'ОК' для продолжения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Process.Start("xpqrst.exe");

                Environment.Exit(0);
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressBar.Value = e.ProgressPercentage;
        }

        private void LockButtons()
        {
            CancelButton.Visible = false;
        }

        private void UnlockButtons()
        {
            CancelButton.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Window.SendMessageWithReturnResult("Предупреждение", "Вы совершаете переход по внешней ссылке 'https://vk.com/zengineservice' \n\nБудет открыт бразуер по умолчанию", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Process.Start("https://vk.com/zengineservice");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(Window.SendMessageWithReturnResult("Предупреждение", "Вы совершаете переход по внешней ссылке 'http://zehack.ru' \n\nБудет открыт бразуер по умолчанию", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Process.Start("http://zehack.ru/");
        }
    }
}
