using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_Account_Manager
{
    public partial class Form1 : Form
    {
        private string[] KData = new string[256];
        private string Key;
        private Timer HideTimer = new Timer();

        public Form1()
        {
            if (File.Exists("syhhg.kmmj"))
                File.Delete("syhhg.kmmj");

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SendSuccessNotify(string errorMsg)
        {
            NotifyPanel.BackColor = Color.LightGreen;
            NotifyPanel.ForeColor = Color.ForestGreen;
            NotifyMsg.Text = errorMsg;

            WaitHide(3000);
        }

        private void SendWaitNotify(string msg)
        {
            NotifyPanel.BackColor = Color.LightYellow;
            NotifyPanel.ForeColor = Color.YellowGreen;
            NotifyMsg.Text = msg;

            WaitHide(3000);
        }

        private void SendErrorNotify(string errorMsg)
        {
            NotifyPanel.BackColor = Color.IndianRed;
            NotifyPanel.ForeColor = Color.DarkRed;
            NotifyMsg.Text = errorMsg;

            WaitHide(3000);
        }

        private void HideNotify(object sender, EventArgs e)
        {
            NotifyPanel.BackColor = Color.DimGray;
            NotifyMsg.Text = "";

            HideTimer.Dispose();
        }

        private void WaitHide(int time)
        {
            HideTimer.Dispose();

            HideTimer.Interval = time;
            HideTimer.Tick += new EventHandler(HideNotify);
            HideTimer.Start();
        }

        private void LockUI()
        {
            ActivateBTN.Enabled = false;
            DaysCountTB.Enabled = false;
            HwidTB.Enabled = false;
            ResellerNickNameTB.Enabled = false;
        }

        private void UnlockUI()
        {
            ActivateBTN.Enabled = true;
            DaysCountTB.Enabled = true;
            HwidTB.Enabled = true;
            ResellerNickNameTB.Enabled = true;
        }

        private void CheckID()
        {
            WebClient checker = new WebClient();
        }

        private void ActivateBTN_Click(object sender, EventArgs e)
        {
            WebClient downloader = new WebClient();
            downloader.Credentials = new NetworkCredential("zehack_adm_new", "Cfvjcbqbkmz1112589635");

            if (ResellerNickNameTB.Text == String.Empty)
            {
                SendErrorNotify("[!] * 'Reseller Acc' field must have a value :: [FChk->RsErr]");

                return;
            }

            if (ResellerIDTB.Text == String.Empty)
            {
                SendErrorNotify("[!] * 'ID' field must have a value :: [FChk->IDErr]");

                return;
            }

            if (DaysCountTB.Text == String.Empty)
            {
                SendErrorNotify("[!] * 'Days' field must have a value :: [FChk->DyErr]");

                return;
            }

            if(HwidTB.Text == String.Empty)
            {
                SendErrorNotify("[!] * 'Hwid' field must have a value :: [FChk->HwdErr]");

                return;
            }

            downloader.DownloadFile(new Uri("http://api.zehack.ru/ResellersData/ddtr.txt"), "ddtr");
            string[] dtrData = File.ReadAllLines("ddtr");
            File.Delete("ddtr");

            int dtrIterator = 0;
            foreach(string dtr in dtrData)
            {
                if(dtr == ResellerIDTB.Text)
                {
                    dtrIterator++;
                }
            }

            if(dtrIterator <= 0)
            {
                SendErrorNotify("[!] * This ID not executable :: [Sec->Err]");

                return;
            }

            try
            {
                KData = null;
                downloader.DownloadFile(new Uri($"http://api.zehack.ru/ResellersData/{ResellerNickNameTB.Text}/dtr/syhhg.kmmj.txt"), "syhhg.kmmj");
                KData = File.ReadAllLines("syhhg.kmmj");
                File.Delete("syhhg.kmmj");

                int i = 0;

                foreach(string key in KData)
                {
                    if(key.Contains(DaysCountTB.Text))
                    {
                        if(!key.Contains("=>"))
                        {
                            if(key.Contains($"{DaysCountTB.Text}*"))
                            {
                                i++;
                            }
                        }
                    }
                }

                LockUI();

                if(i > 0)
                {
                    Random rand = new Random();
                    int randKey = rand.Next(0, KData.Count() - 1);

                    while(KData[randKey].Contains("=>") == true || KData[randKey].Contains("=>") == false)
                    {
                        randKey = rand.Next(0, KData.Count());
                        if(KData[randKey].Contains("=>") == false)
                        {
                            if(KData[randKey].Contains($"{DaysCountTB.Text}*"))
                            {
                                RegisterKey(randKey);
                                SendKeys();

                                break;
                            }
                        }
                    }
                }
                else
                {
                    UnlockUI();
                    if(DaysCountTB.Text == "1")
                    {
                        SendErrorNotify($"[!] * Key '1' day not exists :: [Key->ErrExs]");
                    }
                    else
                    {
                        SendErrorNotify($"[!] * Key '{DaysCountTB.Text}' days not exists :: [Key->ErrExs]");
                    }
                }
            }
            catch(Exception)
            {
                SendErrorNotify($"[!] * Reseller '{ResellerNickNameTB.Text}' not found :: [Chk->Err]");

                //MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void RegisterKey(int index)
        {
            Key = KData[index];

            KData[index] += $"=>{ResellerNickNameTB.Text} :: {HwidTB.Text} :: {DateTime.Now.ToString()}";

            /* DEBUG
            string AllDebugKeys = String.Empty;

            foreach(string key in KData)
            {
                AllDebugKeys += key + "\n";
            }

            MessageBox.Show(AllDebugKeys);
            */
        }

        private void SendKeys()
        {
            ActivateLoader();

            File.WriteAllLines("syhhg.kmmj", KData);
            WebClient uploader = new WebClient
            {
                Credentials = new NetworkCredential("zehack_adm_new", "Cfvjcbqbkmz1112589635")
        };

            try
            {
                byte[] response = uploader.UploadFile(new Uri($"http://api.zehack.ru/ResellersData/{ResellerNickNameTB.Text}/dwn.php"), "POST", "syhhg.kmmj");

                SendSuccessNotify("[%] * Account activated :: [Join->Scs]");

                UnlockUI();

                Clipboard.SetText(Key);

                if (File.Exists("syhhg.kmmj"))
                    File.Delete("syhhg.kmmj");
            }
            catch(Exception e)
            {
                SendErrorNotify("[!] * Data is missing :: [Register->Err]");

                DialogResult result = MessageBox.Show($"{e.Message}\n\nError connection to server\n\nTry ?", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    SendKeys();
                }
                else
                {
                    if (File.Exists("syhhg.kmmj"))
                        File.Delete("syhhg.kmmj");

                    Environment.Exit(0);
                }
            }
        }

        private void ActivateLoader()
        {
            string[] licData = new string[3];
            licData[0] = "Key=null";
            licData[1] = $"ExpireDate={DateTime.Now.AddDays(Int32.Parse(DaysCountTB.Text)).ToShortDateString()}";
            licData[2] = $"RegisterData={DateTime.Now.ToShortDateString()}";

            File.WriteAllLines(HwidTB.Text, licData);

            WebClient checker = new WebClient()
            {
                Credentials = new NetworkCredential("zehack_adm_new", "Cfvjcbqbkmz1112589635")
        };

            try
            {
                checker.UploadFile(new Uri($"http://api.zehack.ru/ZELab/Activates/{HwidTB.Text}/dwn.php"), HwidTB.Text);
            }
            catch(WebException)
            {
                try
                {
                    checker.UploadFile(new Uri("http://api.zehack.ru/ZELab/Activates/cr.php"), HwidTB.Text);
                }
                catch(WebException)
                {
                    SendErrorNotify("[!] * Activate loader is impossible :: [St->LdrErr]");

                    return;
                }
            }

            File.Delete(HwidTB.Text);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LockUI();

            SendWaitNotify("[&] * Checking your connection :: [Conn->Loop]");

            WebClient downloader = new WebClient();
            downloader.Credentials = new NetworkCredential("zehack_adm_new", "Cfvjcbqbkmz1112589635");
            downloader.DownloadFileCompleted += Downloader_DownloadFileCompleted;


            try
            {
                downloader.DownloadFileAsync(new Uri("http://api.zehack.ru/ZELab/Updates/HS/version.txt"), "syhhg.kmmj");
            }
            catch(WebException)
            {
                SendErrorNotify("[!] * Estabilished connection :: [Conn->Err]");
            }
        }

        private void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (File.Exists("syhhg.kmmj"))
                File.Delete("syhhg.kmmj");

            if (e.Error != null)
            {
                SendErrorNotify("[!] * Estabilished connection :: [Conn->Err]");

                return;
            }

            UnlockUI();
            SendSuccessNotify("[%] * Connection initialized :: [Conn->Scs]");
        }
    }
}
