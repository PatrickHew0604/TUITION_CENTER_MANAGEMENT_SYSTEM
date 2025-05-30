namespace LoginInterface
{
    partial class ClassInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassInformation));
            this.dgvClassInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feepermonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionManagementSystemDataSet2 = new LoginInterface.TuitionManagementSystemDataSet2();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new RJCodeAdvance.RJControls.RJButton();
            this.txt_Search = new RJCodeAdvance.RJControls.RJTextBox();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.btnShowAll = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.pnl_DashBoard = new System.Windows.Forms.Panel();
            this.btn_Closed = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.cassignmentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new LoginInterface.TuitionManagementSystemDataSet2TableAdapters.classTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.pnl_DashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cassignmentDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassInfo
            // 
            this.dgvClassInfo.AllowUserToAddRows = false;
            this.dgvClassInfo.AllowUserToDeleteRows = false;
            this.dgvClassInfo.AllowUserToResizeRows = false;
            this.dgvClassInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClassInfo.AutoGenerateColumns = false;
            this.dgvClassInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgvClassInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClassInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvClassInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(21)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassInfo.ColumnHeadersHeight = 70;
            this.dgvClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClassInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.feepermonthDataGridViewTextBoxColumn});
            this.dgvClassInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvClassInfo.DataSource = this.classBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(21)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassInfo.EnableHeadersVisualStyles = false;
            this.dgvClassInfo.Location = new System.Drawing.Point(133, 367);
            this.dgvClassInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClassInfo.Name = "dgvClassInfo";
            this.dgvClassInfo.ReadOnly = true;
            this.dgvClassInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClassInfo.RowHeadersVisible = false;
            this.dgvClassInfo.RowHeadersWidth = 80;
            this.dgvClassInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClassInfo.RowTemplate.Height = 28;
            this.dgvClassInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassInfo.Size = new System.Drawing.Size(1157, 335);
            this.dgvClassInfo.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "class_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Class ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 123;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "staff_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Staff ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 113;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "class_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subject_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subject ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 141;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "day_of_week";
            this.dataGridViewTextBoxColumn5.HeaderText = "Day Of Week";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 170;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "starting_time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Starting Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "duration";
            this.dataGridViewTextBoxColumn7.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 122;
            // 
            // feepermonthDataGridViewTextBoxColumn
            // 
            this.feepermonthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.feepermonthDataGridViewTextBoxColumn.DataPropertyName = "fee_per_month";
            this.feepermonthDataGridViewTextBoxColumn.HeaderText = "Fee Per Month";
            this.feepermonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feepermonthDataGridViewTextBoxColumn.Name = "feepermonthDataGridViewTextBoxColumn";
            this.feepermonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.feepermonthDataGridViewTextBoxColumn.Width = 183;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "class";
            this.classBindingSource1.DataSource = this.tuitionManagementSystemDataSet2;
            // 
            // tuitionManagementSystemDataSet2
            // 
            this.tuitionManagementSystemDataSet2.DataSetName = "TuitionManagementSystemDataSet2";
            this.tuitionManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnClear.Location = new System.Drawing.Point(368, 275);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 32);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear field";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txt_Search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Search.BorderRadius = 15;
            this.txt_Search.BorderSize = 1;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Search.Location = new System.Drawing.Point(320, 221);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "ClassID";
            this.txt_Search.Size = new System.Drawing.Size(222, 52);
            this.txt_Search.TabIndex = 25;
            this.txt_Search.Texts = "";
            this.txt_Search.UnderlinedStyle = false;
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter_1);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress_1);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave_1);
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnl_Content.Controls.Add(this.pictureBox2);
            this.pnl_Content.Controls.Add(this.pictureBox1);
            this.pnl_Content.Controls.Add(this.lblTitle);
            this.pnl_Content.Controls.Add(this.pictureBox18);
            this.pnl_Content.Controls.Add(this.btnShowAll);
            this.pnl_Content.Controls.Add(this.dgvClassInfo);
            this.pnl_Content.Controls.Add(this.btnClear);
            this.pnl_Content.Controls.Add(this.txt_Search);
            this.pnl_Content.Controls.Add(this.btn_Search);
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Content.Location = new System.Drawing.Point(0, 62);
            this.pnl_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(1382, 738);
            this.pnl_Content.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1165, 275);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 159;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(622, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(471, 70);
            this.lblTitle.TabIndex = 156;
            this.lblTitle.Text = "Class Database";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(424, 27);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(180, 119);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 157;
            this.pictureBox18.TabStop = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAll.BackColor = System.Drawing.Color.HotPink;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnShowAll.IconColor = System.Drawing.Color.Black;
            this.btnShowAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAll.Location = new System.Drawing.Point(862, 221);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(231, 71);
            this.btnShowAll.TabIndex = 74;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.Location = new System.Drawing.Point(549, 225);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(55, 45);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // pnl_DashBoard
            // 
            this.pnl_DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.pnl_DashBoard.Controls.Add(this.btn_Closed);
            this.pnl_DashBoard.Controls.Add(this.btn_Maximize);
            this.pnl_DashBoard.Controls.Add(this.btnHome);
            this.pnl_DashBoard.Controls.Add(this.btn_Minimize);
            this.pnl_DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnl_DashBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_DashBoard.Name = "pnl_DashBoard";
            this.pnl_DashBoard.Size = new System.Drawing.Size(1382, 62);
            this.pnl_DashBoard.TabIndex = 45;
            this.pnl_DashBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_DashBoard_MouseDown);
            // 
            // btn_Closed
            // 
            this.btn_Closed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Closed.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Closed.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btn_Closed.IconColor = System.Drawing.Color.Black;
            this.btn_Closed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Closed.Location = new System.Drawing.Point(1317, 0);
            this.btn_Closed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Closed.Name = "btn_Closed";
            this.btn_Closed.Size = new System.Drawing.Size(55, 50);
            this.btn_Closed.TabIndex = 2;
            this.btn_Closed.UseVisualStyleBackColor = false;
            this.btn_Closed.Click += new System.EventHandler(this.btn_Closed_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btn_Maximize.IconColor = System.Drawing.Color.Black;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.Location = new System.Drawing.Point(1254, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(55, 50);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Location = new System.Drawing.Point(11, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(117, 54);
            this.btnHome.TabIndex = 155;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Minimize.IconColor = System.Drawing.Color.Black;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.Location = new System.Drawing.Point(1190, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(57, 50);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // ClassInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.pnl_DashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClassInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassInformation";
            this.Load += new System.EventHandler(this.ClassInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.pnl_Content.ResumeLayout(false);
            this.pnl_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.pnl_DashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cassignmentDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClassInfo;
        private System.Windows.Forms.BindingSource cassignmentDataSet1BindingSource;
     //   private c_assignmentDataSet1 c_assignmentDataSet1;
        private RJCodeAdvance.RJControls.RJButton btnClear;
        private RJCodeAdvance.RJControls.RJTextBox txt_Search;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.Panel pnl_Content;
        private FontAwesome.Sharp.IconButton btn_Closed;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private System.Windows.Forms.Panel pnl_DashBoard;
    //    private c_assignmentDataSet2 c_assignmentDataSet2;
        private System.Windows.Forms.BindingSource classBindingSource;
 //       private c_assignmentDataSet2TableAdapters.classTableAdapter classTableAdapter;
        private FontAwesome.Sharp.IconButton btnShowAll;
//        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dayofweekDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn startingtimeDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TuitionManagementSystemDataSet2 tuitionManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private TuitionManagementSystemDataSet2TableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn feepermonthDataGridViewTextBoxColumn;
    }
}