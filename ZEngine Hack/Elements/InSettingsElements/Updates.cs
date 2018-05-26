using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_Hack.Elements.InSettingsElements
{
    public partial class Updates : UserControl
    {
        public static Updates Instance;
        private static Dictionary<string, string> SettingsDictionary = new Dictionary<string, string>();

        public Updates()
        {
            Instance = this;
            InitializeComponent();
        }

        private void Updates_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            SettingsDictionary.Add("AutoUpdateEnable", Provider.IniHandler.GetPrivateString("Settings", "AutoUpdateEnable"));
            SettingsDictionary.Add("TypeUpdate", Provider.IniHandler.GetPrivateString("Settings", "TypeUpdate"));
            SettingsDictionary.Add("HowUpdate", Provider.IniHandler.GetPrivateString("Settings", "HowUpdate"));
            SettingsDictionary.Add("SetupUpdateDate", Provider.IniHandler.GetPrivateString("Settings", "SetupUpdateDate"));
            SettingsDictionary.Add("SetupUpdateSpeed", Provider.IniHandler.GetPrivateString("Settings", "SetupUpdateSpeed"));

            if(SettingsDictionary["AutoUpdateEnable"] != "True" && SettingsDictionary["AutoUpdateEnable"] != "False")
            {
                AutoUpdateSwitch.Value = true;
                Provider.IniHandler.WritePrivateString("Settings", "AutoUpdateEnable", "True");
            }
            else
            {
                if(SettingsDictionary["AutoUpdateEnable"] == "True")
                    AutoUpdateSwitch.Value = true;
                else
                    AutoUpdateSwitch.Value = false;
            }

            if(SettingsDictionary["TypeUpdate"] == "")
            {
                TypeDropdown.selectedIndex = 0;
                Provider.IniHandler.WritePrivateString("Settings", "TypeUpdate", TypeDropdown.selectedValue);
            }
            else
            {
                switch(SettingsDictionary["TypeUpdate"].ToUpper())
                {
                    case "ВСЕ":
                        {
                            TypeDropdown.selectedIndex = 0;
                            break;
                        }

                    case "МИНОР":
                        {
                            TypeDropdown.selectedIndex = 1;
                            break;
                        }

                    case "ВАЖНЫЕ":
                        {
                            TypeDropdown.selectedIndex = 2;
                            break;
                        }

                    case "КРИТИЧЕСКИЕ":
                        {
                            TypeDropdown.selectedIndex = 3;
                            break;
                        }
                }
            }

            if (SettingsDictionary["HowUpdate"] == "")
            {
                HowDropdown.selectedIndex = 0;
                Provider.IniHandler.WritePrivateString("Settings", "HowUpdate", TypeDropdown.selectedValue);
            }
            else
            {
                switch (SettingsDictionary["HowUpdate"].ToUpper())
                {
                    case "ВСЕГДА":
                        {
                            HowDropdown.selectedIndex = 0;
                            break;
                        }

                    case "УТРОМ":
                        {
                            HowDropdown.selectedIndex = 1;
                            break;
                        }

                    case "ДНЕМ":
                        {
                            HowDropdown.selectedIndex = 2;
                            break;
                        }

                    case "НОЧЬЮ":
                        {
                            HowDropdown.selectedIndex = 3;
                            break;
                        }
                }
            }

            if(SettingsDictionary["SetupUpdateDate"] != "")
            {
                SetDateDatepicker.Value = DateTime.Parse(SettingsDictionary["SetupUpdateDate"]);
            }

            if(SettingsDictionary["SetupUpdateSpeed"] == "")
            {
                SpeedSlider.Value = 800;
                Provider.IniHandler.WritePrivateString("Settings", "SetupUpdateSpeed", "800");
            }
            else
            {
                SpeedSlider.Value = Int32.Parse(SettingsDictionary["SetupUpdateSpeed"]);
            }
        }

        private void UpdateConfig()
        {
            SettingsDictionary["AutoUpdateEnable"] = AutoUpdateSwitch.Value ? "True" : "False";

            if(TypeDropdown.selectedIndex != -1)
                SettingsDictionary["TypeUpdate"] = TypeDropdown.selectedValue;

            if(HowDropdown.selectedIndex != -1)
                SettingsDictionary["HowUpdate"] = HowDropdown.selectedValue;

            SettingsDictionary["SetupUpdateDate"] = SetDateDatepicker.Value.ToShortDateString();
            SettingsDictionary["SetupUpdateSpeed"] = SpeedSlider.Value.ToString();
        }

        public void SaveConfig()
        {
            UpdateConfig();

            foreach(var setting in SettingsDictionary)
            {
                Provider.IniHandler.WritePrivateString("Settings", setting.Key, setting.Value);
            }
        }
    }
}
