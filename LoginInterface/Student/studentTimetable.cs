using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class studentTimetable : Form
    {
        private int borderSize = 6;
        private string StudentID { get; set; } 
        private string Username { get; set; }
        private string Password { get; set; }
        public string[] Subject { get; set; }
        public studentTimetable(string student_id, string username, string password)
        {
            InitializeComponent();
            this.StudentID = student_id;
            this.Username = username;
            this.Password = password;

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);

            //this.class_checkingTableAdapter.FillBy(this.c_assignmentDataSet.class_checking, int.Parse(this.StudentID));
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
        private void dgvTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Student student = new Student(this.StudentID);
                //Show Class Namelist
                if (e.ColumnIndex == 2)
                {
                    string class_name;
                    int numberRow = Convert.ToInt32(e.RowIndex);
                    class_name = dgvTimetable.Rows[numberRow].Cells[2].Value.ToString();
                    string tutor_id;
                    int numberRow1 = Convert.ToInt32(e.RowIndex);
                    tutor_id = dgvTimetable.Rows[numberRow1].Cells[4].Value.ToString();
                    student.ShowClassNamelist(tutor_id, class_name);
                    this.Hide();
                    this.Close();
                }
                //Show Tutor Details
                else if (e.ColumnIndex == 5)
                {
                    string tutor_id;
                    int numberRow2 = Convert.ToInt32(e.RowIndex);
                    tutor_id = dgvTimetable.Rows[numberRow2].Cells[4].Value.ToString();
                    
                    student.ShowTutor(tutor_id);
                    this.Hide();
                    this.Close();
                }

            }
        }

        private void studentTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2.getclass' table. You can move, or remove it, as needed.
            this.getclassTableAdapter.Fill(this.tuitionManagementSystemDataSet2.getclass);
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = 
                (DataTable)con.RetriveDataInTable($"SELECT * FROM getclass WHERE student_id = {this.StudentID}");
            dgvTimetable.DataSource = dtable;
            // TODO: This line of code loads data into the 'c_assignmentDataSet.student_class' table. You can move, or remove it, as needed.
            //this.student_classTableAdapter.Fill(this.c_assignmentDataSet.student_class);

        }
    }


}
