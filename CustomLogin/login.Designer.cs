using System.Windows.Forms;

namespace CustomLogin
{
    partial class login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLoginExit = new System.Windows.Forms.Button();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelDelitelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelDelitelLogin = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panelDelitelConfirmRegister = new System.Windows.Forms.Panel();
            this.textBoxConfirmPassRegister = new System.Windows.Forms.TextBox();
            this.buttonRegisterExit = new System.Windows.Forms.Button();
            this.buttonRegLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panelDelitelPasswordRegister = new System.Windows.Forms.Panel();
            this.textBoxFirstPassRegister = new System.Windows.Forms.TextBox();
            this.panelDelitelLoginRegister = new System.Windows.Forms.Panel();
            this.textBoxUsnameRegister = new System.Windows.Forms.TextBox();
            this.pictureBoxConfirmPasswordRegister = new System.Windows.Forms.PictureBox();
            this.HiderPasswordRegister = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordRegister = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsernameRegister = new System.Windows.Forms.PictureBox();
            this.RegisterLogotip = new System.Windows.Forms.PictureBox();
            this.HiderPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.loginLogotip = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirmPasswordRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiderPasswordRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsernameRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterLogotip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogotip)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.Location = new System.Drawing.Point(78, 146);
            this.textBoxLogin.MaxLength = 16;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 22);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.TabStop = false;
            this.textBoxLogin.Text = "Username";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonLoginExit);
            this.panelLogin.Controls.Add(this.buttonSignin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.HiderPassword);
            this.panelLogin.Controls.Add(this.panelDelitelPassword);
            this.panelLogin.Controls.Add(this.pictureBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.panelDelitelLogin);
            this.panelLogin.Controls.Add(this.pictureBoxLogin);
            this.panelLogin.Controls.Add(this.loginLogotip);
            this.panelLogin.Controls.Add(this.textBoxLogin);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(320, 460);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            this.panelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseMove);
            // 
            // buttonLoginExit
            // 
            this.buttonLoginExit.FlatAppearance.BorderSize = 0;
            this.buttonLoginExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.buttonLoginExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(41)))));
            this.buttonLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginExit.ForeColor = System.Drawing.Color.White;
            this.buttonLoginExit.Location = new System.Drawing.Point(282, 3);
            this.buttonLoginExit.Name = "buttonLoginExit";
            this.buttonLoginExit.Size = new System.Drawing.Size(35, 35);
            this.buttonLoginExit.TabIndex = 6;
            this.buttonLoginExit.Text = "X";
            this.buttonLoginExit.UseVisualStyleBackColor = true;
            this.buttonLoginExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.buttonSignin.FlatAppearance.BorderSize = 0;
            this.buttonSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignin.ForeColor = System.Drawing.Color.White;
            this.buttonSignin.Location = new System.Drawing.Point(48, 371);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(230, 34);
            this.buttonSignin.TabIndex = 2;
            this.buttonSignin.Text = "Зарегистрироваться";
            this.buttonSignin.UseVisualStyleBackColor = false;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(48, 319);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(230, 34);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelDelitelPassword
            // 
            this.panelDelitelPassword.BackColor = System.Drawing.Color.White;
            this.panelDelitelPassword.Location = new System.Drawing.Point(48, 235);
            this.panelDelitelPassword.Name = "panelDelitelPassword";
            this.panelDelitelPassword.Size = new System.Drawing.Size(230, 1);
            this.panelDelitelPassword.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(78, 198);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // panelDelitelLogin
            // 
            this.panelDelitelLogin.BackColor = System.Drawing.Color.White;
            this.panelDelitelLogin.Location = new System.Drawing.Point(48, 184);
            this.panelDelitelLogin.Name = "panelDelitelLogin";
            this.panelDelitelLogin.Size = new System.Drawing.Size(230, 1);
            this.panelDelitelLogin.TabIndex = 4;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.panelDelitelConfirmRegister);
            this.panelRegister.Controls.Add(this.pictureBoxConfirmPasswordRegister);
            this.panelRegister.Controls.Add(this.textBoxConfirmPassRegister);
            this.panelRegister.Controls.Add(this.buttonRegisterExit);
            this.panelRegister.Controls.Add(this.buttonRegLogin);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.HiderPasswordRegister);
            this.panelRegister.Controls.Add(this.panelDelitelPasswordRegister);
            this.panelRegister.Controls.Add(this.pictureBoxPasswordRegister);
            this.panelRegister.Controls.Add(this.textBoxFirstPassRegister);
            this.panelRegister.Controls.Add(this.panelDelitelLoginRegister);
            this.panelRegister.Controls.Add(this.pictureBoxUsernameRegister);
            this.panelRegister.Controls.Add(this.RegisterLogotip);
            this.panelRegister.Controls.Add(this.textBoxUsnameRegister);
            this.panelRegister.Location = new System.Drawing.Point(320, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(320, 460);
            this.panelRegister.TabIndex = 8;
            this.panelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            this.panelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseMove);
            // 
            // panelDelitelConfirmRegister
            // 
            this.panelDelitelConfirmRegister.BackColor = System.Drawing.Color.White;
            this.panelDelitelConfirmRegister.Location = new System.Drawing.Point(48, 291);
            this.panelDelitelConfirmRegister.Name = "panelDelitelConfirmRegister";
            this.panelDelitelConfirmRegister.Size = new System.Drawing.Size(230, 1);
            this.panelDelitelConfirmRegister.TabIndex = 9;
            // 
            // textBoxConfirmPassRegister
            // 
            this.textBoxConfirmPassRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBoxConfirmPassRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPassRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfirmPassRegister.ForeColor = System.Drawing.Color.White;
            this.textBoxConfirmPassRegister.Location = new System.Drawing.Point(78, 254);
            this.textBoxConfirmPassRegister.MaxLength = 16;
            this.textBoxConfirmPassRegister.Name = "textBoxConfirmPassRegister";
            this.textBoxConfirmPassRegister.PasswordChar = '*';
            this.textBoxConfirmPassRegister.Size = new System.Drawing.Size(200, 22);
            this.textBoxConfirmPassRegister.TabIndex = 8;
            this.textBoxConfirmPassRegister.TabStop = false;
            this.textBoxConfirmPassRegister.Text = "Password";
            this.textBoxConfirmPassRegister.TextChanged += new System.EventHandler(this.textBoxConfirmPassRegister_TextChanged);
            this.textBoxConfirmPassRegister.Enter += new System.EventHandler(this.textBoxConfirmPassRegister_Enter);
            this.textBoxConfirmPassRegister.Leave += new System.EventHandler(this.textBoxConfirmPassRegister_Leave);
            // 
            // buttonRegisterExit
            // 
            this.buttonRegisterExit.FlatAppearance.BorderSize = 0;
            this.buttonRegisterExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.buttonRegisterExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(47)))), ((int)(((byte)(41)))));
            this.buttonRegisterExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegisterExit.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterExit.Location = new System.Drawing.Point(282, 3);
            this.buttonRegisterExit.Name = "buttonRegisterExit";
            this.buttonRegisterExit.Size = new System.Drawing.Size(35, 35);
            this.buttonRegisterExit.TabIndex = 6;
            this.buttonRegisterExit.Text = "X";
            this.buttonRegisterExit.UseVisualStyleBackColor = true;
            this.buttonRegisterExit.Click += new System.EventHandler(this.buttonRegisterExit_Click);
            // 
            // buttonRegLogin
            // 
            this.buttonRegLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.buttonRegLogin.FlatAppearance.BorderSize = 0;
            this.buttonRegLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonRegLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonRegLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegLogin.ForeColor = System.Drawing.Color.White;
            this.buttonRegLogin.Location = new System.Drawing.Point(48, 371);
            this.buttonRegLogin.Name = "buttonRegLogin";
            this.buttonRegLogin.Size = new System.Drawing.Size(230, 34);
            this.buttonRegLogin.TabIndex = 2;
            this.buttonRegLogin.Text = "Войти";
            this.buttonRegLogin.UseVisualStyleBackColor = false;
            this.buttonRegLogin.Click += new System.EventHandler(this.buttonRegLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(173)))), ((int)(((byte)(254)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(48, 319);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(230, 34);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panelDelitelPasswordRegister
            // 
            this.panelDelitelPasswordRegister.BackColor = System.Drawing.Color.White;
            this.panelDelitelPasswordRegister.Location = new System.Drawing.Point(48, 235);
            this.panelDelitelPasswordRegister.Name = "panelDelitelPasswordRegister";
            this.panelDelitelPasswordRegister.Size = new System.Drawing.Size(230, 1);
            this.panelDelitelPasswordRegister.TabIndex = 5;
            // 
            // textBoxFirstPassRegister
            // 
            this.textBoxFirstPassRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBoxFirstPassRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstPassRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstPassRegister.ForeColor = System.Drawing.Color.White;
            this.textBoxFirstPassRegister.Location = new System.Drawing.Point(78, 198);
            this.textBoxFirstPassRegister.MaxLength = 16;
            this.textBoxFirstPassRegister.Name = "textBoxFirstPassRegister";
            this.textBoxFirstPassRegister.PasswordChar = '*';
            this.textBoxFirstPassRegister.Size = new System.Drawing.Size(200, 22);
            this.textBoxFirstPassRegister.TabIndex = 3;
            this.textBoxFirstPassRegister.TabStop = false;
            this.textBoxFirstPassRegister.Text = "Password";
            this.textBoxFirstPassRegister.Enter += new System.EventHandler(this.textBoxFirstPassRegister_Enter);
            this.textBoxFirstPassRegister.Leave += new System.EventHandler(this.textBoxFirstPassRegister_Leave);
            // 
            // panelDelitelLoginRegister
            // 
            this.panelDelitelLoginRegister.BackColor = System.Drawing.Color.White;
            this.panelDelitelLoginRegister.Location = new System.Drawing.Point(48, 184);
            this.panelDelitelLoginRegister.Name = "panelDelitelLoginRegister";
            this.panelDelitelLoginRegister.Size = new System.Drawing.Size(230, 1);
            this.panelDelitelLoginRegister.TabIndex = 4;
            // 
            // textBoxUsnameRegister
            // 
            this.textBoxUsnameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBoxUsnameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsnameRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsnameRegister.ForeColor = System.Drawing.Color.White;
            this.textBoxUsnameRegister.Location = new System.Drawing.Point(78, 146);
            this.textBoxUsnameRegister.MaxLength = 16;
            this.textBoxUsnameRegister.Name = "textBoxUsnameRegister";
            this.textBoxUsnameRegister.Size = new System.Drawing.Size(200, 22);
            this.textBoxUsnameRegister.TabIndex = 2;
            this.textBoxUsnameRegister.TabStop = false;
            this.textBoxUsnameRegister.Text = "Username";
            this.textBoxUsnameRegister.Enter += new System.EventHandler(this.textBoxUsnameRegister_Enter);
            this.textBoxUsnameRegister.Leave += new System.EventHandler(this.textBoxUsnameRegister_Leave);
            // 
            // pictureBoxConfirmPasswordRegister
            // 
            this.pictureBoxConfirmPasswordRegister.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConfirmPasswordRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxConfirmPasswordRegister.BackgroundImage")));
            this.pictureBoxConfirmPasswordRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxConfirmPasswordRegister.Location = new System.Drawing.Point(48, 251);
            this.pictureBoxConfirmPasswordRegister.Name = "pictureBoxConfirmPasswordRegister";
            this.pictureBoxConfirmPasswordRegister.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxConfirmPasswordRegister.TabIndex = 10;
            this.pictureBoxConfirmPasswordRegister.TabStop = false;
            // 
            // HiderPasswordRegister
            // 
            this.HiderPasswordRegister.BackColor = System.Drawing.Color.Transparent;
            this.HiderPasswordRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HiderPasswordRegister.BackgroundImage")));
            this.HiderPasswordRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HiderPasswordRegister.Location = new System.Drawing.Point(258, 200);
            this.HiderPasswordRegister.Name = "HiderPasswordRegister";
            this.HiderPasswordRegister.Size = new System.Drawing.Size(20, 20);
            this.HiderPasswordRegister.TabIndex = 7;
            this.HiderPasswordRegister.TabStop = false;
            this.HiderPasswordRegister.Click += new System.EventHandler(this.HiderPasswordRegister_Click);
            // 
            // pictureBoxPasswordRegister
            // 
            this.pictureBoxPasswordRegister.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPasswordRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPasswordRegister.BackgroundImage")));
            this.pictureBoxPasswordRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPasswordRegister.Location = new System.Drawing.Point(48, 195);
            this.pictureBoxPasswordRegister.Name = "pictureBoxPasswordRegister";
            this.pictureBoxPasswordRegister.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPasswordRegister.TabIndex = 5;
            this.pictureBoxPasswordRegister.TabStop = false;
            // 
            // pictureBoxUsernameRegister
            // 
            this.pictureBoxUsernameRegister.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsernameRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsernameRegister.BackgroundImage")));
            this.pictureBoxUsernameRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUsernameRegister.Location = new System.Drawing.Point(48, 143);
            this.pictureBoxUsernameRegister.Name = "pictureBoxUsernameRegister";
            this.pictureBoxUsernameRegister.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxUsernameRegister.TabIndex = 1;
            this.pictureBoxUsernameRegister.TabStop = false;
            // 
            // RegisterLogotip
            // 
            this.RegisterLogotip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterLogotip.BackgroundImage")));
            this.RegisterLogotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterLogotip.Location = new System.Drawing.Point(125, 40);
            this.RegisterLogotip.Name = "RegisterLogotip";
            this.RegisterLogotip.Size = new System.Drawing.Size(65, 65);
            this.RegisterLogotip.TabIndex = 0;
            this.RegisterLogotip.TabStop = false;
            // 
            // HiderPassword
            // 
            this.HiderPassword.BackColor = System.Drawing.Color.Transparent;
            this.HiderPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HiderPassword.BackgroundImage")));
            this.HiderPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HiderPassword.Location = new System.Drawing.Point(258, 200);
            this.HiderPassword.Name = "HiderPassword";
            this.HiderPassword.Size = new System.Drawing.Size(20, 20);
            this.HiderPassword.TabIndex = 7;
            this.HiderPassword.TabStop = false;
            this.HiderPassword.Click += new System.EventHandler(this.HiderPassword_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.BackgroundImage")));
            this.pictureBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPassword.Location = new System.Drawing.Point(48, 195);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPassword.TabIndex = 5;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.BackgroundImage")));
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogin.Location = new System.Drawing.Point(48, 143);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // loginLogotip
            // 
            this.loginLogotip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginLogotip.BackgroundImage")));
            this.loginLogotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginLogotip.Location = new System.Drawing.Point(125, 40);
            this.loginLogotip.Name = "loginLogotip";
            this.loginLogotip.Size = new System.Drawing.Size(65, 65);
            this.loginLogotip.TabIndex = 0;
            this.loginLogotip.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(620, 860);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirmPasswordRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiderPasswordRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsernameRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterLogotip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogotip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loginLogotip;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Panel panelDelitelLogin;
        private System.Windows.Forms.Panel panelDelitelPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox HiderPassword;
        public System.Windows.Forms.Panel panelLogin;
        private Button buttonLoginExit;
        public Panel panelRegister;
        private Panel panelDelitelConfirmRegister;
        private PictureBox pictureBoxConfirmPasswordRegister;
        private TextBox textBoxConfirmPassRegister;
        private Button buttonRegisterExit;
        private Button buttonRegLogin;
        private Button buttonRegister;
        private PictureBox HiderPasswordRegister;
        private Panel panelDelitelPasswordRegister;
        private PictureBox pictureBoxPasswordRegister;
        private TextBox textBoxFirstPassRegister;
        private Panel panelDelitelLoginRegister;
        private PictureBox pictureBoxUsernameRegister;
        private PictureBox RegisterLogotip;
        private TextBox textBoxUsnameRegister;
    }
}

