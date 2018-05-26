using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace ZEngine_Hack.Elements.InSettingsElements
{
    public partial class General : UserControl
    {
        public static General Instance;

        private Timer Timer = new Timer();
        private PerformanceCounter PerfCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private int SystemProcessIterator = 0;
        private Dictionary<string, string> SettingsDictionary = new Dictionary<string, string>();

        public General()
        {
            Instance = this;
            InitializeComponent();
        }

        private void General_Load(object sender, EventArgs e)
        {
            LoadConfig();
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(UpdateStatistics);
            Timer.Start();
        }

        private void UpdateStatistics(object sender, EventArgs args)
        {
            UpdateHDD();
            UpdatePM();
            UpdateCPU();

            Timer.Start();
        }

        private void UpdateHDD()
        {
            DriveInfo Drive = new DriveInfo("C:");
            long FreeSpace = Drive.TotalFreeSpace / 1024 / 1024 / 1024;
            long BusySpace = (Drive.TotalSize - FreeSpace) / 1024 / 1024 / 1024;
            long TotalSpace = Drive.TotalSize / 1024 / 1024 / 1024;

            FreeDiskSpace.Text = FreeSpace + " GB";
            BusyDiskSpace.Text = TotalSpace + " GB";
            DiskSpaceProgress.MaxValue = (int)TotalSpace;
            DiskSpaceProgress.Value = (int)(BusySpace - FreeSpace);
        }

        private void UpdatePM()
        {
            ComputerInfo CI = new ComputerInfo();
            ulong AllMemory  = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            ulong FreeMemory = ulong.Parse(CI.AvailablePhysicalMemory.ToString());
            ulong VirtualMemory = ulong.Parse(CI.TotalVirtualMemory.ToString());
            ulong BusyMemory = AllMemory - FreeMemory;

            ulong AllMemoryInGB = (AllMemory / (1024 * 1024 * 1024));
            ulong FreeMemoryInGB = (FreeMemory / (1024 * 1024 * 1024));

            AllMemoryCount_Label.Text = AllMemoryInGB + " GB";
            FreeMemoryCount_Label.Text = FreeMemoryInGB + " GB";
            VirtualMemoryCount_Label.Text = (VirtualMemory / (1024 * 1024 * 1024) + " GB").ToString();
            MemoryBusyProgress.Value = (int)((BusyMemory * 100) / AllMemory);
        }

        private void UpdateCPU()
        {
            SystemProcessIterator = 0;

            Process InstanceProcess = Process.GetCurrentProcess();
            Process[] AllProcesses = Process.GetProcesses();
            foreach(Process prc in AllProcesses)
            {
                if(prc.ProcessName == "svchost" || prc.ProcessName == "System" || prc.ProcessName == "lsass" || prc.ProcessName == "csrss")
                {
                    SystemProcessIterator++;
                }
            }

            CPUProgress.Value = (int)PerfCounter.NextValue();
            ProcessesCount_Label.Text = AllProcesses.Count().ToString();
            SystemProcessesCount_Label.Text = SystemProcessIterator.ToString();
            ZEUsageProcess_Label.Text = GetUsagePercent(InstanceProcess).ToString() + "%";
        }

        private int GetUsagePercent(Process prc)
        {
            double Total = 0;

            Total = prc.TotalProcessorTime.TotalMilliseconds;

            return (int)Total / 1000;
        }

        private void LoadConfig()
        {
            SettingsDictionary.Clear();

            SettingsDictionary.Add("HideTime", Provider.IniHandler.GetPrivateString("Settings", "HideTime"));
            SettingsDictionary.Add("ThreadsCount", Provider.IniHandler.GetPrivateString("Settings", "ThreadsCount"));
            SettingsDictionary.Add("RestartTimeOut", Provider.IniHandler.GetPrivateString("Settings", "RestartTimeOut"));
            SettingsDictionary.Add("ConnectionTimeOut", Provider.IniHandler.GetPrivateString("Settings", "ConnectionTimeOut"));
            SettingsDictionary.Add("BoostCount", Provider.IniHandler.GetPrivateString("Settings", "BoostCount"));

            if(SettingsDictionary["HideTime"] == "")
            {
                Hide_TB.Text = "300";
                Provider.IniHandler.WritePrivateString("Settings", "HideTime", "300");
            }
            else
            {
                Hide_TB.Text = SettingsDictionary["HideTime"];
            }

            if(SettingsDictionary["ThreadsCount"] == "")
            {
                Threads_TB.Text = "8";
                Provider.IniHandler.WritePrivateString("Settings", "ThreadsCount", "8");
            }
            else
            {
                Threads_TB.Text = SettingsDictionary["ThreadsCount"];
            }

            if (SettingsDictionary["RestartTimeOut"] == "")
            {
                Rest_TB.Text = "120";
                Provider.IniHandler.WritePrivateString("Settings", "RestartTimeOut", "120");
            }
            else
            {
                Rest_TB.Text = SettingsDictionary["RestartTimeOut"];
            }

            if (SettingsDictionary["ConnectionTimeOut"] == "")
            {
                Conn_TB.Text = "5";
                Provider.IniHandler.WritePrivateString("Settings", "ConnectionTimeOut", "5");
            }
            else
            {
                Conn_TB.Text = SettingsDictionary["ConnectionTimeOut"];
            }

            if (SettingsDictionary["BoostCount"] == "")
            {
                Boost_TB.Text = "25";
                Provider.IniHandler.WritePrivateString("Settings", "BoostCount", "25");
            }
            else
            {
                Boost_TB.Text = SettingsDictionary["BoostCount"];
            }
        }

        private void UpdateConfig()
        {
            SettingsDictionary["HideTime"] = Hide_TB.Text;
            SettingsDictionary["ThreadsCount"] = Threads_TB.Text;
            SettingsDictionary["RestartTimeOut"] = Rest_TB.Text;
            SettingsDictionary["ConnectionTimeOut"] = Conn_TB.Text;
            SettingsDictionary["BoostCount"] = Boost_TB.Text;
        }

        public void SaveConfig()
        {
            UpdateConfig();

            foreach (var setting in SettingsDictionary)
            {
                Provider.IniHandler.WritePrivateString("Settings", setting.Key, setting.Value);
            }
        }
    }
}
