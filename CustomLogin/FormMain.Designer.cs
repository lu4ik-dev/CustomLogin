namespace CustomLogin
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuItems = new System.Windows.Forms.Panel();
            this.buttonChangeThemes = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonManageItems = new System.Windows.Forms.Button();
            this.buttonManageCusts = new System.Windows.Forms.Button();
            this.buttonManageCustomers = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Controls.Add(this.buttonMaximize);
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 35);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "CustomLogin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(695, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(35, 35);
            this.buttonMinimize.TabIndex = 9;
            this.buttonMinimize.Text = "—";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.buttonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMaximize.ForeColor = System.Drawing.Color.White;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(730, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(35, 35);
            this.buttonMaximize.TabIndex = 8;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(41)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(765, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 35);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CustomLogin.Properties.Resources.logoLightFocus;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMenuItems
            // 
            this.panelMenuItems.Controls.Add(this.buttonChangeThemes);
            this.panelMenuItems.Controls.Add(this.buttonLogout);
            this.panelMenuItems.Controls.Add(this.buttonManageItems);
            this.panelMenuItems.Controls.Add(this.buttonManageCusts);
            this.panelMenuItems.Controls.Add(this.buttonManageCustomers);
            this.panelMenuItems.Controls.Add(this.buttonManageUsers);
            this.panelMenuItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuItems.Location = new System.Drawing.Point(0, 35);
            this.panelMenuItems.Name = "panelMenuItems";
            this.panelMenuItems.Size = new System.Drawing.Size(200, 415);
            this.panelMenuItems.TabIndex = 1;
            // 
            // buttonChangeThemes
            // 
            this.buttonChangeThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonChangeThemes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChangeThemes.FlatAppearance.BorderSize = 0;
            this.buttonChangeThemes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonChangeThemes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonChangeThemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeThemes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeThemes.ForeColor = System.Drawing.Color.White;
            this.buttonChangeThemes.Image = ((System.Drawing.Image)(resources.GetObject("buttonChangeThemes.Image")));
            this.buttonChangeThemes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeThemes.Location = new System.Drawing.Point(0, 334);
            this.buttonChangeThemes.Name = "buttonChangeThemes";
            this.buttonChangeThemes.Size = new System.Drawing.Size(200, 47);
            this.buttonChangeThemes.TabIndex = 7;
            this.buttonChangeThemes.Text = "Сменить \r\nтему";
            this.buttonChangeThemes.UseVisualStyleBackColor = false;
            this.buttonChangeThemes.Click += new System.EventHandler(this.buttonChangeThemes_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 381);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(200, 34);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Выйти";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonManageItems
            // 
            this.buttonManageItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonManageItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageItems.FlatAppearance.BorderSize = 0;
            this.buttonManageItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonManageItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonManageItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageItems.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManageItems.ForeColor = System.Drawing.Color.White;
            this.buttonManageItems.Location = new System.Drawing.Point(0, 180);
            this.buttonManageItems.Name = "buttonManageItems";
            this.buttonManageItems.Size = new System.Drawing.Size(200, 60);
            this.buttonManageItems.TabIndex = 5;
            this.buttonManageItems.Text = "Управление товарами";
            this.buttonManageItems.UseVisualStyleBackColor = false;
            // 
            // buttonManageCusts
            // 
            this.buttonManageCusts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonManageCusts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageCusts.FlatAppearance.BorderSize = 0;
            this.buttonManageCusts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonManageCusts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonManageCusts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageCusts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManageCusts.ForeColor = System.Drawing.Color.White;
            this.buttonManageCusts.Location = new System.Drawing.Point(0, 120);
            this.buttonManageCusts.Name = "buttonManageCusts";
            this.buttonManageCusts.Size = new System.Drawing.Size(200, 60);
            this.buttonManageCusts.TabIndex = 4;
            this.buttonManageCusts.Text = "Управление заказами";
            this.buttonManageCusts.UseVisualStyleBackColor = false;
            // 
            // buttonManageCustomers
            // 
            this.buttonManageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonManageCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageCustomers.FlatAppearance.BorderSize = 0;
            this.buttonManageCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonManageCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageCustomers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManageCustomers.ForeColor = System.Drawing.Color.White;
            this.buttonManageCustomers.Location = new System.Drawing.Point(0, 60);
            this.buttonManageCustomers.Name = "buttonManageCustomers";
            this.buttonManageCustomers.Size = new System.Drawing.Size(200, 60);
            this.buttonManageCustomers.TabIndex = 3;
            this.buttonManageCustomers.Text = "Управление заказчиками";
            this.buttonManageCustomers.UseVisualStyleBackColor = false;
            this.buttonManageCustomers.Click += new System.EventHandler(this.buttonManageCustomers_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.buttonManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageUsers.FlatAppearance.BorderSize = 0;
            this.buttonManageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManageUsers.ForeColor = System.Drawing.Color.White;
            this.buttonManageUsers.Location = new System.Drawing.Point(0, 0);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(200, 60);
            this.buttonManageUsers.TabIndex = 2;
            this.buttonManageUsers.Text = "Управление пользователями";
            this.buttonManageUsers.UseVisualStyleBackColor = false;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(600, 415);
            this.panelContainer.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenuItems);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 466);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenuItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuItems;
        private System.Windows.Forms.Button buttonChangeThemes;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonManageItems;
        private System.Windows.Forms.Button buttonManageCusts;
        private System.Windows.Forms.Button buttonManageCustomers;
        private System.Windows.Forms.Button buttonManageUsers;
        public System.Windows.Forms.Panel panelContainer;
    }
}