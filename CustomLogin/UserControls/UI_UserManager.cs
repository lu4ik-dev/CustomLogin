using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace CustomLogin.UserControls
{
    public partial class UI_UserManager : UserControl
    {
        tech tech = new tech();
        private bool passwordShow = false;
        public UI_UserManager()
        {
            InitializeComponent();
            ColumnPassword.Visible = false;
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customLoginDataSet);
        }

        private void ShowPasswords_Click(object sender, EventArgs e)
        {
            if (!passwordShow) { ColumnPassword.Visible = !passwordShow; passwordShow = !passwordShow; ShowPasswords.Image = Properties.Resources.hidePassword; }
            else { ColumnPassword.Visible = !passwordShow; passwordShow = !passwordShow;  ShowPasswords.Image = Properties.Resources.showPassword; } 
        }

        private void UI_UserManager_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewUsers.Dock = DockStyle.Fill;
                dataGridViewUsers.Rows.Clear();
                string Sql = $"SELECT COUNT(*) as count FROM CustomLogin.dbo.login;";
                SqlConnection conn = new SqlConnection(global::CustomLogin.Properties.Settings.Default.CustomLoginConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                Int32 CountOfCells = (int)cmd.ExecuteScalar();
                dataGridViewUsers.Rows.Add(CountOfCells);
                conn.Close();
                conn.Open();
                Sql = $"SELECT user_id, username, password, admin, firstname, lastname FROM CustomLogin.dbo.login;";
                cmd = new SqlCommand(Sql, conn);
                SqlDataReader DR = cmd.ExecuteReader();
                Console.WriteLine($"[DebugSearch1]: {DR.ToString()}");
                int i = 0;
                while (DR.Read())
                {
                    Console.WriteLine($"[DebugSearch2]: {DR[0]} {DR[1]} {DR[2]} || i = {i}");
                    dataGridViewUsers.Rows[i].Cells[0].Value = DR[0];
                    dataGridViewUsers.Rows[i].Cells[1].Value = DR[1];
                    dataGridViewUsers.Rows[i].Cells[2].Value = DR[2];
                    dataGridViewUsers.Rows[i].Cells[3].Value = DR[3];
                    dataGridViewUsers.Rows[i].Cells[4].Value = DR[4];
                    dataGridViewUsers.Rows[i].Cells[5].Value = DR[5];
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ErrorInSearch]: {ex.Message}");
            }
        }

        private void dataGridViewUsers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            tech.rowsPainter(sender, e);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Visible = false;
            buttonSelect.Text = "Применить";
            tech.Alert($"Выделена строка {int.Parse(dataGridViewUsers.CurrentRow.Cells[0].Value.ToString())}", Form_Alert.enmType.Error);


            string Sql = Sql = $"SELECT user_id, username, password, admin, firstname, lastname FROM CustomLogin.dbo.login WHERE user_id = {int.Parse(dataGridViewUsers.CurrentRow.Cells[0].Value.ToString())};";
            SqlConnection conn = new SqlConnection(global::CustomLogin.Properties.Settings.Default.CustomLoginConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                textBox1.Text = DR[1].ToString();
                textBox2.Text = DR[2].ToString();
                textBox3.Text = DR[4].ToString();
                textBox4.Text = DR[5].ToString();
            }


            // Regex r = new Regex(@"\s+");
            // ComplectName = r.Replace(ComplectName, @" ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Visible = true;
        }

    }
}
