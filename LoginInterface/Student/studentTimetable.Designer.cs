namespace LoginInterface
{
    partial class studentTimetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentTimetable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.getclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionManagementSystemDataSet2 = new LoginInterface.TuitionManagementSystemDataSet2();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getclassTableAdapter = new LoginInterface.TuitionManagementSystemDataSet2TableAdapters.getclassTableAdapter();
            this.studentidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.startingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.pnlFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).BeginInit();
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
            this.btnTimetable.BackColor = System.Drawing.Color.Blue;
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
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 49);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "TIMETABLE";
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
            this.pnlContent.Controls.Add(this.dgvTimetable);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(116, 50);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(951, 590);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AllowUserToAddRows = false;
            this.dgvTimetable.AllowUserToDeleteRows = false;
            this.dgvTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimetable.AutoGenerateColumns = false;
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimetable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dgvTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimetable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn1,
            this.dayofweekDataGridViewTextBoxColumn,
            this.classnameDataGridViewButtonColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.staffidDataGridViewTextBoxColumn,
            this.tutorDataGridViewButtonColumn,
            this.startingtimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dgvTimetable.DataSource = this.getclassBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimetable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimetable.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvTimetable.Location = new System.Drawing.Point(27, 24);
            this.dgvTimetable.Margin = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersWidth = 62;
            this.dgvTimetable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTimetable.RowTemplate.Height = 28;
            this.dgvTimetable.Size = new System.Drawing.Size(898, 542);
            this.dgvTimetable.TabIndex = 0;
            this.dgvTimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetable_CellContentClick);
            // 
            // getclassBindingSource
            // 
            this.getclassBindingSource.DataMember = "getclass";
            this.getclassBindingSource.DataSource = this.tuitionManagementSystemDataSet2;
            // 
            // tuitionManagementSystemDataSet2
            // 
            this.tuitionManagementSystemDataSet2.DataSetName = "TuitionManagementSystemDataSet2";
            this.tuitionManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 513;
            // 
            // tutor_id
            // 
            this.tutor_id.DataPropertyName = "tutor_id";
            this.tutor_id.HeaderText = "tutor_id";
            this.tutor_id.MinimumWidth = 8;
            this.tutor_id.Name = "tutor_id";
            this.tutor_id.ReadOnly = true;
            this.tutor_id.Width = 150;
            // 
            // day
            // 
            this.day.DataPropertyName = "day";
            this.day.HeaderText = "Day";
            this.day.MinimumWidth = 8;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 150;
            // 
            // getclassTableAdapter
            // 
            this.getclassTableAdapter.ClearBeforeFill = true;
            // 
            // studentidDataGridViewTextBoxColumn1
            // 
            this.studentidDataGridViewTextBoxColumn1.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn1.HeaderText = "STUDENTID";
            this.studentidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn1.Name = "studentidDataGridViewTextBoxColumn1";
            this.studentidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.studentidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dayofweekDataGridViewTextBoxColumn
            // 
            this.dayofweekDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dayofweekDataGridViewTextBoxColumn.DataPropertyName = "day_of_week";
            this.dayofweekDataGridViewTextBoxColumn.FillWeight = 70F;
            this.dayofweekDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayofweekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayofweekDataGridViewTextBoxColumn.Name = "dayofweekDataGridViewTextBoxColumn";
            this.dayofweekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classnameDataGridViewButtonColumn
            // 
            this.classnameDataGridViewButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classnameDataGridViewButtonColumn.DataPropertyName = "class_name";
            this.classnameDataGridViewButtonColumn.FillWeight = 180F;
            this.classnameDataGridViewButtonColumn.HeaderText = "Classname";
            this.classnameDataGridViewButtonColumn.MinimumWidth = 6;
            this.classnameDataGridViewButtonColumn.Name = "classnameDataGridViewButtonColumn";
            this.classnameDataGridViewButtonColumn.ReadOnly = true;
            this.classnameDataGridViewButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.classnameDataGridViewButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tutorDataGridViewButtonColumn
            // 
            this.tutorDataGridViewButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tutorDataGridViewButtonColumn.DataPropertyName = "tutor";
            this.tutorDataGridViewButtonColumn.HeaderText = "Tutor";
            this.tutorDataGridViewButtonColumn.MinimumWidth = 6;
            this.tutorDataGridViewButtonColumn.Name = "tutorDataGridViewButtonColumn";
            this.tutorDataGridViewButtonColumn.ReadOnly = true;
            this.tutorDataGridViewButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tutorDataGridViewButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // startingtimeDataGridViewTextBoxColumn
            // 
            this.startingtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startingtimeDataGridViewTextBoxColumn.DataPropertyName = "starting_time";
            this.startingtimeDataGridViewTextBoxColumn.FillWeight = 80F;
            this.startingtimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.startingtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingtimeDataGridViewTextBoxColumn.Name = "startingtimeDataGridViewTextBoxColumn";
            this.startingtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.FillWeight = 80F;
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentTimetable
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
            this.Name = "studentTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentTimetable";
            this.Load += new System.EventHandler(this.studentTimetable_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridView dgvTimetable;
 //       private c_assignmentDataSetTableAdapters.student_classTableAdapter student_classTableAdapter;
        private System.Windows.Forms.Label lblTitle;
        private TuitionManagementSystemDataSet2 tuitionManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource getclassBindingSource;
        private TuitionManagementSystemDataSet2TableAdapters.getclassTableAdapter getclassTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn classnameDataGridViewButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn tutorDataGridViewButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}