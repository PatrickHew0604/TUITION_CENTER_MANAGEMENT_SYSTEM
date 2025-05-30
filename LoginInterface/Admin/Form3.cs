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
using System.Windows.Media;

namespace LoginInterface
{
    public partial class Form3 : Form
    {
        private string Username, Password;
        int bordersize = 6;
        private int level = 1;
        private int Month = 1;
        public Form3(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = System.Drawing.Color.FromArgb(64,64,64);
            Validation data = new Validation();
            foreach (string subject in data.Subjects)
            {
                cmbSubject.Items.Add(subject);
            }
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

        #region button closed,max,min
        private void btnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 240)
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
            else
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
                pnlMenu.Width = 260;
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

        #region button menu
        private void btnTutor_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.TutorForm();
            //this.Hide();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.ReceptionistForm();
            //this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.OwnProfileForm();
            //this.Hide();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage_Admin homepage = new HomePage_Admin(this.Username, this.Password);
            homepage.Show();
            //this.Hide();
        }
        #endregion

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (cmbLevel.Texts == "Form1")
            {
                level = 1;
            }
            else if (cmbLevel.Texts == "Form2")
            {
                level = 2;
            }
            else if (cmbLevel.Texts == "Form3")
            {
                level = 3;
            }
            else if (cmbLevel.Texts == "Form4")
            {
                level = 4;
            }
            else if (cmbLevel.Texts == "Form5")
            {
                level = 5;
            }
            if (cmbMonth.Texts == "January")
            {
                Month = 1;
            }
            else if (cmbMonth.Texts == "February")
            {
                Month = 2;
            }
            else if (cmbMonth.Texts == "March")
            {
                Month = 3;
            }
            else if (cmbMonth.Texts == "April")
            {
                Month = 4;
            }
            else if (cmbMonth.Texts == "May")
            {
                Month = 5;
            }
            else if (cmbMonth.Texts == "June")
            {
                Month = 6;
            }
            else if (cmbMonth.Texts == "July")
            {
                Month = 7;
            }
            else if (cmbMonth.Texts == "August")
            {
                Month = 8;
            }
            else if (cmbMonth.Texts == "September")
            {
                Month = 9;
            }
            else if (cmbMonth.Texts == "October")
            {
                Month = 10;
            }
            else if (cmbMonth.Texts == "November")
            {
                Month = 11;
            }
            else if (cmbMonth.Texts == "December")
            {
                Month = 12;
            }

            Admin admin = new Admin();
            if (cmbMonth.Texts != string.Empty && cmbLevel.Texts != string.Empty && cmbSubject.Texts != string.Empty)
            {
                grpReport.Text = cmbMonth.Texts + " " + cmbLevel.Texts + " " + cmbSubject.Texts;
                lblMoney.Text = (admin.Income_report(Month,level.ToString(),cmbSubject.Texts)).ToString();
            }
            else
            {
                //need to change to Patrick special message box
                Notification noti = new Notification("Please done your choices");
                noti.Show();
            }
        }

    }
}
