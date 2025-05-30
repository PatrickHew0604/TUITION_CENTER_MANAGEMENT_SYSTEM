namespace LoginInterface
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHomePage = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnIncome = new FontAwesome.Sharp.IconButton();
            this.btnReceptionist = new FontAwesome.Sharp.IconButton();
            this.btnTutor = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClosed = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.cmbSubject = new CustomBox.RJControls.RJComboBox();
            this.cmbLevel = new CustomBox.RJControls.RJComboBox();
            this.cmbMonth = new CustomBox.RJControls.RJComboBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.picMoney = new System.Windows.Forms.PictureBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlMenu.Controls.Add(this.btnHomePage);
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Controls.Add(this.btnIncome);
            this.pnlMenu.Controls.Add(this.btnReceptionist);
            this.pnlMenu.Controls.Add(this.btnTutor);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(116, 486);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnHomePage.IconColor = System.Drawing.Color.White;
            this.btnHomePage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHomePage.Location = new System.Drawing.Point(0, 403);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(116, 83);
            this.btnHomePage.TabIndex = 14;
            this.btnHomePage.Tag = "Home Page";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.Location = new System.Drawing.Point(0, 282);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(116, 55);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Tag = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.Blue;
            this.btnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnIncome.IconColor = System.Drawing.Color.White;
            this.btnIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncome.Location = new System.Drawing.Point(0, 227);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(116, 55);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Tag = "Income";
            this.btnIncome.UseVisualStyleBackColor = false;
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceptionist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceptionist.FlatAppearance.BorderSize = 0;
            this.btnReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceptionist.ForeColor = System.Drawing.Color.White;
            this.btnReceptionist.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.btnReceptionist.IconColor = System.Drawing.Color.White;
            this.btnReceptionist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceptionist.Location = new System.Drawing.Point(0, 172);
            this.btnReceptionist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(116, 55);
            this.btnReceptionist.TabIndex = 2;
            this.btnReceptionist.Tag = "Receptionist";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTutor.FlatAppearance.BorderSize = 0;
            this.btnTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutor.ForeColor = System.Drawing.Color.White;
            this.btnTutor.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnTutor.IconColor = System.Drawing.Color.White;
            this.btnTutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTutor.Location = new System.Drawing.Point(0, 117);
            this.btnTutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(116, 55);
            this.btnTutor.TabIndex = 1;
            this.btnTutor.Tag = "Tutor";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 117);
            this.panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 117);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 10);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Black;
            this.pnlDashboard.Controls.Add(this.btnMinimize);
            this.pnlDashboard.Controls.Add(this.btnMaximize);
            this.pnlDashboard.Controls.Add(this.btnClosed);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(116, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(942, 50);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDashboard_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(798, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(844, 10);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 35);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosed.BackColor = System.Drawing.Color.LightCoral;
            this.btnClosed.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnClosed.IconColor = System.Drawing.Color.Black;
            this.btnClosed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClosed.Location = new System.Drawing.Point(891, 10);
            this.btnClosed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(41, 35);
            this.btnClosed.TabIndex = 0;
            this.btnClosed.UseVisualStyleBackColor = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlContent.Controls.Add(this.cmbSubject);
            this.pnlContent.Controls.Add(this.cmbLevel);
            this.pnlContent.Controls.Add(this.cmbMonth);
            this.pnlContent.Controls.Add(this.picSearch);
            this.pnlContent.Controls.Add(this.grpReport);
            this.pnlContent.Controls.Add(this.lblLevel);
            this.pnlContent.Controls.Add(this.lblSubject);
            this.pnlContent.Controls.Add(this.lblMonth);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(116, 50);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(942, 436);
            this.pnlContent.TabIndex = 2;
            // 
            // cmbSubject
            // 
            this.cmbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSubject.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbSubject.BorderSize = 1;
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSubject.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSubject.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbSubject.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSubject.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSubject.Location = new System.Drawing.Point(661, 42);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubject.MinimumSize = new System.Drawing.Size(178, 24);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Padding = new System.Windows.Forms.Padding(1);
            this.cmbSubject.Size = new System.Drawing.Size(178, 25);
            this.cmbSubject.TabIndex = 78;
            this.cmbSubject.Texts = "";
            // 
            // cmbLevel
            // 
            this.cmbLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLevel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbLevel.BorderSize = 1;
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbLevel.ForeColor = System.Drawing.Color.DimGray;
            this.cmbLevel.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbLevel.Items.AddRange(new object[] {
            "Form1",
            "Form2",
            "Form3",
            "Form4",
            "Form5"});
            this.cmbLevel.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbLevel.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbLevel.Location = new System.Drawing.Point(372, 42);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLevel.MinimumSize = new System.Drawing.Size(178, 24);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Padding = new System.Windows.Forms.Padding(1);
            this.cmbLevel.Size = new System.Drawing.Size(178, 25);
            this.cmbLevel.TabIndex = 78;
            this.cmbLevel.Texts = "";
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMonth.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbMonth.BorderSize = 1;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMonth.ForeColor = System.Drawing.Color.DimGray;
            this.cmbMonth.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octorber",
            "November",
            "December"});
            this.cmbMonth.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbMonth.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbMonth.Location = new System.Drawing.Point(92, 42);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonth.MinimumSize = new System.Drawing.Size(178, 24);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Padding = new System.Windows.Forms.Padding(1);
            this.cmbMonth.Size = new System.Drawing.Size(178, 25);
            this.cmbMonth.TabIndex = 78;
            this.cmbMonth.Texts = "";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(861, 41);
            this.picSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(31, 32);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 77;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // grpReport
            // 
            this.grpReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReport.Controls.Add(this.picMoney);
            this.grpReport.Controls.Add(this.lblMoney);
            this.grpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReport.ForeColor = System.Drawing.Color.White;
            this.grpReport.Location = new System.Drawing.Point(134, 122);
            this.grpReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReport.Size = new System.Drawing.Size(642, 270);
            this.grpReport.TabIndex = 8;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Month Level Subject";
            // 
            // picMoney
            // 
            this.picMoney.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picMoney.Image = ((System.Drawing.Image)(resources.GetObject("picMoney.Image")));
            this.picMoney.Location = new System.Drawing.Point(103, 61);
            this.picMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMoney.Name = "picMoney";
            this.picMoney.Size = new System.Drawing.Size(134, 116);
            this.picMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMoney.TabIndex = 7;
            this.picMoney.TabStop = false;
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(372, 96);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(160, 51);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "Income";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(298, 45);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(66, 22);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level:";
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.White;
            this.lblSubject.Location = new System.Drawing.Point(570, 44);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(82, 22);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject:";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(8, 45);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(75, 22);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 486);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconButton btnClosed;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnTutor;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnIncome;
        private FontAwesome.Sharp.IconButton btnReceptionist;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Label lblMoney;
        private CustomBox.RJControls.RJComboBox cmbSubject;
        private CustomBox.RJControls.RJComboBox cmbLevel;
        private CustomBox.RJControls.RJComboBox cmbMonth;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.PictureBox picMoney;
        private FontAwesome.Sharp.IconButton btnHomePage;
    }
}