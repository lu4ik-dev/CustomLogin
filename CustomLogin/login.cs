using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomLogin
{
    public partial class login : Form
    {
        
        tech tech = new tech();
        public login()
        {
            InitializeComponent();
            DoubleBuffered = true;
            textBoxLogin.TabStop = false;
            textBoxPassword.TabStop = false;
            this.Size = new System.Drawing.Size(320, 460);
        }

        #region Tech Variables
        private Point mouseDownLocation;
        private bool passwordHide = false; 
        private bool passwordHideRegister = false;
        private string exampleLoginText = "Username";
        private string examplePasswordText = "Password";
        #endregion

        private void login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0; // начальное значение прозрачности
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10; // интервал таймера в миллисекундах
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) // если прозрачность меньше 1, то увеличиваем её на 0.05
            {
                this.Opacity += 0.04;
            }
            else
            {
                ((System.Windows.Forms.Timer)sender).Stop(); // останавливаем таймер, если достигнута максимальная прозрачность
            }
        }

        #region hover mouse login panel
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void panelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseDownLocation.X;
                this.Top += e.Y - mouseDownLocation.Y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HiderPassword_Click(object sender, EventArgs e)
        {
            if (!passwordHide) // если текст не скрыт
            {
                if (textBoxPassword.Focused)
                {
                    HiderPassword.BackgroundImage = Properties.Resources.showPasswordFocus; // 
                }
                else 
                {
                    HiderPassword.BackgroundImage = Properties.Resources.showPassword; // 
                }
                textBoxPassword.PasswordChar = '*'; // заменяем символы текста на звездочки
                passwordHide = true; // устанавливаем флаг скрытия
            }
            else // если текст скрыт
            {
                if (textBoxPassword.Focused)
                {
                    HiderPassword.BackgroundImage = Properties.Resources.hidePasswordFocus; // 
                }
                else
                {
                    HiderPassword.BackgroundImage = Properties.Resources.hidePassword; // 
                }
                textBoxPassword.PasswordChar = '\0'; // показываем текст
                passwordHide = false; // сбрасываем флаг скрытия
            }
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {

            loginLogotip.BackgroundImage = Properties.Resources.logoLightFocus;
            pictureBoxLogin.BackgroundImage = Properties.Resources.enterLoginFocus;
            textBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            panelDelitelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            if (textBoxLogin.Text == exampleLoginText) 
            {
                textBoxLogin.Text = "";
            }
        }
        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            loginLogotip.BackgroundImage = Properties.Resources.logoLight;
            pictureBoxLogin.BackgroundImage = Properties.Resources.enterLogin;
            textBoxLogin.ForeColor = Color.White;
            panelDelitelLogin.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = exampleLoginText;
            }
        }


        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            loginLogotip.BackgroundImage = Properties.Resources.logoLightFocus;
            pictureBoxPassword.BackgroundImage = Properties.Resources.enterPasswordFocus;
            if(!passwordHide)HiderPassword.BackgroundImage = Properties.Resources.showPasswordFocus; else { HiderPassword.BackgroundImage = Properties.Resources.hidePasswordFocus; }
            textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            panelDelitelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            if (textBoxPassword.Text == examplePasswordText)
            {
                textBoxPassword.Text = "";
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            loginLogotip.BackgroundImage = Properties.Resources.logoLight;
            pictureBoxPassword.BackgroundImage = Properties.Resources.enterPassword;
            if (!passwordHide) HiderPassword.BackgroundImage = Properties.Resources.hidePassword; else { HiderPassword.BackgroundImage = Properties.Resources.showPassword; }
            textBoxPassword.ForeColor = Color.White;
            panelDelitelPassword.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = examplePasswordText;
            }
        }
