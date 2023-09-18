using CustomLogin.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLogin
{
    public partial class FormMain : Form
    {
        private Point mouseDownLocation;
        public FormMain()
        {
            InitializeComponent();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Opacity = 0; // начальное значение прозрачности
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 20; // интервал таймера в миллисекундах
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            UI_Home uc = new UI_Home();
            addUserControl(uc);
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

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            tech.user_logged_in = false;
            tech.admin_lvl = 0;
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void buttonChangeTheme_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            UI_UserManager uc = new UI_UserManager();
            addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UI_Home uc = new UI_Home();
            addUserControl(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UI_Home uc = new UI_Home();
            addUserControl(uc);
        }

        private void buttonChangeThemes_Click(object sender, EventArgs e)
        {
            List<Control> allControls = GetAllControls(this);
            if (Properties.Settings.Default.ChangeTheme == "dark")
            {
                Properties.Settings.Default.ChangeTheme = "light";
                Properties.Settings.Default.Save();

                // Изменяем цвет всех элементов на форме
                foreach (Control control in allControls) // all work
                {
                    if (control.BackColor == tech.DarkAccentHeader) { control.BackColor = tech.LightAccentHeader; }
                    else { control.BackColor = tech.LightAccent; }
                    control.ForeColor = tech.DarkAccent;
                }

            }
            else 
            {
                Properties.Settings.Default.ChangeTheme = "dark";
                Properties.Settings.Default.Save();

                // Изменяем цвет всех элементов на форме
                foreach (Control control in allControls)
                {
                    if (control.BackColor == tech.LightAccentHeader) { control.BackColor = tech.DarkAccentHeader; }
                    else { control.BackColor = tech.DarkAccent; }
                    control.BackColor = tech.DarkAccent;
                    control.ForeColor = tech.LightAccent;
                }
            }
        }

        private List<Control> GetAllControls(Control control)
        {
            List<Control> controls = new List<Control>();
            foreach (Control c in control.Controls)
            {
                controls.Add(c);
                controls.AddRange(GetAllControls(c));
            }
            return controls;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseDownLocation.X;
                this.Top += e.Y - mouseDownLocation.Y;
            }
        }

        private void buttonManageCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
