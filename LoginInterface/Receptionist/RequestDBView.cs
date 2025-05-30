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
    public partial class RequestDBView : Form
    {
        string username, current_sub, new_sub, level;
        private int borderSize = 6;
        public RequestDBView()
        {
            InitializeComponent();
            Receptionist receptionist = new Receptionist();
            List<string> datas = receptionist.GetFirstRowFromDGV();
            try
            {
                username = datas[0];
                current_sub = datas[1];
                new_sub = datas[2];
                level = datas[3];
                btnAllow.Enabled = true;
                btnDisallowed.Enabled = true;
            }
            catch (Exception)
            {

                btnAllow.Enabled = false;
                btnDisallowed.Enabled = false;
            }
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
        }

        
        private void btnAllow_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.ChangeSubjectInRequest(username, level, current_sub, new_sub);
            Notification noti = new Notification("Enrollment has been updated");
            noti.Show();
            btnMaximize.Enabled = false;
        }

        private void btnDisallowed_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.DisallowRequest(username, current_sub, new_sub, level);
            Notification noti = new Notification("Enrollment has been updated");
            noti.Show();
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
            Receptionist receptionist = new Receptionist();
            dgvStudentSubs.DataSource = receptionist.SearchRequest();
            List<string> datas = receptionist.GetFirstRowFromDGV();
            try
            {
                username = datas[0];
                current_sub = datas[1];
                new_sub = datas[2];
                level = datas[3];
                btnAllow.Enabled = true;
                btnDisallowed.Enabled = true;
            }
            catch (Exception)
            {

                btnAllow.Enabled = false;
                btnDisallowed.Enabled = false;
            }
        }

        private void Search()
        {
            if (txtUsername.Text != String.Empty && txtUsername.Text != "Username")
            {
                Receptionist receptionis = new Receptionist();
                dgvStudentSubs.DataSource = receptionis.SearchRequest(txtUsername.Text);
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



        private void RequestDBView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2.request_list' table. You can move, or remove it, as needed.
            this.request_listTableAdapter.Fill(this.tuitionManagementSystemDataSet2.request_list);

        }

        private void dgvStudentSubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // This is to prevent it clicking the column header !
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvStudentSubs.Rows[index];
                username = selectedRow.Cells[0].Value.ToString();
                current_sub = selectedRow.Cells[2].Value.ToString();
                new_sub = selectedRow.Cells[3].Value.ToString();
                level = selectedRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                
            }
;        }
    }
}
