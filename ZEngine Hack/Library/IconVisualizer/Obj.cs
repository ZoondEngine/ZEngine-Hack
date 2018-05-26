using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_Hack.Library.IconVisualizer
{
    class Obj
    {
        private GeneralForm WindowObject;
        private ToolTip ConnectionToolTip = new ToolTip();
        private ToolTip DownloadToolTip = new ToolTip();
        private ToolTip UpdateToolTip = new ToolTip();
        private ToolTip KeyToolTip = new ToolTip();
        private ToolTip DiscordToolTip = new ToolTip();
        private Stopwatch StopWatch = new Stopwatch();

        public bool IsBusy = false;

        public Obj Initialize(GeneralForm form)
        {
            WindowObject = form;

            DiscordToolTip.SetToolTip(WindowObject.DiscordIcon, "Перейти в Discord");

            return this;
        }

        public void SetAll(bool isDownload, bool isConnected, bool isUpdated)
        {
            SetDownload(isDownload);
            SetConnectionStatus(isConnected);
            SetUpdateStatus(isUpdated);
        }

        public void HideAll()
        {
            WindowObject.ConnIcon.Visible = false;
            WindowObject.DownloadIcon.Visible = false;
            WindowObject.UpdateStatusIcon.Visible = false;
        }

        public void ShowAll()
        {
            WindowObject.ConnIcon.Visible = true;
            WindowObject.DownloadIcon.Visible = true;
            WindowObject.UpdateStatusIcon.Visible = true;
        }

        public void SetDownload(bool isDownload)
        {
            DownloadToolTip.RemoveAll();

            if (isDownload)
            {
                DownloadToolTip.SetToolTip(WindowObject.DownloadIcon, "Загрузка: получение данных");
                WindowObject.DownloadIcon.Image = System.Drawing.Image.FromFile("Resources/download_process.png");
            }
            else
            {
                DownloadToolTip.SetToolTip(WindowObject.DownloadIcon, "Загрузка: получение данных завершено");
                WindowObject.DownloadIcon.Image = System.Drawing.Image.FromFile("Resources/download_scs.png");
                WindowObject.DownloadSpeed.Text = "";
                IsBusy = false;
            }
        }

        public void SetDownloadProgress(long rec, long total)
        {
            DownloadToolTip.RemoveAll();
            IsBusy = true;
            DownloadToolTip.SetToolTip(WindowObject.DownloadIcon, $"Загрузка: получение данных - {FormatByte(rec)} из {FormatByte(total)}");
            WindowObject.DownloadSpeed.Text = GetSpeed(rec);
        }

        private string GetSpeed(long rBytes)
        {
            StopWatch.Start();

            double summ = rBytes / 1024d;
            if (summ > 1024)
            {
                summ = summ / 1024d;
                return string.Format("{0} МБ/сек", (summ / StopWatch.Elapsed.TotalSeconds).ToString("0.00"));
            }
            else
            {
                return string.Format("{0} КБ/сек", (summ / StopWatch.Elapsed.TotalSeconds).ToString("0.00"));
            }
        }

        private string FormatByte(long bytes)
        {
            string[] Suffix = { "Байт", "КБ", "МБ", "ГБ", "ТБ" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public void SetConnectionStatus(bool isConnected)
        {
            ConnectionToolTip.RemoveAll();

            if (isConnected)
            {
                ConnectionToolTip.SetToolTip(WindowObject.ConnIcon, "Подключение к интернету: подключено");
                WindowObject.ConnIcon.Image = System.Drawing.Image.FromFile("Resources/ethernet_on.png");
            }
            else
            {
                ConnectionToolTip.SetToolTip(WindowObject.ConnIcon, "Подключение к интернету: отключено");
                WindowObject.ConnIcon.Image = System.Drawing.Image.FromFile("Resources/ethernet_off.png");
            }
        }

        public void SetKeyStatus(bool isActivate, string key = "", string days = "")
        {
            KeyToolTip.RemoveAll();

            if(isActivate)
            {
                KeyToolTip.SetToolTip(WindowObject.KeyIcon, $"Активация: активировано. Осталось: {days}");
            }
            else
            {
                KeyToolTip.SetToolTip(WindowObject.KeyIcon, $"Активация: требуется активировать приложение");
            }
        }

        public void SetUpdateStatus(bool isUpdated)
        {
            UpdateToolTip.RemoveAll();

            if (isUpdated)
            {
                UpdateToolTip.SetToolTip(WindowObject.UpdateStatusIcon, "Обновление: вы используете последнюю версию");
                WindowObject.UpdateStatusIcon.Image = System.Drawing.Image.FromFile("Resources/update_correct.png");
            }
            else
            {
                UpdateToolTip.SetToolTip(WindowObject.UpdateStatusIcon, "Обновление: требуется обновление");
                WindowObject.UpdateStatusIcon.Image = System.Drawing.Image.FromFile("Resources/update_old.png");
            }
        }
    }
}
