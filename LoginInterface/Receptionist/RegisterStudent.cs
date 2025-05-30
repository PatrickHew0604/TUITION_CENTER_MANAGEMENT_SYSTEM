using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;


namespace LoginInterface
{
    public partial class RegisterStudent : Form
    {
        private string username;
        private string password;
        private int count = 1;
        private int borderSize = 6;
        private int level = 1;
        private string gender = "Male";
        public RegisterStudent(string username,string password)
        {
            this.password = password;
            this.username = username;
            InitializeComponent();
            radForm1.Checked = true;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            pnlDashboard.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
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

        private void updateCmb(int level)
        {
            Validation data = new Validation();
            foreach (string subject in data.GetSubjects(level))
            {
                cmbSubject.Items.Add(subject);
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.ForeColor = System.Drawing.SystemColors.Window;
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == String.Empty)
                txtUsername.Text = "Username";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
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

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.ForeColor = System.Drawing.SystemColors.Window;
            if (txtName.Text == String.Empty)
                txtName.Text = "Name";
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Clear();
                txtName.ForeColor = System.Drawing.SystemColors.Window;
            }
        }

        private void txtICPassport_Enter(object sender, EventArgs e)
        {
            txtICPassport.ForeColor = System.Drawing.SystemColors.Window;
            if (txtICPassport.Text == "IC/Passport")
                txtICPassport.Clear();
        }

        private void txtICPassport_Leave(object sender, EventArgs e)
        {
            if (txtICPassport.Text == String.Empty)
                txtICPassport.Text = "IC/Passport";
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == String.Empty)
                txtEmail.Text = "Email";

        }

        private void txtContactNum_Enter(object sender, EventArgs e)
        {
            txtContactNum.ForeColor = System.Drawing.SystemColors.Window;
            if (txtContactNum.Text == "Contact Number")
            {
                txtContactNum.Clear();
            }
        }
        private void txtContactNum_Leave(object sender, EventArgs e)
        {
            if (txtContactNum.Text == String.Empty)
                txtContactNum.Text = "Contact Number";
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
            string subject = cmbSubject.Texts;
            bool isUsernameValid,isEmailValid,isContactNumValid;
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
            if (cmbSubject.Texts == "Subject" || cmbSubject.Texts == "")
            {
                cmbSubject.Texts = "Subject";
                cmbSubject.ForeColor = Color.Red;
                check = false;
            }
            Validation val = new Validation();
            bool[] valid = val.ValidateStudentData(username, email, contactNumber);
            isUsernameValid = valid[0];
            isEmailValid = valid[1];
            isContactNumValid = valid[2];
            if (!isUsernameValid)
            {
                txtUsername.ForeColor = Color.Red;
                Notification noti = new Notification("This username has been used by the others");
                noti.Show();
                check = false;
            }
            if (!isEmailValid)
            {
                txtEmail.ForeColor = Color.Red;
                check = false;
            }
            if (!isContactNumValid)
            {
                txtContactNum.ForeColor = Color.Red;
                check = false;
            }
       
            #endregion
            if (check)
            {
                #region Validate And Insert into Database
                Receptionist receptionis = new Receptionist();
                receptionis.RegisterStudent(username, password, name, icPassport, email, contactNumber, gender, level.ToString());
                receptionis.EnrollSubject(username, subject, level);
                Notification noti = new Notification("Student has been registered");
                noti.Show();
            }
            #endregion
        }

        private void radForm1_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm1.Checked)
            {
                if (level != 1)
                {
                    cmbSubject.Texts = "Subject";
                    level = 1;
                }
                cmbSubject.Items.Clear();
                updateCmb(1);
            }
        }

        private void radForm2_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm2.Checked)
            {
                if (level != 2)
                {
                    cmbSubject.Texts = "Subject";
                    level = 2;
                }
                cmbSubject.Items.Clear();
                updateCmb(2);
            }
        }

        private void radFrom3_CheckedChanged(object sender, EventArgs e)
        {
            if (radFrom3.Checked)
            {
                if (level != 3)
                {
                    cmbSubject.Texts = "Subject";
                    level = 3;
                }
                cmbSubject.Items.Clear();
                updateCmb(3);
            }
        }

        private void radForm4_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm4.Checked)
            {
                if (level != 4)
                {
                    cmbSubject.Texts = "Subject";
                    level = 4;
                }
                cmbSubject.Items.Clear();
                updateCmb(4);
            }
        }

        private void radForm5_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm5.Checked)
            {
                if (level != 5)
                {
                    cmbSubject.Texts = "Subject";
                    level = 5;
                }
                cmbSubject.Items.Clear();
                updateCmb(5);
            }
        }

        private void cmbSubject_Enter(object sender, EventArgs e)
        {
            cmbSubject.ForeColor = System.Drawing.SystemColors.Window;
        }


        private void btnUpdateEnrollment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.username, this.password);
            receptionist.UpdateEnrollmentForm();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.username, this.password);
            receptionist.ReceivePaymentForm();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.username, this.password);
            receptionist.DeleteStudentForm();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.username, this.password);
            receptionist.UpdateOwnProfileForm();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.username, this.password);
            receptionist.HomePageForm();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            StudentsDBView dbStu = new StudentsDBView();
            dbStu.Show();
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
