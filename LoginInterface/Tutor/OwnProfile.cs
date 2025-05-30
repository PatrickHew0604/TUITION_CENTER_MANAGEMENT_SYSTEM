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
    public partial class OwnProfileTutor : Form
    {
        private string Username, Password/*, Name, IC_Passport,Email,Contact_Number,Address,Gender*/;
        private int borderSize = 6;
        private bool verification = false;
        public OwnProfileTutor(string username, string password, string name, string ic_passport, string email, string contact_num, string address, string gender)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            ShowUI(false);
            txtEmail.Text = email;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtName.Text = name;
            txtICPassport.Text = ic_passport;
            txtContactNum.Text = contact_num;
            txtAddress.Text = address;
            txtGender.Text = gender;
            txtUsername.Enabled = false;
            pnl_DashBoard.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnl_Menu.BorderStyle = BorderStyle.Fixed3D;
            foreach (Button button in pnl_Menu.Controls.OfType<Button>())
            {
                button.Cursor = Cursors.Hand;
            }
            foreach (Button button in pnlContent.Controls.OfType<Button>())
            {
                button.Cursor = Cursors.Hand;
            }
            foreach (Button button in pnl_DashBoard.Controls.OfType<Button>())
            {
                button.Cursor = Cursors.Hand;
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RefreshProfile()
        {
            Tutor tutor = new Tutor(this.Username, txtPassword.Text);
            txtEmail.Text = tutor.Email;
            txtUsername.Text = tutor.Username;
            txtPassword.Text = tutor.Password;
            txtName.Text = tutor.Name;
            txtICPassport.Text = tutor.IcNum;
            txtContactNum.Text = tutor.ContactNum;
            txtAddress.Text = tutor.Address;
            txtGender.Text = tutor.Gender;
            txtUsername.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
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
            Validation valid = new Validation();
            bool isValidEmail = valid.IsEmailValid(txtEmail.Text);
            bool isValidContactNum = valid.IsPhoneNumValid(txtContactNum.Text);
            if (isValidContactNum && isValidEmail)
            {
                Tutor tutor = new Tutor();
                tutor.UpdateProfile(txtUsername.Text, txtPassword.Text, txtName.Text, txtICPassport.Text, txtEmail.Text, txtContactNum.Text, txtAddress.Text, txtGender.Text);
                RefreshProfile();
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

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
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

        private void btn_Closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    Notification noti = new Notification("Incorrect Password");
                    noti.Show();
                }
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btn_ClassInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.ViewClassInfo();
        }

        private void btn_ViewStudentList_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.EnrolStudentInClass();
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.EditClass();
        }

        private void btn_AddInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.AddClassInfo();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username , this.Password);
            tutor.HomePageForm();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = SystemColors.Window;
        }

        private void txtContactNum_Enter(object sender, EventArgs e)
        {
            txtContactNum.ForeColor = SystemColors.Window;
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.DeleteClassInfo();
        }

        private void CollapseMenu()
        {
            if (this.pnl_Menu.Width > 240)
            {
                btn_Menu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
                pnl_Menu.Width = 155;
                picLogo.Visible = false;
                btn_Menu.Dock = DockStyle.Top;
                foreach (Button button in pnl_Menu.Controls.OfType<Button>())
                {
                    button.Text = "";
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
            else
            {
                btn_Menu.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
                pnl_Menu.Width = 310;
                picLogo.Visible = true;
                btn_Menu.Dock = DockStyle.Right;
                foreach (Button button in pnl_Menu.Controls.OfType<Button>())
                {
                    button.Text = button.Tag.ToString();
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(30, 0, 0, 0);
                }
            }
        }


    }   
}
