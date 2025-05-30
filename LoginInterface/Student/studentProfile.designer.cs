namespace LoginInterface
{
    partial class studentProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentProfile));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.pnlSubject = new System.Windows.Forms.Panel();
            this.lblSubject1 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.picFemale = new System.Windows.Forms.PictureBox();
            this.picMale = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMale)).BeginInit();
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
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(130, 800);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Snow;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSetting.IconColor = System.Drawing.Color.Snow;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.Location = new System.Drawing.Point(0, 325);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(130, 65);
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
            this.btnRequest.Location = new System.Drawing.Point(0, 260);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(130, 65);
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
            this.btnTimetable.Location = new System.Drawing.Point(0, 195);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(130, 65);
            this.btnTimetable.TabIndex = 3;
            this.btnTimetable.Tag = "Timetable   ";
            this.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Blue;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Snow;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.btnProfile.IconColor = System.Drawing.Color.Snow;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.Location = new System.Drawing.Point(0, 130);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(130, 65);
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
            this.btnHome.Location = new System.Drawing.Point(0, 735);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 65);
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
            this.pnlFolder.Name = "pnlFolder";
            this.pnlFolder.Size = new System.Drawing.Size(130, 130);
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
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 130);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 130);
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
            this.pnlDashboard.Location = new System.Drawing.Point(130, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1070, 62);
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
            this.lblTitle.Size = new System.Drawing.Size(199, 59);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "PROFILE";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(920, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 40);
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
            this.btnMaximize.Location = new System.Drawing.Point(970, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(1020, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlContent.Controls.Add(this.picFemale);
            this.pnlContent.Controls.Add(this.picMale);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.pnlSubject);
            this.pnlContent.Controls.Add(this.lblStudentID);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.picAvatar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(130, 62);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1070, 738);
            this.pnlContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblContactNumber);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.lblProfile);
            this.panel1.Location = new System.Drawing.Point(50, 300);
            this.panel1.MaximumSize = new System.Drawing.Size(600, 400);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Snow;
            this.lblEmail.Location = new System.Drawing.Point(0, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(500, 45);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "123";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContactNumber.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblContactNumber.ForeColor = System.Drawing.Color.Snow;
            this.lblContactNumber.Location = new System.Drawing.Point(0, 135);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(500, 45);
            this.lblContactNumber.TabIndex = 7;
            this.lblContactNumber.Text = "123";
            this.lblContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.Snow;
            this.lblGender.Location = new System.Drawing.Point(0, 90);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(500, 45);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "123";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLevel
            // 
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLevel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.Color.Snow;
            this.lblLevel.Location = new System.Drawing.Point(0, 45);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(500, 45);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "123";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfile.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblProfile.ForeColor = System.Drawing.Color.Snow;
            this.lblProfile.Location = new System.Drawing.Point(0, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(500, 45);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Profile";
            // 
            // pnlSubject
            // 
            this.pnlSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSubject.AutoSize = true;
            this.pnlSubject.Controls.Add(this.lblSubject1);
            this.pnlSubject.Controls.Add(this.lblSubject);
            this.pnlSubject.Location = new System.Drawing.Point(600, 300);
            this.pnlSubject.MaximumSize = new System.Drawing.Size(520, 400);
            this.pnlSubject.MinimumSize = new System.Drawing.Size(420, 300);
            this.pnlSubject.Name = "pnlSubject";
            this.pnlSubject.Size = new System.Drawing.Size(420, 300);
            this.pnlSubject.TabIndex = 8;
            // 
            // lblSubject1
            // 
            this.lblSubject1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubject1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblSubject1.ForeColor = System.Drawing.Color.Snow;
            this.lblSubject1.Location = new System.Drawing.Point(0, 45);
            this.lblSubject1.Name = "lblSubject1";
            this.lblSubject1.Size = new System.Drawing.Size(420, 211);
            this.lblSubject1.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubject.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.Color.Snow;
            this.lblSubject.Location = new System.Drawing.Point(0, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(420, 45);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = System.Drawing.Color.Snow;
            this.lblStudentID.Location = new System.Drawing.Point(300, 198);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(226, 47);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "StudentID: ";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Snow;
            this.lblName.Location = new System.Drawing.Point(300, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 47);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(50, 50);
            this.picAvatar.MaximumSize = new System.Drawing.Size(300, 300);
            this.picAvatar.MinimumSize = new System.Drawing.Size(200, 200);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(200, 200);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            // 
            // picFemale
            // 
            this.picFemale.Image = ((System.Drawing.Image)(resources.GetObject("picFemale.Image")));
            this.picFemale.Location = new System.Drawing.Point(829, 94);
            this.picFemale.Name = "picFemale";
            this.picFemale.Size = new System.Drawing.Size(100, 50);
            this.picFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFemale.TabIndex = 7;
            this.picFemale.TabStop = false;
            this.picFemale.Visible = false;
            // 
            // picMale
            // 
            this.picMale.Image = ((System.Drawing.Image)(resources.GetObject("picMale.Image")));
            this.picMale.Location = new System.Drawing.Point(829, 159);
            this.picMale.Name = "picMale";
            this.picMale.Size = new System.Drawing.Size(100, 50);
            this.picMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMale.TabIndex = 8;
            this.picMale.TabStop = false;
            this.picMale.Visible = false;
            // 
            // studentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentProfile";
            this.pnlMenu.ResumeLayout(false);
            this.pnlFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMale)).EndInit();
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
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel pnlSubject;
        private System.Windows.Forms.Label lblSubject1;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picFemale;
        private System.Windows.Forms.PictureBox picMale;
    }
}