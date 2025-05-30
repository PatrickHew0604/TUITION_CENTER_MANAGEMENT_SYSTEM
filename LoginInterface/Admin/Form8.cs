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
    public partial class Form8 : Form
    {
        private int bordersize = 6;
        public Form8()
        {
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(64,64, 64);
            btnClear.Enabled = false;
        }

        #region Dashboard Window

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region button close,max,min
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            txtUsername.ForeColor = Color.Red;
            txtUsername.Clear();
            lblContactNumber.Text = lblContactNumber.Tag.ToString();
            lblICPassport.Text = lblICPassport.Tag.ToString();
            lblName.Text = lblName.Tag.ToString();
        }

        private void Search()
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if ((new Validation()).isReceptionistExist(txtUsername.Text))
            {
                SqlDataReader dr = con.DataReader($"SELECT name,ic_number,contact_number FROM staff WHERE username = '{txtUsername.Text}'");
                while (dr.Read())
                {
                    lblName.Text = dr["name"].ToString();
                    lblICPassport.Text = dr["ic_number"].ToString();
                    lblContactNumber.Text = dr["contact_number"].ToString();
                }
                btnRemove.Enabled = true;
                txtUsername.ForeColor = SystemColors.Window;
            }
            else
            {
                txtUsername.ForeColor = Color.Red;
                lblContactNumber.Text = lblContactNumber.Tag.ToString();
                lblICPassport.Text = lblICPassport.Tag.ToString();
                lblName.Text = lblName.Tag.ToString();
                btnRemove.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = string.Empty;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.RemoveReceptioinist(txtUsername.Text);
            //need to change to Patrick special message box
            Notification noti = new Notification("Receptionist has been deleted");
            noti.Show();
            this.Close();
        }
    }
}
