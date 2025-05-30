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
    public partial class studentShowTutor : Form
    {
        private string StudentID { get; set; }
        public studentShowTutor(string student_id, string staff_id)
        {
            this.StudentID= student_id;
            InitializeComponent();

            Student student = new Student(this.StudentID);
            string[] tutor_detail = student.Tutor(staff_id);
            lblT_Name.Text = "Name: "+ tutor_detail[0];
            lblT_Gender.Text = "Gender: " + tutor_detail[1];
            lblT_Email.Text = "Email: " + tutor_detail[2];
            lblT_ContactNumber.Text = "Contact: " + tutor_detail[3];
            lblT_LastOnline.Text = "Last Online: " + tutor_detail[4];

            if (tutor_detail[1] == "Male") { picAvatar.Image = picMale.Image; }
            else { picAvatar.Image = picFemale.Image; }
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
    }
}