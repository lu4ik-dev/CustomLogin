using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLogin
{
    internal class tech
    {
        public static bool expectation = false;
        public static int admin_lvl = 0;
        public static bool user_logged_in = false;

        public async void ChangePanel(Panel PanelFirst, Panel ChangePanel, int FormSizeWidth)
        { 
            ChangePanel.Location = new System.Drawing.Point(FormSizeWidth, 0);
            ChangePanel.Enabled = true;
            ChangePanel.Visible = true;
            Point StartChangePanel = ChangePanel.Location;
            Point StartPanelFirst = PanelFirst.Location;
            while (!expectation && ChangePanel.Location.X > StartPanelFirst.X)  
            {
                expectation = true;
                await Task.Delay(10);
                PanelFirst.Location = new Point(PanelFirst.Location.X - 32, ChangePanel.Location.Y);;
                ChangePanel.Location = new Point(ChangePanel.Location.X - 32, PanelFirst.Location.Y);
                expectation = false;
            }
            PanelFirst.Visible = false;
            PanelFirst.Enabled = false;
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public void rowsPainter(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Console.WriteLine($"RowIndex: {e.RowIndex}; Bounds: {e.RowBounds}");
            if ((e.RowIndex % 2) == 0)
            {
                ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
            }
        }

        #region colors

        public static Color DarkAccent = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
        public static Color DarkAccentHeader = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
        public static Color LightAccent  = System.Drawing.Color.White;
        public static Color LightAccentHeader = System.Drawing.Color.White;
        //        public static Color LightAccentHeader = System.Drawing.Color.DodgerBlue;

        #endregion



    }
}
