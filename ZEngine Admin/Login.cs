using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEngine_Admin
{
    public partial class Login : Form
    {
        public class UserData
        {
            public string Name { get; private set; }
            public string Password { get; private set; }
            public bool IsActivity { get; private set; }

            public UserData(string[] fromFile)
            {
                Parse(fromFile);
            }

            private void Parse(string[] data)
            {
                Name = data[0].Split('=')[1];
                Password = data[1].Split('=')[1];

                if (data[2].Split('=')[1] == "True")
                    IsActivity = true;
                else
                    IsActivity = false;
            }
        }

        private WebClient Client = new WebClient();
        private MainForm Main;
        private UserData User;
        private string RandFileName, RandFileExt;

        public Login(MainForm obj)
        {
            InitializeComponent();

            Main = obj;

            if(obj.WindowState == FormWindowState.Normal)
            {
                obj.Hide();
            }

            RandFileName = GenRandomString("qwertyuiopasdfghjklzxcvbnm1234567890", 6);
            RandFileExt = GenRandomString("qwertyuiopasdfghjklzxcvbnm1234567890", 3);
        }

        private void HeadClosePictureButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HeadMinimizePictureButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            LockUI(true);

            if(CheckInput())
            {
                if(CheckData())
                {
                    LockUI(false);
                    this.Hide();
                    Main.Show();
                }
                else
                {
                    LockUI(false);
                }
            }
            else
            {
                LockUI(false);
            }
        }

        string GenRandomString(string Alphabet, int Length)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(Length - 1);
            int Position = 0;

            for (int i = 0; i < Length; i++)
            {
                Position = rnd.Next(0, Alphabet.Length - 1);
                sb.Append(Alphabet[Position]);
            }

            return sb.ToString();
        }

        private bool CheckData()
        {
            bool response = false;
            Client.Credentials = new NetworkCredential("zehack_adm_new", "Cfvjcbqbkmz1112589635");

            try
            {
                Client.DownloadFile(new Uri($"http://api.zehack.ru1/ZELab/AT/Users/{LoginTextBox.Text}/dt.txt"), RandFileName + "." + RandFileExt);
                string[] UserData = System.IO.File.ReadAllLines(RandFileName + "." + RandFileExt);
                System.IO.File.Delete(RandFileName + "." + RandFileExt);

                User = new UserData(UserData);
                UserData = null;

                if(User.Name == LoginTextBox.Text) //Login double check
                {
                    if(User.Password == PasswordTextBox.Text) //Password
                    {
                        if(User.IsActivity) //Activity
                        {
                            response = true;
                        }
                        else
                        {
                            MessageBox.Show("Указанный пользователь не активен\n\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            response = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введен неверный пароль\n\nПроверьте указанные данные и повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        response = false;
                    }
                }
                else
                {
                    MessageBox.Show("У указанного пользователя отключена аутентификация\n\nОбратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    response = false;
                }
            }
            catch(WebException)
            {
                MessageBox.Show("Указанного вами пользователя не существует\nПроверьте введенные данные и повторите попытку\n\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                response = false;
            }

            return response;
        }

        private bool CheckInput()
        {
            if(LoginTextBox.Text == String.Empty)
            {
                MessageBox.Show("Поле 'Логин' должно содержать значение\n\nПроверьте введенные данные и повторите попытку");

                return false;
            }
            else
            {
                if(PasswordTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Поле 'Пароль' должно содержать значение\n\nПроверьте введенные данные и повторите попытку");

                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void LockUI(bool locked)
        {
            if(locked)
            {
                LoginTextBox.Enabled = false;
                PasswordTextBox.Enabled = false;
            }
            else
            {
                LoginTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;
            }
        }
    }
}
