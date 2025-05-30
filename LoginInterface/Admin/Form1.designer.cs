namespace LoginInterface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHomePage = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnIncome = new FontAwesome.Sharp.IconButton();
            this.btnReceptionist = new FontAwesome.Sharp.IconButton();
            this.btnTutor = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClosed = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvTutor = new System.Windows.Forms.DataGridView();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastonlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuitionManagementSystemDataSet2 = new LoginInterface.TuitionManagementSystemDataSet2();
            this.btnShowAll = new FontAwesome.Sharp.IconButton();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAssign = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.staffTableAdapter = new LoginInterface.TuitionManagementSystemDataSet2TableAdapters.staffTableAdapter();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
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
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(116, 711);
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
            this.btnHomePage.Location = new System.Drawing.Point(0, 628);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(116, 83);
            this.btnHomePage.TabIndex = 13;
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
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Tag = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnIncome
            // 
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
            this.btnIncome.TabIndex = 1;
            this.btnIncome.Tag = "Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
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
            this.btnReceptionist.TabIndex = 3;
            this.btnReceptionist.Tag = "Receptionist";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.BackColor = System.Drawing.Color.Blue;
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
            this.btnTutor.TabIndex = 2;
            this.btnTutor.Tag = "Tutor Info";
            this.btnTutor.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 117);
            this.panel1.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnMenu.IconColor = System.Drawing.SystemColors.Window;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 117);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMene_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(4, 10);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(108, 98);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Black;
            this.pnlDashboard.Controls.Add(this.btnMinimize);
            this.pnlDashboard.Controls.Add(this.btnClosed);
            this.pnlDashboard.Controls.Add(this.btnMaximize);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(116, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1454, 50);
            this.pnlDashboard.TabIndex = 1;
            this.pnlDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(1324, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosed.BackColor = System.Drawing.Color.Salmon;
            this.btnClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosed.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnClosed.IconColor = System.Drawing.Color.Black;
            this.btnClosed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClosed.Location = new System.Drawing.Point(1407, 10);
            this.btnClosed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(36, 32);
            this.btnClosed.TabIndex = 3;
            this.btnClosed.UseVisualStyleBackColor = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(1365, 10);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 32);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlContent.Controls.Add(this.dgvTutor);
            this.pnlContent.Controls.Add(this.btnShowAll);
            this.pnlContent.Controls.Add(this.picClear);
            this.pnlContent.Controls.Add(this.picSearch);
            this.pnlContent.Controls.Add(this.txtSearch);
            this.pnlContent.Controls.Add(this.btnAssign);
            this.pnlContent.Controls.Add(this.btnDelete);
            this.pnlContent.Controls.Add(this.btnRegister);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(116, 50);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1454, 661);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvTutor
            // 
            this.dgvTutor.AllowUserToAddRows = false;
            this.dgvTutor.AllowUserToDeleteRows = false;
            this.dgvTutor.AllowUserToResizeRows = false;
            this.dgvTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTutor.AutoGenerateColumns = false;
            this.dgvTutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgvTutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTutor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutor.ColumnHeadersHeight = 70;
            this.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactnumberDataGridViewTextBoxColumn,
            this.icnumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.lastonlineDataGridViewTextBoxColumn});
            this.dgvTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTutor.DataSource = this.staffBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutor.EnableHeadersVisualStyles = false;
            this.dgvTutor.Location = new System.Drawing.Point(49, 92);
            this.dgvTutor.Name = "dgvTutor";
            this.dgvTutor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutor.RowHeadersVisible = false;
            this.dgvTutor.RowHeadersWidth = 80;
            this.dgvTutor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTutor.RowTemplate.Height = 45;
            this.dgvTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutor.Size = new System.Drawing.Size(1357, 477);
            this.dgvTutor.TabIndex = 79;
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffidDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            this.contactnumberDataGridViewTextBoxColumn.Width = 197;
            // 
            // icnumberDataGridViewTextBoxColumn
            // 
            this.icnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.icnumberDataGridViewTextBoxColumn.DataPropertyName = "ic_number";
            this.icnumberDataGridViewTextBoxColumn.HeaderText = "IC Number";
            this.icnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.icnumberDataGridViewTextBoxColumn.Name = "icnumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // lastonlineDataGridViewTextBoxColumn
            // 
            this.lastonlineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastonlineDataGridViewTextBoxColumn.DataPropertyName = "last_online";
            this.lastonlineDataGridViewTextBoxColumn.HeaderText = "Last Online";
            this.lastonlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastonlineDataGridViewTextBoxColumn.Name = "lastonlineDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.tuitionManagementSystemDataSet2;
            // 
            // tuitionManagementSystemDataSet2
            // 
            this.tuitionManagementSystemDataSet2.DataSetName = "TuitionManagementSystemDataSet2";
            this.tuitionManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnShowAll.IconColor = System.Drawing.Color.Black;
            this.btnShowAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAll.Location = new System.Drawing.Point(1275, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(155, 41);
            this.btnShowAll.TabIndex = 73;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // picClear
            // 
            this.picClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClear.Image = ((System.Drawing.Image)(resources.GetObject("picClear.Image")));
            this.picClear.Location = new System.Drawing.Point(213, 25);
            this.picClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(20, 18);
            this.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClear.TabIndex = 7;
            this.picClear.TabStop = false;
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            // 
            // picSearch
            // 
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(235, 25);
            this.picSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(20, 18);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 7;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(21, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 31);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAssign.IconColor = System.Drawing.Color.Black;
            this.btnAssign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssign.Location = new System.Drawing.Point(1260, 593);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(142, 40);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Bauhaus 93", 16F);
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(668, 593);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Bauhaus 93", 16F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegister.IconColor = System.Drawing.Color.Black;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.Location = new System.Drawing.Point(61, 593);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(142, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 711);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDashboard;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClosed;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnIncome;
        private FontAwesome.Sharp.IconButton btnReceptionist;
        private FontAwesome.Sharp.IconButton btnTutor;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAssign;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.PictureBox picClear;
        private FontAwesome.Sharp.IconButton btnShowAll;
        private FontAwesome.Sharp.IconButton btnHomePage;
        private TuitionManagementSystemDataSet2 tuitionManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private TuitionManagementSystemDataSet2TableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridView dgvTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastonlineDataGridViewTextBoxColumn;
    }
}

