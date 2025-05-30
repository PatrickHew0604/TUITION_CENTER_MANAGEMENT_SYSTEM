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
    public partial class OwnProfile_Admin : Form
    {
        private string Username, Password/*, Name, IC_Passport, Email, Contact_Number, Address, Gender*/;
        private int bordersize = 6;
        private bool verification = false;
        public OwnProfile_Admin(string username, string password, string name, string ic_passport, string email, string address, string contact_num, string gender)
        {
            this.Username = username;
            this.Password = password;
            //this.Name = name;
            //this.IC_Passport = ic_passport;
            //this.Email = email;
            //this.Contact_Number = contact_num;
            //this.Address = address;
            //this.Gender = gender;
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            ShowUI(false);
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtName.Text = name;
            txtICPassport.Text = ic_passport;
            txtEmail.Text = email;
            txtContactNum.Text = contact_num;
            txtAddress.Text = address;
            txtGender.Text = gender;
            txtUsername.Enabled = false;
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

        #region button clase,max,min
        private void btnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

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

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.IncomeReportForm();
            //this.Hide();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage_Admin homepage = new HomePage_Admin(this.Username,this.Password);
            homepage.Show();
            //this.Hide();
        }
        #endregion

        private void ShowUI(bool enab)
        {
            foreach (TextBox textBox in pnlContent.Controls.OfType<TextBox>())
            {
                if (textBox.Name != txtUsername.Name)
                {
                    textBox.Enabled = enab;
                }
            }
            btnUpdate.Visible = enab;
        }

        private void tgbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbEdit.Checked)
            {
                ShowUI(true);
            }
            else
            {
                ShowUI(false);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                Validation valid = new Validation();
                bool isValidEmail = valid.IsEmailValid(txtEmail.Text);
                bool isValidContactNum = valid.IsPhoneNumValid(txtContactNum.Text);
                if (isValidContactNum && isValidEmail)
                {
                    Admin admin = new Admin();
                    admin.UpdateProfile_admin(txtUsername.Text, txtPassword.Text, txtName.Text, txtICPassport.Text, txtEmail.Text, txtContactNum.Text, txtAddress.Text, txtGender.Text);
                    //need to change to Patrick special message box
                    Notification noti = new Notification("Profile has been updated");
                    noti.Show();
                }
                else if (!isValidContactNum && !isValidEmail)
                {
                    txtContactNum.ForeColor = Color.Red;
                    txtEmail.ForeColor = Color.Red;
                }
                else if (!isValidContactNum)
                {
                    txtContactNum.ForeColor = Color.Red;
                }
                else if (!isValidEmail)
                {
                    txtEmail.ForeColor = Color.Red;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width > 240)
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
                pnlMenu.Width = 130;
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

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = SystemColors.Window;
        }


        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (!txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else if (txtPassword.UseSystemPasswordChar && !verification)
            {
                string enteredPassword = string.Empty;
                using (var form = new PassViewer(this.Username))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        enteredPassword = form.Password;
                    }
                }
                if (enteredPassword == this.Password)
                {
                    txtPassword.UseSystemPasswordChar = false;
                    verification = true;
                }
                else
                {
                    //need to change to Patrick special message box
                    Notification noti = new Notification("Incorrect Password");
                    noti.Show();
                }
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void txtContactNum_Enter(object sender, EventArgs e)
        {
            txtContactNum.ForeColor = SystemColors.Window;
        }

    }
}
