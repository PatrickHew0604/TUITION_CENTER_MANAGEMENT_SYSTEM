namespace LoginInterface
{
    partial class studentShowClassNamelist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentShowClassNamelist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvShowClassNamelist = new System.Windows.Forms.DataGridView();
            this.classnamelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionManagementSystemDataSet2 = new LoginInterface.TuitionManagementSystemDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblT_Name = new System.Windows.Forms.Label();
            this.lblT_Email = new System.Windows.Forms.Label();
            this.lblT_ContactNumber = new System.Windows.Forms.Label();
            this.studentNamelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.pnlFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClassNamelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classnamelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNamelistBindingSource)).BeginInit();
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
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
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
            this.btnProfile.BackColor = System.Drawing.Color.Blue;
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
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblTitle.Location = new System.Drawing.Point(-1, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 49);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "NAMELIST";
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
            this.pnlContent.Controls.Add(this.dgvShowClassNamelist);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(116, 50);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(951, 590);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvShowClassNamelist
            // 
            this.dgvShowClassNamelist.AllowUserToAddRows = false;
            this.dgvShowClassNamelist.AllowUserToDeleteRows = false;
            this.dgvShowClassNamelist.AllowUserToResizeColumns = false;
            this.dgvShowClassNamelist.AllowUserToResizeRows = false;
            this.dgvShowClassNamelist.AutoGenerateColumns = false;
            this.dgvShowClassNamelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowClassNamelist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowClassNamelist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowClassNamelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowClassNamelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowClassNamelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classidDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn});
            this.dgvShowClassNamelist.DataSource = this.classnamelistBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowClassNamelist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowClassNamelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowClassNamelist.Location = new System.Drawing.Point(0, 48);
            this.dgvShowClassNamelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowClassNamelist.Name = "dgvShowClassNamelist";
            this.dgvShowClassNamelist.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowClassNamelist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowClassNamelist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvShowClassNamelist.RowTemplate.Height = 50;
            this.dgvShowClassNamelist.RowTemplate.ReadOnly = true;
            this.dgvShowClassNamelist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowClassNamelist.Size = new System.Drawing.Size(951, 542);
            this.dgvShowClassNamelist.TabIndex = 3;
            // 
            // classnamelistBindingSource
            // 
            this.classnamelistBindingSource.DataMember = "class_namelist";
            this.classnamelistBindingSource.DataSource = this.tuitionManagementSystemDataSet2;
            // 
            // tuitionManagementSystemDataSet2
            // 
            this.tuitionManagementSystemDataSet2.DataSetName = "TuitionManagementSystemDataSet2";
            this.tuitionManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblT_Name);
            this.panel1.Controls.Add(this.lblT_Email);
            this.panel1.Controls.Add(this.lblT_ContactNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 48);
            this.panel1.TabIndex = 2;
            // 
            // lblT_Name
            // 
            this.lblT_Name.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblT_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblT_Name.Location = new System.Drawing.Point(3, 0);
            this.lblT_Name.Name = "lblT_Name";
            this.lblT_Name.Size = new System.Drawing.Size(267, 48);
            this.lblT_Name.TabIndex = 1;
            this.lblT_Name.Text = "label1";
            // 
            // lblT_Email
            // 
            this.lblT_Email.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblT_Email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblT_Email.Location = new System.Drawing.Point(578, 0);
            this.lblT_Email.Name = "lblT_Email";
            this.lblT_Email.Size = new System.Drawing.Size(356, 48);
            this.lblT_Email.TabIndex = 1;
            this.lblT_Email.Text = "label1";
            // 
            // lblT_ContactNumber
            // 
            this.lblT_ContactNumber.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblT_ContactNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblT_ContactNumber.Location = new System.Drawing.Point(267, 0);
            this.lblT_ContactNumber.Name = "lblT_ContactNumber";
            this.lblT_ContactNumber.Size = new System.Drawing.Size(311, 48);
            this.lblT_ContactNumber.TabIndex = 1;
            this.lblT_ContactNumber.Text = "label1";
            // 
            // studentNamelistBindingSource
            // 
            this.studentNamelistBindingSource.DataMember = "StudentNamelist";
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.ReadOnly = true;
            this.classidDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentShowClassNamelist
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
            this.Name = "studentShowClassNamelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentShowCLassNamelist";
            this.Load += new System.EventHandler(this.studentShowClassNamelist_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClassNamelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classnamelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentNamelistBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblT_Name;
        private System.Windows.Forms.Label lblT_Email;
        private System.Windows.Forms.Label lblT_ContactNumber;
        private System.Windows.Forms.DataGridView dgvShowClassNamelist;
        private System.Windows.Forms.Panel panel1;
 //       private c_assignmentDataSetTableAdapters.student_classTableAdapter student_classTableAdapter;
        private System.Windows.Forms.BindingSource studentNamelistBindingSource;
//        private c_assignmentDataSet c_assignmentDataSet1;
//        private c_assignmentDataSetTableAdapters.StudentNamelistTableAdapter studentNamelistTableAdapter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource classnamelistBindingSource;
        private TuitionManagementSystemDataSet2 tuitionManagementSystemDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
    }
}