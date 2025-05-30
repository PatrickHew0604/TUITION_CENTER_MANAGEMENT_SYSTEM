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
    public partial class Form_View_Student_List : Form
    {
        private int borderSize = 6;
        public Form_View_Student_List()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btn_Maximize.Enabled = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet.student_class' table. You can move, or remove it, as needed.
            this.student_classTableAdapter.Fill(this.tuitionManagementSystemDataSet.student_class);
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.tuitionManagementSystemDataSet2.subject);
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2.student_subject' table. You can move, or remove it, as needed.
            this.student_subjectTableAdapter.Fill(this.tuitionManagementSystemDataSet2.student_subject);
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_Closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search()
        {
            if (txt_Search.Texts != String.Empty && txt_Search.Texts != "Student ID")
            {
                List<string> subsID = new List<string>();
                Tutor tutor = new Tutor();
                int stdID = Convert.ToInt32(txt_Search.Texts);
                dgvStudentSubject.DataSource = tutor.SearchStudent(stdID);
                dgvStudentClass.DataSource = tutor.SearchStudentClass(stdID);
                subsID =  (tutor.RetrieveSubjectView(stdID.ToString()));
                dgvSubject.DataSource = tutor.SearchSubject(subsID);
            }
            else
            {
                txt_Search.ForeColor = Color.Red;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception)
            {

                Notification noti = new Notification("Please enter a valid ID");
                noti.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_Search.Texts = String.Empty;
            txt_Search.Texts= "Student ID";
        }

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            dgvStudentSubject.DataSource =(DataTable)con.RetriveDataInTable($"SELECT * FROM student_subject");
            dgvSubject.DataSource = (DataTable)con.RetriveDataInTable($"SELECT * FROM subject");
            dgvStudentClass.DataSource = (DataTable)con.RetriveDataInTable($"SELECT * FROM student_class");
            con.Close();
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.ForeColor = SystemColors.Window;
            if (txt_Search.Texts == "Student ID")
            {
                txt_Search.Texts = String.Empty;
            }
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Texts == String.Empty)
            {
                txt_Search.Texts = "Student ID";

            }
        }
    }
}
