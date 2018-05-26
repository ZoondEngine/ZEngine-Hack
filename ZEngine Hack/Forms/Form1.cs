using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZEngine_Hack.Behaivor.Application;

namespace ZEngine_Hack
{
    public partial class GeneralForm : Form
    {
        private Elements.ZELabContent ZETab = new Elements.ZELabContent();
        private GGContent GGTab = new GGContent();
        private Elements.Notifications NotifyTab = new Elements.Notifications();
        private Elements.MarikContent StatisticsTab = new Elements.MarikContent();
        private Elements.SettingsTab SettingsTab = new Elements.SettingsTab();

        private WebClient GeneralDownloader = new WebClient();
        private Timer ConnectionTimer = new Timer();
        private Timer UpdateTimer = new Timer();
        private Timer LicenseTimer = new Timer();

        private ManagementObjectSearcher Searcher = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_OperatingSystem");

        private bool NeededUpdate = false;
        private bool IsConnected;
        private bool IsCheckedNow;
        private bool IsShowedError = false;

        public bool IsLicensed;
        public bool IsCheckedLicenseNow;

        private string SelectedButton;

        public GeneralForm()
        {
            //Resolver.RegisterDependencyResolver();

            InitializeComponent();

            if (File.Exists("updater.exe"))
                File.Delete("updater.exe");

            LockUI();

            ZETab.Window = this;

            IsLicensed = true;

            ConnectionTimer.Interval = 3000;
            ConnectionTimer.Tick += new EventHandler(SetConnectionStatus);
            ConnectionTimer.Start();

            UpdateTimer.Interval = 4000;
            UpdateTimer.Tick += new EventHandler(SetUpdateStatus);
            UpdateTimer.Start();

            LicenseTimer.Interval = 10000;
            LicenseTimer.Tick += new EventHandler(SetLicenseStatus);
            LicenseTimer.Start();

            Provider.IconVisualizer.Initialize(this);
            Provider.Settinger.Load();

            NotifyIcon.Visible = false;
            NotifyIcon.ContextMenuStrip = contextMenuStrip1;
            NotifyIcon.MouseDoubleClick += NotifyIcon_DoubleClickEventhandler;
            Resize += new EventHandler(GeneralForm_ResizeEventHandler);

            GeneralDownloader.Credentials = new NetworkCredential(ApplicationInfo.API.USERNAME, ApplicationInfo.API.PASSWORD);

            // Start Up Point
            InitializeFP();

            Provider.Connection.Connect();

            //System.Threading.Thread.Sleep(1000);

            if (Provider.Connection.IsConnected)
                Provider.Connection.Send("313.0100.GLOBAL-REQUEST.123-1313-3213");
            else
                MessageBox.Show("Disconnected");
        }

        private void SetConnectionStatus(object sender, EventArgs e)
        {
            if (CheckConnection())
            {
                IsConnected = true;
                if (!IsLicensed)
                {
                    Provider.IconVisualizer.SetConnectionStatus(true);

                    return;
                }

                UnlockUI();
                Provider.IconVisualizer.SetConnectionStatus(true);
            }
            else
            {
                IsConnected = false;
                LockUI();
                Provider.IconVisualizer.SetConnectionStatus(false);
            }
        }

        private void SetUpdateStatus(object sender, EventArgs e)
        {
            CheckUpdates();
        }

        private bool CheckConnection()
        {
            if (Library.Conn.Obj.CheckInternet() == Library.Conn.Obj.ConnectionStatus.Connected)
                return true;
            else
                return false;
        }

        private void CheckUpdates()
        {
            if (!IsConnected)
                return;

            if (IsCheckedNow)
                return;

            WebClient client = new WebClient
            {
                Credentials = new NetworkCredential(ApplicationInfo.API.USERNAME, ApplicationInfo.API.PASSWORD)
            };

            IsCheckedNow = true;

            client.DownloadFileCompleted += CheckUpdate_Complete_EventHandler;

            client.DownloadFileAsync(new Uri(ApplicationInfo.API.UPDATES_LDR_TARGET + "version.txt"), "version.txt");
        }

