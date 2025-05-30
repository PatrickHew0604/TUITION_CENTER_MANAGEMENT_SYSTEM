namespace LoginInterface
{
    partial class studentSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentSetting));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnRequest = new FontAwesome.Sharp.IconButton();
            this.btnTimetable = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlFolder = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEditProfile = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.pnlFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnRequest);
            this.pnlMenu.Controls.Add(this.btnTimetable);
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlFolder);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(116, 640);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Blue;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Snow;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSetting.IconColor = System.Drawing.Color.Snow;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.Location = new System.Drawing.Point(0, 260);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(116, 52);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Tag = "Settings   ";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.Snow;
            this.btnRequest.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.btnRequest.IconColor = System.Drawing.Color.Snow;
            this.btnRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRequest.Location = new System.Drawing.Point(0, 208);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(116, 52);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Tag = "Request   ";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetable.ForeColor = System.Drawing.Color.Snow;
            this.btnTimetable.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnTimetable.IconColor = System.Drawing.Color.Snow;
            this.btnTimetable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimetable.Location = new System.Drawing.Point(0, 156);
            this.btnTimetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(116, 52);
            this.btnTimetable.TabIndex = 3;
            this.btnTimetable.Tag = "Timetable   ";
            this.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Snow;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.btnProfile.IconColor = System.Drawing.Color.Snow;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.Location = new System.Drawing.Point(0, 104);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(116, 52);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Tag = "Profile   ";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Snow;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(0, 588);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 52);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Home   ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlFolder
            // 
            this.pnlFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnlFolder.Controls.Add(this.btnMenu);
            this.pnlFolder.Controls.Add(this.picLogo);
            this.pnlFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFolder.Location = new System.Drawing.Point(0, 0);
            this.pnlFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFolder.Name = "pnlFolder";
            this.pnlFolder.Size = new System.Drawing.Size(116, 104);
            this.pnlFolder.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnMenu.IconColor = System.Drawing.Color.Snow;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 60;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 104);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(116, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Black;
            this.pnlDashboard.Controls.Add(this.lblTitle);
            this.pnlDashboard.Controls.Add(this.btnMinimize);
            this.pnlDashboard.Controls.Add(this.btnMaximize);
            this.pnlDashboard.Controls.Add(this.btnClose);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(116, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(951, 50);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDashboard_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 49);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "SETTING";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(818, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 32);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(862, 10);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 32);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(907, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlContent.Controls.Add(this.btnPassword);
            this.pnlContent.Controls.Add(this.label9);
            this.pnlContent.Controls.Add(this.label8);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.label7);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.txtPassword);
            this.pnlContent.Controls.Add(this.txtUsername);
            this.pnlContent.Controls.Add(this.txtContactNumber);
            this.pnlContent.Controls.Add(this.txtEmail);
            this.pnlContent.Controls.Add(this.txtLevel);
            this.pnlContent.Controls.Add(this.txtIC);
            this.pnlContent.Controls.Add(this.txtGender);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.btnEditProfile);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(116, 50);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(951, 590);
            this.pnlContent.TabIndex = 2;
            // 
            // btnPassword
            // 
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnPassword.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPassword.IconSize = 60;
            this.btnPassword.Location = new System.Drawing.Point(583, 99);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(52, 47);
            this.btnPassword.TabIndex = 5;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(40, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 52);
            this.label9.TabIndex = 4;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(40, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 52);
            this.label8.TabIndex = 4;
            this.label8.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(40, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 52);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(40, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 52);
            this.label7.TabIndex = 4;
            this.label7.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(40, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 52);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(40, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "IC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(40, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(267, 99);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(312, 50);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(267, 34);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(312, 50);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(267, 423);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(312, 50);
            this.txtContactNumber.TabIndex = 3;
            this.txtContactNumber.Enter += new System.EventHandler(this.txtContactNumber_Enter);
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            this.txtContactNumber.Leave += new System.EventHandler(this.txtContactNumber_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(267, 488);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 50);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(267, 294);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(312, 50);
            this.txtLevel.TabIndex = 3;
            // 
            // txtIC
            // 
            this.txtIC.Enabled = false;
            this.txtIC.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIC.Location = new System.Drawing.Point(267, 358);
            this.txtIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIC.Name = "txtIC";
            this.txtIC.ReadOnly = true;
            this.txtIC.Size = new System.Drawing.Size(312, 50);
            this.txtIC.TabIndex = 1;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(267, 229);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(312, 50);
            this.txtGender.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(267, 164);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(312, 50);
            this.txtName.TabIndex = 1;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProfile.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditProfile.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProfile.IconSize = 120;
            this.btnEditProfile.Location = new System.Drawing.Point(721, 374);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(178, 160);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "EDIT PROFILE";
            this.btnEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // studentSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 640);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "studentSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentSetting";
            this.Load += new System.EventHandler(this.studentSetting_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlFolder;
        private System.Windows.Forms.Panel pnlDashboard;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnRequest;
        private FontAwesome.Sharp.IconButton btnTimetable;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnEditProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconButton btnPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
    }
}