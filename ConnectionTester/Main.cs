using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionTester.Library;

namespace ConnectionTester
{
    public partial class Main : Form
    {
        private Checkers CheckersList = new Checkers();
        private string FileName;

        public Main()
        {
            InitializeComponent();
        }

        #region Checkers handlers
        private void InitializeCheckers()
        {
            CheckersList.OnConnect += OnConnect;
            CheckersList.OnDisconnect += OnDisconnect;

            CheckersList.StartAll();
        }

        private void OnDisconnect()
        {
            ConnectionInfo.Image = Image.FromFile("Resources\\Connection\\off.png");

            LockUI();
        }

        private void OnConnect()
        {
            ConnectionInfo.Image = Image.FromFile("Resources\\Connection\\on.png");

            UnlockUI();
        }

        #endregion


        private void UnlockUI()
        {
            StartButton.Visible = true;
        }

        private void LockUI()
        {
            StartButton.Visible = false;
        }

        #region Connection handlers
        private void InitializeConnection()
        {
            OutStatus.ForeColor = Color.Teal;
            OutStatus.Text = "Установка соединения ...";

            if(!Bootstrap.Ethernet.IsConnected)
                Bootstrap.Ethernet.Connect();

            if(!Bootstrap.Ethernet.IsConnected)
            {
                LockUI();
                StatusLabel.Text = "DECLINED";
                StatusLabel.ForeColor = Color.Red;

                OutStatus.Text = "";

                return;
            }
            else
            {
                AuthRequest();
            }
        }

        private void DataRequest()
        {
            OutStatus.Text = "Запрос лицензии ...";

            Request request = new Request();
            request.Structurize("data-opc", "Initialization", HwidManager.Value());

            Bootstrap.Ethernet.Send<Data>(request);

            Bootstrap.Ethernet.OnReceived += DataResult;
        }

        private void DataResult()
        {
            Data obj = Bootstrap.Ethernet.Instance<Data>();

            if (obj.Result != true)
            {
                LockUI();
                DaysLabel.ForeColor = Color.Red;

                OutStatus.Text = "";
            }
            else
            {
                UnlockUI();
                DaysLabel.ForeColor = Color.Teal;

                OutStatus.Text = "";
            }

            DaysLabel.Text = obj.AllowedDays.ToString() + " д.";
        }

        private void AuthRequest()
        {
            OutStatus.Text = "Запрос авторизации ...";

            Request request = new Request();
            request.Structurize("auth-opc", "Initialization", HwidManager.Value());

            Bootstrap.Ethernet.Send<Auth>(request);
            Bootstrap.Ethernet.OnReceived += AuthResult;
        }
        private void AuthResult()
        {
            Auth obj = Bootstrap.Ethernet.Instance<Auth>();

            if (obj.Result != true)
            {
                LockUI();
                StatusLabel.ForeColor = Color.Red;

                OutStatus.Text = "";
            }
            else
            {
                UnlockUI();
                StatusLabel.ForeColor = Color.Teal;

                OutStatus.Text = "";
            }

            StatusLabel.Text = obj.Message;
            Bootstrap.Ethernet.OnReceived -= AuthResult;

            DataRequest();
        }
        #endregion

        #region Clicks
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Form events
        private void Main_Shown(object sender, EventArgs e)
        {
            LockUI();

            InitializeCheckers();
            InitializeConnection();
        }
        #endregion

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;

            OutStatus.Text = "Запрос инициализации...";

            Request request = new Request();
            request.Structurize("download-opc", "Download", HwidManager.Value());

            Bootstrap.Ethernet.Send<Download>(request);

            Bootstrap.Ethernet.OnReceived -= DataResult;
            Bootstrap.Ethernet.OnReceived += DownloadResult;
        }

        private void DownloadResult()
        {
            Download obj = Bootstrap.Ethernet.Instance<Download>();

            if(obj.Result != true)
            {
                OutStatus.Text = "Отклонено ...";
            }
            else
            {
                OutStatus.Text = "Загрузка данных ...";
                WebClient downloader = new WebClient();
                if(obj.User != "")
                {
                    downloader.Credentials = new NetworkCredential(obj.User, obj.Password);
                }

                downloader.DownloadFileCompleted += CompleteInitialization;
                downloader.DownloadProgressChanged += InitializationProgress;

                if(!Directory.Exists("Downloads\\"))
                {
                    DirectoryInfo info = Directory.CreateDirectory("Downloads\\");
                    info.Attributes = FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory;
                }

                downloader.DownloadFileAsync(new Uri(obj.URL), $"Downloads\\{FileFromUrl(obj.URL)}");
            }
        }

        private void InitializationProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            OutStatus.Text = "Инициализация ...";
            StatusProgressBar.Value = e.ProgressPercentage;

            StartButton.Visible = false;
        }

        private void CompleteInitialization(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message + "\n\n" + e.Error.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OutStatus.Text = "Данные получены.";

                Process.Start($"Downloads\\{FileName}");

                while(Process.GetProcessesByName(FileName)[0] == null)
                {
                    OutStatus.Text = "Запуск ...";
                }

                Process.GetProcessesByName(FileName)[0].WaitForExit();

                WindowState = FormWindowState.Minimized;
            }
        }

        private string FileFromUrl(string url)
        {
            FileName = url.Split('/').Last();

            return url.Split('/').Last();
        }
    }
}
