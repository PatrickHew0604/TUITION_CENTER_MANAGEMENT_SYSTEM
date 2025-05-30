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
    public partial class StudentsDBView : Form
    {
        private int borderSize = 6;
        public StudentsDBView()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btnMaximize.Enabled = false;
            ResizeForm();
        }

        private void ResizeForm()
        {
            Size newSize = new Size(dgvStudent.Width + 100, this.Height);
            this.Size = newSize;
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

        private void StudentsDBView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.tuitionManagementSystemDataSet.student);
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
            dgvStudent.DataSource = receptionis.SearchStudent();
            ResizeForm();
        }

        private void Search()
        {
            if (txtUsername.Text != String.Empty && txtUsername.Text != "Username")
            {
                Receptionist receptionis = new Receptionist();
                dgvStudent.DataSource = receptionis.SearchStudent(txtUsername.Text);
                ResizeForm();
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
                dgvStudent.DataSource = receptionis.SearchStudent();
                ResizeForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.Text = "Username";
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void btnStudentSubject_Click(object sender, EventArgs e)
        {
            StudentSubjectDBView temp = new StudentSubjectDBView();
            temp.Show();
        }
    }
}
