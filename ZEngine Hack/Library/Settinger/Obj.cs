using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_Hack.Library.Settinger
{
    class Obj : ISettinger
    {
        private Dictionary<string, string> GeneralConfigData = new Dictionary<string, string>();
        private Dictionary<string, string> UpdateConfigData  = new Dictionary<string, string>();

        //General Tags
        private string[] GeneralConfigTags = new string[]
        {
            "HideTime",
            "ThreadsCount",
            "RestartTimeOut",
            "ConnectionTimeOut",
            "BoostCount"
        };

        //Update Tags
        private string[] UpdateConfigTags = new string[]
        {
            "AutoUpdateEnable",
            "TypeUpdate",
            "HowUpdate",
            "SetupUpdateDate",
            "SetupUpdateSpeed"
        };

        public void Load()
        {
            LoadGeneralConfigData();
            LoadUpdateConfigData();
        }
        public void Save()
        {
            SaveGeneralConfigData();
            SaveUpdateConfigData();
        }

        public void SetKey(string key, string value, int type = 0)
        {
            if (type != 0)
                UpdateConfigData[key] = value;
            else
                GeneralConfigData[key] = value;
        }

        public string GetKey(string key, int type = 0)
        {
            if (type != 0)
                return UpdateConfigData[key];
            else
                return GeneralConfigData[key];
        }

        private void LoadGeneralConfigData()
        {
            foreach (string cfg in GeneralConfigTags)
            {
                GeneralConfigData.Add(cfg, Provider.IniHandler.GetPrivateString("Settings", cfg));
            }
        }

        private void LoadUpdateConfigData()
        {
            foreach (string cfg in UpdateConfigTags)
            {
                UpdateConfigData.Add(cfg, Provider.IniHandler.GetPrivateString("Settings", cfg));
            }
        }

        private void SaveGeneralConfigData()
        {
            foreach(var data in GeneralConfigData)
            {
                Provider.IniHandler.WritePrivateString("Settings", data.Key, data.Value);
            }
        }

        private void SaveUpdateConfigData()
        {
            foreach (var data in UpdateConfigData)
            {
                Provider.IniHandler.WritePrivateString("Settings", data.Key, data.Value);
            }
        }
    }
}
