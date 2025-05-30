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
using System.Windows.Media.Animation;

namespace LoginInterface
{
    public partial class Form4 : Form
    {
        private int bordersize = 6;
        private int count = 1;
        private int level = 0;
        private string gender = null;
        public Form4()
        {

            InitializeComponent();
            radForm1.Checked = true;
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(64, 64, 64);
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
            this.Close();
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

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.White;
            if (txtUsername.Text == "Username")
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

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = string.Empty;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.White;
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = string.Empty;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        private void txtContactNum_Enter(object sender, EventArgs e)
        {
            txtContactNum.ForeColor = Color.White;
            if (txtContactNum.Text == "Contact Number")
            {
                txtContactNum.Text = string.Empty;
            }
        }

        private void txtContactNum_Leave(object sender, EventArgs e)
        {
            if (txtContactNum.Text == string.Empty)
            {
                txtContactNum.Text = "Contact Number";
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.ForeColor= Color.White;
            if (txtName.Text == "Name")
            {
                txtName.Text = string.Empty;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                txtName.Text = "Name";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.ForeColor= Color.White;
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = string.Empty;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty)
            {
                txtAddress.Text = "Address";
            }
        }

        private void txtICPassport_Enter(object sender, EventArgs e)
        {
            txtICPassport.ForeColor= Color.White;
            if (txtICPassport.Text == "IC/Passport")
            {
                txtICPassport.Text = string.Empty;
            }
        }

        private void txtICPassport_Leave(object sender, EventArgs e)
        {
            if (txtICPassport.Text == string.Empty)
            {
                txtICPassport.Text = "IC/Password";
            }
        }


        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (count % 2 != 0)
            {
                btnVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.UseSystemPasswordChar = false;
                count++;
            }
            else
            {
                btnVisible.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.UseSystemPasswordChar = true;
                count++;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbSubject.ForeColor = System.Drawing.SystemColors.Window;
            btnVisible.IconChar = FontAwesome.Sharp.IconChar.Eye;
            txtPassword.UseSystemPasswordChar = false;
            count = 1;
            foreach (TextBox textBox in pnlContent.Controls.OfType<TextBox>())
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = System.Drawing.SystemColors.Window;
            }
            foreach (RadioButton radioButton in grpLevel.Controls.OfType<RadioButton>())
                if (radioButton.Checked)
                    radioButton.Checked = false;
            cmbSubject.Texts = "Subject";
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
                txtName.Focus();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtICPassport.Focus();
            }
        }

        private void txtICPassport_KeyPress(object sender, KeyPressEventArgs e)
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
                txtContactNum.Focus();
            }
        }

        private void txtContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbSubject.Focus();
            }
        }

        private void cmbSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                grpLevel.Focus();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            #region Declaring Variable
            bool check = true;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string icPassport = txtICPassport.Text;
            string email = txtEmail.Text;
            string contactNumber = txtContactNum.Text;
            string address = txtAddress.Text;
            string subject = cmbSubject.Texts;
            bool isUsernameValid, isEmailValid, isContactNumValid;
            #endregion
            #region Filter Empty Input
            foreach (TextBox textBox in pnlContent.Controls.OfType<TextBox>())
            {
                if (textBox.Text == textBox.Tag.ToString())
                {
                    check = false;
                    textBox.ForeColor = Color.Red;
                }
            }
            if (cmbSubject.Texts == "Subject")
            {
                cmbSubject.ForeColor = Color.Red;
                check = false;
            }
            #endregion
            if (check)
            {
                #region Validate And Insert into Database
                Validation val = new Validation();
                bool[] valid = val.ValidateStudentData(username, email, contactNumber);
                isUsernameValid = valid[0];
                isEmailValid = valid[1];
                isContactNumValid = valid[2];
                if (isContactNumValid && isEmailValid && isContactNumValid)
                {
                    Admin admin = new Admin();
                    admin.RegisterTutorInToDatabase_staff(username, password, name, gender, contactNumber, icPassport, email, address);
                    admin.RegisterTutorInToDatabase_staff_subject(username, level.ToString(), subject);
                    //need change to Patrick special messagebox
                    Notification noti = new Notification("Tutor has been registered");
                    noti.Show();
                    this.Close();
                }
                else if (!isUsernameValid && !isEmailValid && !isContactNumValid)
                {
                    txtUsername.ForeColor = Color.Red;
                    txtEmail.ForeColor = Color.Red;
                    txtContactNum.ForeColor = Color.Red;
                }
                else if (!isUsernameValid && !isEmailValid)
                {
                    txtUsername.ForeColor = Color.Red;
                    txtEmail.ForeColor = Color.Red;
                }
                else if (!isUsernameValid && !isContactNumValid)
                {
                    txtUsername.ForeColor = Color.Red;
                    txtContactNum.ForeColor = Color.Red;
                }
                else if (!isEmailValid && !isContactNumValid)
                {
                    txtEmail.ForeColor = Color.Red;
                    txtContactNum.ForeColor = Color.Red;
                }
                else if (!isUsernameValid)
                {
                    txtUsername.ForeColor = Color.Red;
                }
                else if (!isEmailValid)
                {
                    txtEmail.ForeColor = Color.Red;
                }

                else if (!isContactNumValid)
                {
                    txtContactNum.ForeColor = Color.Red;
                }
            }
            #endregion

        }

        private void radForm1_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm1.Checked)
            {
                level = 1;
            }
        }

        private void radForm2_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm2.Checked)
            {
                level = 2;
            }
        }

        private void radForm3_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm3.Checked)
            {
                level = 3;
            }
        }

        private void radForm4_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm4.Checked)
            {
                level = 4;
            }
        }

        private void radForm5_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm5.Checked)
            {
                level = 5;
            }
        }

        private void btnClear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnClear_Click(sender, e);
            }
        }

        private void btnUpload_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnUpload_Click(sender, e);
            }
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
                gender = "Male";
            }
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
            {
                gender = "Female";
            }
        }
    }
}
