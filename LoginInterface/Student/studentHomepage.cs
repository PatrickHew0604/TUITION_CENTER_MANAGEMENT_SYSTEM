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
    public partial class studentHomepage : Form
    {        
        private string Username { get; set; }
        private string Password { get; set; }
        private string sName { get; set; }
        private string Level { get; set; }
        private string Gender { get; set; }
        private string StudentID { get; set; }
        private int borderSize = 6;
        public studentHomepage(string username, string password, string names, string level, string studentID, string gender)
        {
            this.Password = password;
            this.Username = username;
            this.sName= names;
            this.Level = "Form " + level;
            this.StudentID = studentID;
            this.Gender = gender;

            InitializeComponent();            
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            Validation data = new Validation();

            lblName.Text = "Name: "+this.sName;
            lblLevel.Text = "Level: " + this.Level;
            lblStudentID.Text = "Student ID: " + this.StudentID;

            if(this.Gender == "Male")
            { this.picAvatar.Image = picMale.Image; }
            else
            { this.picAvatar.Image = picFemale.Image; }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void Student_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Calculator();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Notification nofi = new Notification("You are Logout.");
            nofi.Show();
            this.Hide();
            Student student = new Student(); student.Logout();
            this.Close();
        }
    }


}
