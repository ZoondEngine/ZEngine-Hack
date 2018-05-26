using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_Hack.Elements
{
    public partial class SettingsTab : UserControl
    {
        InSettingsElements.General General = new InSettingsElements.General();
        InSettingsElements.Updates Updates = new InSettingsElements.Updates();

        public SettingsTab()
        {
            InitializeComponent();
        }
        
        private void SetInnerTab(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            sender.selected = true;

            HideAllTabs();

            switch(sender.Name)
            {
                case "GeneralSettings_Button":
                    {
                        General.Parent = SettingsContentPanel;
                        General.Show();

                        break;
                    }

                case "UpdateSettings_Button":
                    {
                        Updates.Parent = SettingsContentPanel;
                        Updates.Show();

                        break;
                    }
            }
        }

        private void HideAllTabs()
        {
            General.Hide();
            Updates.Hide();
        }

        private void GeneralSettings_Button_Click(object sender, EventArgs e)
        {
            SetInnerTab(GeneralSettings_Button);
        }

        private void UpdateSettings_Button_Click(object sender, EventArgs e)
        {
            SetInnerTab(UpdateSettings_Button);
        }

        private void OtherSettings_Button_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {
            SetInnerTab(GeneralSettings_Button);
        }

        private void SaveSettings()
        {
            Updates.SaveConfig();
            General.SaveConfig();

            MessageBox.Show("ST<SS>[0x331DDF113->0x7D]\n\nНастройки успешно сохранены\n\nПриложение будет перезапущено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Restart();
        }
    }
}
