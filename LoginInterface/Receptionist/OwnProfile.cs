using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace LoginInterface
{
    public partial class OwnProfile : Form
    {
        private string Username, Password/*, Name, IC_Passport,Email,Contact_Number,Address,Gender*/;
        private int borderSize = 6;
        private bool verification = false;
        public OwnProfile(string username, string password,string name,string ic_passport,string email,string contact_num,string address,string gender)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            /*this.IC_Passport = ic_passport;
            this.Contact_Number = contact_num;
            this.Address = address;
            this.Gender = gender;*/
            InitializeComponent();
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
            pnlDashboard.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
            txtGender.Enabled = false;
            foreach (Button button in pnlMenu.Controls.OfType<Button>())
            {
                button.Cursor = Cursors.Hand;
            }
            foreach (Button button in pnlContent.Controls.OfType<Button>())
            {
                button.Cursor = Cursors.Hand;
            }
            foreach (Button button in pnlDashboard.Controls.OfType<Button>())
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
            Receptionist receptionist = new Receptionist(this.Username, txtPassword.Text);
            txtEmail.Text = receptionist.Email;
            txtUsername.Text = receptionist.Username;
            txtPassword.Text = receptionist.Password;
            txtName.Text = receptionist.Name;
            txtICPassport.Text = receptionist.ICPassport;
            txtContactNum.Text = receptionist.ContactNum;
            txtAddress.Text = receptionist.Address;
            txtGender.Text = receptionist.Gender;
            txtUsername.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void ShowUI(bool enab)
        {
            foreach (TextBox textBox in pnlContent.Controls.OfType<TextBox>())
            {
                if (textBox.Tag.ToString() == "Gender")
                {
                    continue;
                }
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
            Validation valid = new Validation();
            bool isValidEmail = valid.IsEmailValid(txtEmail.Text);
            bool isValidContactNum = valid.IsPhoneNumValid(txtContactNum.Text);
            if (isValidContactNum && isValidEmail)
            {
                Receptionist receptionis = new Receptionist();
                receptionis.UpdateProfile(txtUsername.Text, txtPassword.Text, txtName.Text, txtICPassport.Text, txtEmail.Text, txtContactNum.Text, txtAddress.Text, txtGender.Text);
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

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CollapseMenu()
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.RegisterStudentForm();
        }

        private void btnUpdateEnrollment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.UpdateEnrollmentForm();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.ReceivePaymentForm();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.DeleteStudentForm();
        }


        private void btnHomePage_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.HomePageForm();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = SystemColors.Window;
        }

        private void txtContactNum_Enter(object sender, EventArgs e)
        {
            txtContactNum.ForeColor = SystemColors.Window;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
