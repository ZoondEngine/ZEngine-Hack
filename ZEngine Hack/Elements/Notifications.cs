using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using ZEngine_Hack.Behaivor.Application;

namespace ZEngine_Hack.Elements
{
    public partial class Notifications : UserControl
    {
        private WebClient Web = new WebClient();
        public Notifications()
        {
            InitializeComponent();
        }

        private void ShowButton()
        {
            PlayButton.Visible = true;
            SpaceDescLabel.Visible = true;
        }

        private void HideButton()
        {
            PlayButton.Visible = false;
            SpaceDescLabel.Visible = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            StartMovie();
        }

        private void StartMovie()
        {
            DownloadProgress.Visible = true;

            if (!File.Exists("195.wmv"))
            {
                Provider.IconVisualizer.SetDownload(true);

                Web.Credentials = new NetworkCredential(ApplicationInfo.API.USERNAME, ApplicationInfo.API.PASSWORD);

                Web.DownloadProgressChanged += Web_DownloadProgressChanged;
                Web.DownloadFileCompleted += Web_DownloadFileCompleted;

                Web.DownloadFileAsync(new Uri(ApplicationInfo.API.ADOWNLOADS_TARGET + "195.wmv"), "195.wmv");
            }
            else
            {
                PlayButton.Visible = false;
                SpaceDescLabel.Visible = false;
                axWindowsMediaPlayer1.URL = "195.wmv";
                DownloadProgress.Value = 0;
                DownloadProgress.Visible = false;
            }
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show("Ошибка получения видеофайла\n\nПовторите попытку позже", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Provider.IconVisualizer.SetDownload(false);

                return;
            }

            File.SetAttributes("195.wmv", FileAttributes.System);
            Provider.IconVisualizer.SetDownload(false);

            StartMovie();
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Provider.IconVisualizer.SetDownloadProgress(e.BytesReceived, e.TotalBytesToReceive);
            DownloadProgress.Value = e.ProgressPercentage;
        }

        private void axWindowsMediaPlayer1_KeyUpEvent(object sender, AxWMPLib._WMPOCXEvents_KeyUpEvent e)
        {
            if(e.nKeyCode == 0x20)
            {
                axWindowsMediaPlayer1.URL = "";
                //axWindowsMediaPlayer1.Dispose();
                //axWindowsMediaPlayer1.settings.autoStart = false;

                PlayButton.Visible = true;
                SpaceDescLabel.Visible = true;
            }
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.settings.volume = 15;

            DownloadProgress.Visible = false;

            ShowButton();
        }
    }
}