        private void CheckUpdate_Complete_EventHandler(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                if (!IsShowedError)
                {
                    MessageBox.Show("Ошибка снхронизации обновлений\n\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    IsCheckedNow = true;
                }

                if (!Provider.IconVisualizer.IsBusy)
                    Provider.IconVisualizer.SetDownload(false);

                Provider.IconVisualizer.SetUpdateStatus(false);

                return;
            }
            else
            {
                string[] versionData = File.ReadAllLines("version.txt");
                File.Delete("version.txt");

                Version remoteVersion = Version.Parse(versionData[0].Split('=')[1]);
                int compareResult = ApplicationInfo.APPLICATION_VERSION.CompareTo(remoteVersion);

                if (compareResult < 0)
                {
                    if (Provider.Settinger.GetKey("AutoUpdateEnable", 1) == "True")
                    {
                        string type = versionData[1].Split('=')[1];

                        if(type == Provider.Settinger.GetKey("TypeUpdate", 1) || Provider.Settinger.GetKey("TypeUpdate", 1) == "ВСЕ" || type == "КРИТИЧЕСКИЕ")
                        {
                            StartUpdate();
                        }
                        else
                        {
                            Provider.IconVisualizer.SetUpdateStatus(false);

                            if (!Provider.IconVisualizer.IsBusy)
                                Provider.IconVisualizer.SetDownload(false);
                        }
                    }
                    else
                    {
                        if(!Provider.IconVisualizer.IsBusy)
                            Provider.IconVisualizer.SetDownload(false);

                        Provider.IconVisualizer.SetUpdateStatus(false);
                    }
                }
                else
                {
                    if (!Provider.IconVisualizer.IsBusy)
                        Provider.IconVisualizer.SetDownload(false);

                    Provider.IconVisualizer.SetUpdateStatus(true);
                }
            }
        }

        private void StartUpdate()
        {
            WebClient client = new WebClient
            {
                Credentials = new NetworkCredential(ApplicationInfo.API.USERNAME, ApplicationInfo.API.PASSWORD)
            };

            Provider.IconVisualizer.SetUpdateStatus(false);
            if (NeededUpdate)
                return;

            if (!Provider.IconVisualizer.IsBusy)
                Provider.IconVisualizer.SetDownload(true);

            client.DownloadProgressChanged += StartUpdate_InProgress_EventHandler;
            client.DownloadFileCompleted += StartUpdate_Complete_EventHandler;

            client.DownloadFileAsync(new Uri(ApplicationInfo.API.UPDATES_LDR_TARGET + "updater.exe"), "updater.exe");
        }

        private void StartUpdate_InProgress_EventHandler(object sender, DownloadProgressChangedEventArgs e)
        {
            Provider.IconVisualizer.SetDownloadProgress(e.BytesReceived, e.TotalBytesToReceive);
        }

        private void StartUpdate_Complete_EventHandler(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Ошибка синхронизации обновлений\n\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Provider.IconVisualizer.SetUpdateStatus(false);
            }
            else
            {
                DialogResult result = MessageBox.Show("Обновление готово к установке\n\nМы настоятельно вам рекомендуем обновить приложение.\n\nОбновить сейчас ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Process.Start("updater.exe");

                    Environment.Exit(0);
                }
                else
                {
                    NeededUpdate = true;
                    IsCheckedNow = false;

                    Provider.IconVisualizer.SetUpdateStatus(false);

                    //if (!Provider.IconVisualizer.IsBusy)
                        Provider.IconVisualizer.SetDownload(false);
                }
            }
        }

        private void LockUI()
        {
            ZEngine_TeamMenu.Enabled = false;
            ZEngine_TeamMenu.Textcolor = Color.Gray;

            //MarikHack_TeamMenu.Enabled = false;
            //MarikHack_TeamMenu.ForeColor = Color.Gray;
        }

        private void UnlockUI()
        {
            ZEngine_TeamMenu.Enabled = true;
            ZEngine_TeamMenu.Textcolor = Color.White;

            //MarikHack_TeamMenu.Enabled = true;
            //MarikHack_TeamMenu.ForeColor = Color.White;

            GetSelectedButton().selected = true;
        }

