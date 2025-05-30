namespace LoginInterface
{
    partial class RequestDBView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestDBView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDisallowed = new FontAwesome.Sharp.IconButton();
            this.btnAllow = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgvStudentSubs = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentsubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedsubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionManagementSystemDataSet2 = new LoginInterface.TuitionManagementSystemDataSet2();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.request_listTableAdapter = new LoginInterface.TuitionManagementSystemDataSet2TableAdapters.request_listTableAdapter();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("AR DELANEY", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Universe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Black;
            this.pnlDashboard.Controls.Add(this.label1);
            this.pnlDashboard.Controls.Add(this.label2);
            this.pnlDashboard.Controls.Add(this.btnClose);
            this.pnlDashboard.Controls.Add(this.btnMaximize);
            this.pnlDashboard.Controls.Add(this.btnMinimize);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.ForeColor = System.Drawing.Color.Crimson;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1414, 62);
            this.pnlDashboard.TabIndex = 7;
            this.pnlDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDashboard_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("AR DELANEY", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = " TC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(1361, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(1314, 9);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 40);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(1267, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlContent.Controls.Add(this.btnRefresh);
            this.pnlContent.Controls.Add(this.pictureBox9);
            this.pnlContent.Controls.Add(this.lbltitle);
            this.pnlContent.Controls.Add(this.btnClear);
            this.pnlContent.Controls.Add(this.btnDisallowed);
            this.pnlContent.Controls.Add(this.btnAllow);
            this.pnlContent.Controls.Add(this.panel3);
            this.pnlContent.Controls.Add(this.txtUsername);
            this.pnlContent.Controls.Add(this.pictureBox4);
            this.pnlContent.Controls.Add(this.dgvStudentSubs);
            this.pnlContent.Controls.Add(this.btnSearch);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.ForeColor = System.Drawing.Color.White;
            this.pnlContent.Location = new System.Drawing.Point(0, 62);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1414, 848);
            this.pnlContent.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(109, 731);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(231, 71);
            this.btnRefresh.TabIndex = 90;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(473, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(81, 70);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 89;
            this.pictureBox9.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltitle.AutoSize = true;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitle.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(560, 29);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(399, 55);
            this.lbltitle.TabIndex = 88;
            this.lbltitle.Text = "Student Request";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(396, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 40);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDisallowed
            // 
            this.btnDisallowed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisallowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDisallowed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisallowed.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisallowed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisallowed.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDisallowed.IconColor = System.Drawing.Color.Black;
            this.btnDisallowed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisallowed.Location = new System.Drawing.Point(751, 731);
            this.btnDisallowed.Name = "btnDisallowed";
            this.btnDisallowed.Size = new System.Drawing.Size(208, 71);
            this.btnDisallowed.TabIndex = 72;
            this.btnDisallowed.Text = "Deny";
            this.btnDisallowed.UseVisualStyleBackColor = false;
            this.btnDisallowed.Click += new System.EventHandler(this.btnDisallowed_Click);
            // 
            // btnAllow
            // 
            this.btnAllow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAllow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllow.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAllow.IconColor = System.Drawing.Color.Black;
            this.btnAllow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllow.Location = new System.Drawing.Point(1077, 731);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.Size = new System.Drawing.Size(231, 71);
            this.btnAllow.TabIndex = 71;
            this.btnAllow.Text = "Allow";
            this.btnAllow.UseVisualStyleBackColor = false;
            this.btnAllow.Click += new System.EventHandler(this.btnAllow_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(109, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 1);
            this.panel3.TabIndex = 65;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Location = new System.Drawing.Point(188, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(303, 48);
            this.txtUsername.TabIndex = 66;
            this.txtUsername.Tag = "Username";
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(109, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // dgvStudentSubs
            // 
            this.dgvStudentSubs.AllowUserToAddRows = false;
            this.dgvStudentSubs.AllowUserToDeleteRows = false;
            this.dgvStudentSubs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudentSubs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentSubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentSubs.AutoGenerateColumns = false;
            this.dgvStudentSubs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgvStudentSubs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentSubs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStudentSubs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentSubs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentSubs.ColumnHeadersHeight = 70;
            this.dgvStudentSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudentSubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.currentsubjectDataGridViewTextBoxColumn,
            this.changedsubjectDataGridViewTextBoxColumn,
            this.subjectlevelDataGridViewTextBoxColumn});
            this.dgvStudentSubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvStudentSubs.DataSource = this.requestlistBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentSubs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentSubs.EnableHeadersVisualStyles = false;
            this.dgvStudentSubs.Location = new System.Drawing.Point(110, 269);
            this.dgvStudentSubs.Name = "dgvStudentSubs";
            this.dgvStudentSubs.ReadOnly = true;
            this.dgvStudentSubs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentSubs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentSubs.RowHeadersVisible = false;
            this.dgvStudentSubs.RowHeadersWidth = 80;
            this.dgvStudentSubs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudentSubs.RowTemplate.Height = 45;
            this.dgvStudentSubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentSubs.Size = new System.Drawing.Size(1198, 414);
            this.dgvStudentSubs.TabIndex = 2;
            this.dgvStudentSubs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentSubs_CellClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentsubjectDataGridViewTextBoxColumn
            // 
            this.currentsubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currentsubjectDataGridViewTextBoxColumn.DataPropertyName = "current_subject";
            this.currentsubjectDataGridViewTextBoxColumn.HeaderText = "Chosen Subject";
            this.currentsubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentsubjectDataGridViewTextBoxColumn.Name = "currentsubjectDataGridViewTextBoxColumn";
            this.currentsubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changedsubjectDataGridViewTextBoxColumn
            // 
            this.changedsubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changedsubjectDataGridViewTextBoxColumn.DataPropertyName = "changed_subject";
            this.changedsubjectDataGridViewTextBoxColumn.HeaderText = "Changed Subject";
            this.changedsubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedsubjectDataGridViewTextBoxColumn.Name = "changedsubjectDataGridViewTextBoxColumn";
            this.changedsubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectlevelDataGridViewTextBoxColumn
            // 
            this.subjectlevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.subjectlevelDataGridViewTextBoxColumn.DataPropertyName = "subject_level";
            this.subjectlevelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.subjectlevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectlevelDataGridViewTextBoxColumn.Name = "subjectlevelDataGridViewTextBoxColumn";
            this.subjectlevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectlevelDataGridViewTextBoxColumn.Width = 93;
            // 
            // requestlistBindingSource
            // 
            this.requestlistBindingSource.DataMember = "request_list";
            this.requestlistBindingSource.DataSource = this.tuitionManagementSystemDataSet2;
            // 
            // tuitionManagementSystemDataSet2
            // 
            this.tuitionManagementSystemDataSet2.DataSetName = "TuitionManagementSystemDataSet2";
            this.tuitionManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(492, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // request_listTableAdapter
            // 
            this.request_listTableAdapter.ClearBeforeFill = true;
            // 
            // RequestDBView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 910);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestDBView";
            this.Text = "RequestDBView";
            this.Load += new System.EventHandler(this.RequestDBView_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbltitle;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDisallowed;
        private FontAwesome.Sharp.IconButton btnAllow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dgvStudentSubs;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TuitionManagementSystemDataSet2 tuitionManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource requestlistBindingSource;
        private TuitionManagementSystemDataSet2TableAdapters.request_listTableAdapter request_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectlevelDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnRefresh;
    }
}