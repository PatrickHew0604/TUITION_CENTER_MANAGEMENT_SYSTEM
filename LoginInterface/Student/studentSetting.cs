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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginInterface
{
    public partial class studentSetting : Form
    {
        private int borderSize = 6;
        public string StudentID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Names { get; set; }
        public string Level { get; set; }
        public string ICPassport { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public studentSetting(string studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);

            ShowInfo();
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

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (btnPassword.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
        private void UpdateProfileDetail()
        {
            Validation valid = new Validation();
            bool isValidEmail = valid.IsEmailValid(txtEmail.Text);
            bool isValidContactNum = valid.IsPhoneNumValid(txtContactNumber.Text);
            if (isValidContactNum && isValidEmail)
            {
                Student student = new Student(this.StudentID);
                student.UpdateProfile(this.StudentID, txtUsername.Text, txtPassword.Text, txtEmail.Text, txtContactNumber.Text);
            }
            else if (!isValidContactNum && !isValidEmail)
            {
                txtContactNumber.ForeColor = Color.Red;
                txtEmail.ForeColor = Color.Red;
            }
            else if (!isValidContactNum)
            {
                txtContactNumber.ForeColor = Color.Red;
            }
            else if (!isValidEmail)
            {
                txtEmail.ForeColor = Color.Red;
            }
            Notification nofi = new Notification("Your Details are Updated!");
            nofi.Show();
            ShowInfo();
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileDetail();
        }
        private void ShowInfo()
        {
            Student student = new Student(this.StudentID);

            this.Username = student.Username;
            this.Password = student.Password;
            this.Names = student.Names;
            this.Level = "Form " + student.Level;
            this.ICPassport = student.ICPassport;
            this.ContactNum = student.ContactNum;
            this.Gender = student.Gender;
            this.Email = student.Email;

            txtUsername.Text = this.Username;
            txtPassword.Text = this.Password;
            txtName.Text = this.Names;
            txtLevel.Text = this.Level;
            txtGender.Text = this.Gender;
            txtIC.Text = this.ICPassport;
            txtContactNumber.Text = this.ContactNum;
            txtEmail.Text = this.Email;
        }
        private void studentSetting_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == this.Username)
            { txtUsername.Text = ""; }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == this.Password)
            { txtPassword.Text = ""; }
        }
        private void txtContactNumber_Enter(object sender, EventArgs e)
        {
            txtContactNumber.ForeColor = Color.Black;
            if (txtContactNumber.Text == this.ContactNum)
            { txtContactNumber.Text = ""; }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            if (txtEmail.Text == this.Email)
            { txtEmail.Text = ""; }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            { txtUsername.Text = this.Username; }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            { txtPassword.Text = this.Password; }
        }
        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "")
            { txtContactNumber.Text = this.ContactNum; }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            { txtEmail.Text = this.Email; }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContactNumber.Focus();
            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateProfileDetail();
            }
        }
    }
}