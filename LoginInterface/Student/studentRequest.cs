using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class studentRequest : Form
    {
        private int borderSize = 6;
        private string StudentID { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        public string[] Subject { get; set; }
        public studentRequest(string student_id, string username, string password)
        {
            InitializeComponent();
            this.StudentID= student_id;
            this.Username = username;
            this.Password = password;

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);

            ShowSubject();
                   
        }
        private void ShowSubject()
        {
            cmbSubject1.Items.Clear();
            cmbSubject2.Items.Clear();
            Student student = new Student();
            foreach (string subject in student.Subjects(this.StudentID))
                { cmbSubject1.Items.Add(subject); }
            foreach (string subject in student.NonTakenSubjects(this.StudentID))
                { cmbSubject2.Items.Add(subject); }
            cmbSubject2.Items.Remove("No Subject");
        }

        #region Dashboard
        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        #region WindowButton
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width <= 240) //open panel
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
                pnlMenu.Width = 260;
                picLogo.Visible = true;
                btnMenu.Dock = DockStyle.Right;

                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = String.Empty;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(30, 0, 0, 0);
                    button.Text = button.Tag.ToString();
                }
            }
            else //close panel
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
                pnlMenu.Width = 130;
                picLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = String.Empty;
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student(this.StudentID);
            student.Profile();
            this.Close();
        }
        private void btnTimetable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student(this.StudentID);
            student.Timetable();
            this.Close();
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student(this.StudentID);
            student.Request();
            this.Close();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student(this.StudentID);
            student.Setting();
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student(this.StudentID);
            student.Homepage();
            this.Close();
        }
        #endregion

        /* Request Changed
        private void CmbSubject1_Light(bool light)
        {            
            if (light)
            { 
                cmbSubject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));           
            }
            else
            { 
                cmbSubject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                cmbSubject1.SelectedItem = null;
            }
         }
        private void CmbSubject2_Light(bool light)
        {
            if (light)
            {
                cmbSubject2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));                
            }
            else
            {
                cmbSubject2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                cmbSubject2.SelectedItem = null;
            }
         }
        private void cmbControl_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cmbControl.SelectedIndex;
            switch (index) 
            { 
                default:
                    cmbSubject1.Enabled = false;
                    cmbSubject2.Enabled = false;                  
                    break;
                case 0: //Change
                    cmbSubject1.Enabled = true; 
                    cmbSubject2.Enabled = true;
                    break;
                case 1: //Add
                    cmbSubject1.Enabled = false;
                    cmbSubject2.Enabled = true;
                    break;
                case 2: //Drop
                    cmbSubject1.Enabled = true;
                    cmbSubject2.Enabled = false;
                    break;
            }
            CmbSubject1_Light(cmbSubject1.Enabled);
            CmbSubject2_Light(cmbSubject2.Enabled);
        }
        */
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string text;
            if (cmbSubject1.SelectedItem != null && cmbSubject2.SelectedItem != null)
            {
                Student student = new Student();
                string subject_1 = student.GetSubjectID(this.StudentID, cmbSubject1.Text); 
                string subject_2 = student.GetSubjectID(this.StudentID, cmbSubject2.Text); 
                student.SendRequest(this.StudentID, subject_1, subject_2);
                text="Request Sented!";
            }
            else 
            { text="One or More Subject Not Seleted!"; }
            Notification nofi = new Notification(text);
            nofi.Show();
            cmbSubject1.SelectedItem = null;
            cmbSubject2.SelectedItem = null;
            ShowSubject();
            studentRequest_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbSubject1.SelectedItem = null;
            cmbSubject2.SelectedItem = null;
        }
        private void studentRequest_Load(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable =
                (DataTable)con.RetriveDataInTable($"SELECT * FROM student_request WHERE student_id = {this.StudentID}");
            dgvRequest.DataSource = dtable;
            con.Close();
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string[] data = new string[3];
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex==6)
            {
                int numberRow = Convert.ToInt32(e.RowIndex);                
                data[0] = dgvRequest.Rows[numberRow].Cells[0].Value.ToString();
                data[1] = dgvRequest.Rows[numberRow].Cells[1].Value.ToString();
                data[2] = dgvRequest.Rows[numberRow].Cells[3].Value.ToString();
                Student student = new Student();
                student.RemoveRequest(data);
                Notification nofi = new Notification("Request Removed!");
                nofi.Show();
                studentRequest_Load(sender, e);
                ShowSubject();
            }
            
        }
    }


}
