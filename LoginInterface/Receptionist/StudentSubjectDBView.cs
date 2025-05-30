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
using SortOrder = System.Windows.Forms.SortOrder;

namespace LoginInterface
{
    public partial class StudentSubjectDBView : Form
    {
        private int borderSize = 6;
        public StudentSubjectDBView()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btnMaximize.Enabled = false;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.ForeColor = SystemColors.Window;
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == String.Empty)
            {
                txtUsername.Text = "Username";

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Receptionist receptionis = new Receptionist();
            dgvStudentSubs.DataSource = receptionis.SearchStudentSubjects();
        }

        private void Search()
        {
            if (txtUsername.Text != String.Empty && txtUsername.Text != "Username")
            {
                Receptionist receptionis = new Receptionist();
                dgvStudentSubs.DataSource = receptionis.SearchStudentSubjects(txtUsername.Text);
            }
            else
            {
                txtUsername.ForeColor = Color.Red;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Receptionist receptionis = new Receptionist();
            dgvStudentSubs.DataSource = receptionis.SearchStudentSubjects();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.Text = "Username";
        }

        private void StudentSubjectDBView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet1.stu_subs' table. You can move, or remove it, as needed.
            this.stu_subsTableAdapter.Fill(this.tuitionManagementSystemDataSet1.stu_subs);


        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();

            }
        }
    }
    public class DGVComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            DataGridViewRow row1 = (DataGridViewRow)x;
            DataGridViewRow row2 = (DataGridViewRow)y;

            int compareResult = string.Compare(
                (string)row1.Cells[0].Value,
                (string)row2.Cells[0].Value);

            if (compareResult == 0)
            {
                compareResult = ((int)row1.Cells[1].Value).CompareTo((int)row2.Cells[1].Value);
            }

            return compareResult;
        }
    }
}
