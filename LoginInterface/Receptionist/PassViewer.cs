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
    public partial class PassViewer : Form
    {
        bool encrypted = true;
        public string Password { get; set; }
        private int borderSize = 6;
        public PassViewer(string username)
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            lblUsername.Text = username;
            lblUsername.Left = (this.Size.Width - lblUsername.Size.Width) / 2;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = SystemColors.Window;
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
                encrypted = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                encrypted = false;

            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (encrypted)
            {
                btnVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.UseSystemPasswordChar = false;
                encrypted = false;
            }
            else
            {
                btnVisible.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.UseSystemPasswordChar = true;
                encrypted = true;
            }
        }

        private void Confirm()
        {
            this.Password = txtPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Confirm();
            }
        }
    }
}