        private Bunifu.Framework.UI.BunifuFlatButton GetSelectedButton()
        {
            Bunifu.Framework.UI.BunifuFlatButton responseButton = null;

            switch (SelectedButton)
            {
                case "ZEngine_TeamMenu":
                    {
                        responseButton = ZEngine_TeamMenu;

                        break;
                    }

                case "NotifyButton_Menu":
                    {
                        responseButton = NotifyButton_Menu;

                        break;
                    }

                case "SettingsButton_Menu":
                    {
                        responseButton = SettingsButton_Menu;

                        break;
                    }

                default:
                    {
                        responseButton = ZEngine_TeamMenu;

                        break;
                    }
            }

            return responseButton;
        }

        private void GeneralForm_ResizeEventHandler(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                NotifyIcon.Visible = true;
                NotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                NotifyIcon.BalloonTipTitle = "Информация";
                NotifyIcon.BalloonTipText = "Приложение было свернуто и продолжает свою работу в фоновом режиме.";
                NotifyIcon.ShowBalloonTip(5000);
            }
        }

        private void NotifyIcon_DoubleClickEventhandler(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            NotifyIcon.Visible = false;
            // возвращаем отображение окна в панели
            ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        private string GetHwid()
        {
            string str = null;
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = this.Searcher.Get().GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    str = ((ManagementObject)enumerator.Current)["SerialNumber"].ToString();
                }
            }
            return str;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (NeededUpdate)
                Process.Start("updater.exe");

            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("xpqrst.exe"))
                File.Delete("xpqrst.exe");

            VersionLabel_Header.Text = "ver: " + ApplicationInfo.APPLICATION_VERSION.ToString();

            CheckLicense();
        }

        private void SetLicenseStatus()
        {
            if(CheckLicense())
            {
                UnlockUI();
                IsLicensed = true;

                IsCheckedLicenseNow = false;
            }
            else
            {
                LockUI();
                IsLicensed = false;

                IsCheckedLicenseNow = false;
            }
        }

        private void SetLicenseStatus(object sender, EventArgs e)
        {

            if (CheckLicense())
            {
                UnlockUI();
                IsLicensed = true;

                IsCheckedLicenseNow = false;
            }
            else
            {
                LockUI();
                IsLicensed = false;

                IsCheckedLicenseNow = false;
            }
        }

        private bool CheckLicense()
        {
            LockUI();

            WebClient client = new WebClient
            {
                Credentials = new NetworkCredential(ApplicationInfo.API.USERNAME, ApplicationInfo.API.PASSWORD)
            };

            try
            {
                client.DownloadFile(new Uri(ApplicationInfo.API.USER_TARGET + GetHwid() + "/license.txt"), "Application\\lic.dest");
                string[] LicenseData = File.ReadAllLines("Application\\lic.dest");
                File.Delete("Application\\lic.dest");

                DateTime ExpireDate = DateTime.Parse(LicenseData[1].Split('=')[1]);
                DateTime RegisterDate = DateTime.Parse(LicenseData[2].Split('=')[1]);

                if(DateTime.Compare(ExpireDate, DateTime.Now.Date) == -1)
                {
                    if (!IsLicensed)
                        return false;
                        
                    MessageBox.Show($"{DateTime.Compare(ExpireDate, DateTime.Now.Date)} :: {ExpireDate}");

                    LockUI();
                    Clipboard.SetText(GetHwid());
                    MessageBox.Show("Срок действия подписки истек.\n\nКлюч вставлен в буфер обмена\n\nОсновные функции ограничены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Provider.IconVisualizer.SetKeyStatus(false);

                    return false;
                }
                else
                {
                    if(DateTime.Compare(RegisterDate, DateTime.Now.Date) == 1)
                    {
                        if (!IsLicensed)
                            return false;

                        LockUI();

                        MessageBox.Show($"{DateTime.Compare(RegisterDate, DateTime.Now.Date)} :: {RegisterDate}");

                        MessageBox.Show("Обнаружено нарушение лицензии\n\nОсновные функции ограничены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Provider.IconVisualizer.SetKeyStatus(false);

                        return false;
                    }
                    else
                    {
                        UnlockUI();

                        Provider.IconVisualizer.SetKeyStatus(true, GetHwid(), $"{(ExpireDate - DateTime.Now.Date).Days} д.");

                        return true;
                    }
                }
            }
            catch(WebException)
            {
                if (!IsLicensed)
                    return false;

                if (!IsCheckedLicenseNow)
                {
                    IsCheckedLicenseNow = true;
                    Clipboard.SetText(GetHwid());
                    MessageBox.Show("Вы используете не зарегистрированную версию программы.\n\nКлюч вставлен в буфер обмена\n\nОсновные функции ограничены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LockUI();

                Provider.IconVisualizer.SetKeyStatus(false);

                return false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LockUI();

            SelectedButton = NotifyButton_Menu.Name;

            NotifyTab.Parent = ContentPanel;
            NotifyTab.Show();

            SetLicenseStatus();
        }

        private void InitializeFP()
        {
            if (!Directory.Exists("Application"))
            {
                DirectoryInfo AppDirInfo = Directory.CreateDirectory("Application");
                AppDirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System;
            }

            if (!Directory.Exists("Downloads"))
            {
                DirectoryInfo DownloadsDirInfo = Directory.CreateDirectory("Downloads");
                DownloadsDirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System;
            }

            if (!Directory.Exists("Downloads\\All"))
            {
                DirectoryInfo TrashDirInfo = Directory.CreateDirectory("Downloads\\All");
                TrashDirInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System;
            }

            if(!File.Exists("Application\\App.ini"))
            {
                File.Create("Application\\App.ini");
                File.SetAttributes("Application\\App.ini", FileAttributes.Hidden);
            }
        }

        private void NewButton_Menu_Click(object sender, EventArgs e)
        {
            SetTab(ZEngine_TeamMenu);
        }

        private void SetTab(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            InvisingAllTabs();

            sender.selected = true;

            SelectedButton = sender.Name;

            if(sender.Name == "ZEngine_TeamMenu")
            {
                ZETab.Parent = ContentPanel;
                try
                {
                    ZETab.Show();
                }
                catch(Exception)
                {

                }
            }
            else if(sender.Name == "GGC_TeamMenu")
            {
                GGTab.Parent = ContentPanel;
                GGTab.Show();
            }
            else if(sender.Name == "StatMenu_Button")
            {
                StatisticsTab.Parent = ContentPanel;
                StatisticsTab.Show();
            }
            else if(sender.Name == "SettingsButton_Menu")
            {
                SettingsTab.Parent = ContentPanel;
                SettingsTab.Show();
            }
            else if (sender.Name == "NotifyButton_Menu")
            {
                NotifyTab.Parent = ContentPanel;
                NotifyTab.Show();
            }
            else
            {
                MessageBox.Show("KeyUP Not detect !");
            }
        }

        private void InvisingAllTabs()
        {
            ZETab.Hide();
            GGTab.Hide();
            NotifyTab.Hide();
            SettingsTab.Hide();
        }

        internal DialogResult SendMessageWithReturnResult(string caption, string message, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = MessageBox.Show(message, caption, button, icon);

            return result;
        }

        private void SettingsButton_Menu_Click(object sender, EventArgs e)
        {
            SetTab(SettingsButton_Menu);
        }

        private void StatMenu_Button_Click(object sender, EventArgs e)
        {
            SetTab(MarikHack_TeamMenu);
        }

        #region Tray Menu
        private void NotifyMenu_Maximized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void NotifyMenu_CheckUpdates_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/rgFB3GP");
        }

        private void NotifyMenu_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Приложение будет закрыто и все несохраненные данные будут утеряны.\n\nПродолжить ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
                Environment.Exit(0);
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ключ успешно скопирован в буфер обмена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(GetHwid());
        }

        private void NotifyButton_Menu_Click(object sender, EventArgs e)
        {
            SetTab(NotifyButton_Menu);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(SendMessageWithReturnResult("Предупреждение", "Вы совершаете переход по внешней ссылке 'https://discord.gg/rgFB3GP' \n\nБудет открыт бразуер по умолчанию", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Process.Start("https://discord.gg/rgFB3GP");
        }
    }
}
