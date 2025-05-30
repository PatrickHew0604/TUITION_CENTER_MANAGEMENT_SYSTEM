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
using System.Xml.Linq;

namespace LoginInterface
{
    public partial class HomePageTutor : Form
    {
        private int borderSize = 6;
        private string Password;
        private string Username;
        private string Names;
        public HomePageTutor(string username, string password)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            this.Names = con.RetrieveData($"SELECT name FROM staff WHERE username = '{username}' AND password = '{password}' ").ToString();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            lblName.Text = this.Names;
        }
        private void CollapseMenu()
        {
            if (this.pnlMenu.Width > 240)
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
                pnlMenu.Width = 155;
                picLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = "";
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
            else
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
                pnlMenu.Width = 310;
                picLogo.Visible = true;
                btnMenu.Dock = DockStyle.Right;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = button.Tag.ToString();
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(30, 0, 0, 0);
                }
            }
        }
        // These code allow dragging of the form !
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
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
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        //Above all from Patrick
        private void btn_AddInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.AddClassInfo();
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.EditClass();
        }

        private void btn_ViewStudentList_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.EnrolStudentInClass();
        }

        private void btn_ClassInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.ViewClassInfo();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.DeleteClassInfo();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.UpdateOwnProfileForm();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