#endregion
        private void buttonSignin_Click(object sender, EventArgs e)
        {
            tech.ChangePanel(panelLogin, panelRegister, this.Width);
        }

        private void buttonRegisterExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegLogin_Click(object sender, EventArgs e)
        {

            tech.ChangePanel(panelRegister, panelLogin, this.Width);
        }
        #region hover mouse Register panel

        private void textBoxFirstPassRegister_Enter(object sender, EventArgs e)
        {
            RegisterLogotip.BackgroundImage = Properties.Resources.logoLightFocus;
            pictureBoxPasswordRegister.BackgroundImage = Properties.Resources.enterPasswordFocus;
            panelDelitelPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            if (!passwordHide) HiderPasswordRegister.BackgroundImage = Properties.Resources.showPasswordFocus; else { HiderPasswordRegister.BackgroundImage = Properties.Resources.hidePasswordFocus; }
            textBoxFirstPassRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            if (textBoxFirstPassRegister.Text == examplePasswordText)
            {
                textBoxFirstPassRegister.Text = "";
            }
        }

        private void textBoxFirstPassRegister_Leave(object sender, EventArgs e)
        {
            RegisterLogotip.BackgroundImage = Properties.Resources.logoLight;
            pictureBoxPasswordRegister.BackgroundImage = Properties.Resources.enterPassword;
            if (!passwordHide) HiderPasswordRegister.BackgroundImage = Properties.Resources.hidePassword; else { HiderPasswordRegister.BackgroundImage = Properties.Resources.showPassword; }
            textBoxFirstPassRegister.ForeColor = Color.White;
            panelDelitelPasswordRegister.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(textBoxFirstPassRegister.Text))
            {
                textBoxFirstPassRegister.Text = examplePasswordText;
            }
        }

        private void textBoxConfirmPassRegister_Enter(object sender, EventArgs e)
        {
            RegisterLogotip.BackgroundImage = Properties.Resources.logoLightFocus;
            pictureBoxConfirmPasswordRegister.BackgroundImage = Properties.Resources.enterPasswordFocus;
            if (!passwordHideRegister) HiderPasswordRegister.BackgroundImage = Properties.Resources.showPasswordFocus; else { HiderPasswordRegister.BackgroundImage = Properties.Resources.hidePasswordFocus; }
            textBoxConfirmPassRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            panelDelitelConfirmRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            if (textBoxFirstPassRegister.Text != textBoxConfirmPassRegister.Text)
            {
                textBoxConfirmPassRegister.ForeColor = Color.Red;
                panelDelitelConfirmRegister.BackColor = Color.Red;
            }
            if (textBoxConfirmPassRegister.Text == examplePasswordText)
            {
                textBoxConfirmPassRegister.Text = "";
            }
        }

        private void textBoxConfirmPassRegister_Leave(object sender, EventArgs e)
        {
            RegisterLogotip.BackgroundImage = Properties.Resources.logoLight;
            pictureBoxConfirmPasswordRegister.BackgroundImage = Properties.Resources.enterPassword;
            if (!passwordHide) HiderPasswordRegister.BackgroundImage = Properties.Resources.hidePassword; else { HiderPasswordRegister.BackgroundImage = Properties.Resources.showPassword; }
            textBoxConfirmPassRegister.ForeColor = Color.White;
            panelDelitelConfirmRegister.BackColor = Color.White;
            if (textBoxFirstPassRegister.Text != textBoxConfirmPassRegister.Text)
            {
                textBoxConfirmPassRegister.ForeColor = Color.Red;
                panelDelitelConfirmRegister.BackColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(textBoxConfirmPassRegister.Text))
            {
                textBoxConfirmPassRegister.Text = examplePasswordText;
            }
        }

        private void HiderPasswordRegister_Click(object sender, EventArgs e)
        {
            if (!passwordHideRegister) // если текст не скрыт
            {
                if (textBoxFirstPassRegister.Focused)
                {
                    HiderPassword.BackgroundImage = Properties.Resources.showPasswordFocus; // 
                }
                else
                {
                    HiderPassword.BackgroundImage = Properties.Resources.showPassword; // 
                }
                textBoxFirstPassRegister.PasswordChar = '*'; // заменяем символы текста на звездочки
                textBoxConfirmPassRegister.PasswordChar = '*';
                passwordHideRegister = true; // устанавливаем флаг скрытия
            }
            else // если текст скрыт
            {
                if (textBoxPassword.Focused)
                {
                    HiderPassword.BackgroundImage = Properties.Resources.hidePasswordFocus; // 
                }
                else
                {
                    HiderPassword.BackgroundImage = Properties.Resources.hidePassword; // 
                }
                textBoxFirstPassRegister.PasswordChar = '\0'; // показываем текст
                textBoxConfirmPassRegister.PasswordChar = '\0';
                passwordHideRegister = false; // сбрасываем флаг скрытия
            }
        }

        private void textBoxUsnameRegister_Leave(object sender, EventArgs e)
        {
            RegisterLogotip.BackgroundImage = Properties.Resources.logoLight;
            pictureBoxUsernameRegister.BackgroundImage = Properties.Resources.enterLogin;
            textBoxUsnameRegister.ForeColor = Color.White;
            panelDelitelLoginRegister.BackColor= Color.White;
            if (string.IsNullOrWhiteSpace(textBoxUsnameRegister.Text))
            {
                textBoxUsnameRegister.Text = exampleLoginText;
            }
            if(textBoxUsnameRegister.TextLength < 6) { }
        }

        private void textBoxUsnameRegister_Enter(object sender, EventArgs e)
        {
            RegisterLogotip.BackgroundImage = Properties.Resources.logoLightFocus;
            pictureBoxUsernameRegister.BackgroundImage = Properties.Resources.enterLoginFocus;
            textBoxUsnameRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            panelDelitelLoginRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            if (textBoxUsnameRegister.Text == exampleLoginText)
            {
                textBoxUsnameRegister.Text = "";
            }


        }
        #endregion

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Username") { tech.Alert($"Введите имя пользователя", Form_Alert.enmType.Warning); return; };
            if (textBoxPassword.Text == "Password") { tech.Alert($"Введите пароль", Form_Alert.enmType.Warning); return; };
            try
            {
                Regex r = new Regex(@"\s+");
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CustomLoginConnectionString))
                {
                    connection.Open();

                    string sql = $"SELECT admin, password FROM CustomLogin.dbo.login WHERE username = '{textBoxLogin.Text}' GROUP BY admin, password";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (r.Replace(Convert.ToString(reader[1]), @"") == textBoxPassword.Text) { tech.admin_lvl = Convert.ToInt32(reader[0]); tech.Alert($"Вы успешно авторизовались как {textBoxLogin.Text}", Form_Alert.enmType.Success);
                                        tech.user_logged_in = true;
                                        FormMain FormMain = new FormMain();
                                        FormMain.Show();
                                        this.Hide();
                                    }
                                    else { tech.Alert($"Ошибка, неверный пароль", Form_Alert.enmType.Error); }
                                }
                            }
                            else { tech.Alert($"Ошибка, такого аккаунта нет в базе данных", Form_Alert.enmType.Error); }
                        }
                    }
                }
            }
            catch (Exception ex) {MessageBox.Show(ex.ToString()); tech.Alert($"{ex.Message}", Form_Alert.enmType.Error); }
        }
         
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFirstPassRegister.Text != textBoxConfirmPassRegister.Text)
            {
                tech.Alert($"Пароли не совпадают", Form_Alert.enmType.Error);
                return;
            }
            if (textBoxUsnameRegister.Text == "Username") { tech.Alert($"Введите имя пользователя", Form_Alert.enmType.Warning); return; };
            if (textBoxFirstPassRegister.Text == "Password") { tech.Alert($"Введите пароль", Form_Alert.enmType.Warning); return; };
            string sql = "SELECT COUNT(*) FROM CustomLogin.dbo.login WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.CustomLoginConnectionString))
            {
                // создание объекта команды SQL
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // задание параметров для username и password
                    command.Parameters.AddWithValue("@username", textBoxUsnameRegister.Text);

                    // открытие подключения к базе данных
                    connection.Open();

                    // выполнение запроса и получение результата
                    int count = (int)command.ExecuteScalar();

                    // проверка наличия записи
                    if (count > 0)
                    {
                        tech.Alert($"Аккаунт с именем {textBoxUsnameRegister.Text} уже существует", Form_Alert.enmType.Error);
                    }
                    else
                    {
                        connection.Close();
                        using (connection)
                        {
                            connection.Open();

                            sql = "INSERT INTO CustomLogin.dbo.login (username, password) VALUES (@login, @password)";

                            using (SqlCommand com = new SqlCommand(sql, connection))
                            {
                                com.Parameters.AddWithValue("@login", textBoxUsnameRegister.Text);
                                com.Parameters.AddWithValue("@password", textBoxConfirmPassRegister.Text);

                                int rowsAffected = com.ExecuteNonQuery();
                                tech.Alert($"{textBoxUsnameRegister.Text} успешно зарегистрирован", Form_Alert.enmType.Success);
                            }
                        }
                    }
                }
            }         
        }

        private void textBoxConfirmPassRegister_TextChanged(object sender, EventArgs e)
        {
            if(textBoxFirstPassRegister.Text != textBoxConfirmPassRegister.Text) 
            {
                textBoxConfirmPassRegister.ForeColor= Color.Red;
                panelDelitelConfirmRegister.BackColor = Color.Red;
            }
            else {textBoxConfirmPassRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254))))); panelDelitelConfirmRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254))))); }
        }
    }
}

