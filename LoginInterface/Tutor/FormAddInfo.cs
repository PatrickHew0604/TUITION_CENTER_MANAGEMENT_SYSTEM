using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class FormAddInfo : Form
    {
        private string Username { get; set; }
        private string Password { get; set; }
        public string[] StaffID { get; private set; }

        private int borderSize = 6;
        private int level = 1;
        public FormAddInfo(string username, string password)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(37, 37, 37);
            radForm1.Checked = true;
            foreach (Button button in pnl_Menu.Controls.OfType<Button>())
            {
                button.Cursor = Cursors.Hand;
            }
            foreach (Button button in pnl_Content.Controls.OfType<Button>())
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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;

            else 
            {
            this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_ClassName_Enter(object sender, EventArgs e)
        {
            txt_ClassName.ForeColor = System.Drawing.SystemColors.Window;
            if (txt_ClassName.Texts == "Class Name") 
            {
                txt_ClassName.Texts= String.Empty;
            }
        }

        private void txt_ClassName_Leave(object sender, EventArgs e)
        {
            if (txt_ClassName.Texts == String.Empty)
                txt_ClassName.Texts = "Class Name";
        }

        private void cmb_Subject_Enter(object sender, EventArgs e)
        {
            cmb_Subject.ForeColor= System.Drawing.SystemColors.Window;
            if (cmb_Subject.Texts == "Subject") 
            {
            cmb_Subject.Texts= String.Empty;
            }
        }

        private void cmb_Subject_Leave(object sender, EventArgs e)
        {
            if (cmb_Subject.Texts == String.Empty)
                cmb_Subject.Texts = "Subject";
        }

        private void txt_TuitionTime_Enter(object sender, EventArgs e)
        {
            txt_TuitionTime.ForeColor = System.Drawing.SystemColors.Window;
            if (txt_TuitionTime.Texts == "Tuition Time") 
            {
            txt_TuitionTime.Texts= String.Empty;
            }
        }

        private void txt_TuitionTime_Leave(object sender, EventArgs e)
        {
            if(txt_TuitionTime.Texts == String.Empty) 
            {
                txt_TuitionTime.Texts = "Tuition Time";
            }
        }

        private void txt_Duration_Enter(object sender, EventArgs e)
        {
            txt_Duration.ForeColor = System.Drawing.SystemColors.Window;
            if (txt_Duration.Texts == "Duration") 
            {
            txt_Duration.Texts= String.Empty;
            }
        }

        private void txt_Duration_Leave(object sender, EventArgs e)
        {
            if (txt_Duration.Texts == String.Empty) 
            {
                txt_Duration.Texts = "Duration";
            }
        }

        private void cmb_DayOfWeek_Enter(object sender, EventArgs e)
        {
            cmb_DayOfWeek.ForeColor = System.Drawing.SystemColors.Window;
            if (cmb_DayOfWeek.Texts == "Day Of Week") 
            {
            cmb_DayOfWeek.Texts = String.Empty;
            }
        }

        private void cmb_DayOfWeek_Leave(object sender, EventArgs e)
        {
            if (cmb_DayOfWeek.Texts == String.Empty) 
            {
                cmb_DayOfWeek.Texts = "Day Of Week";
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Subject.ForeColor = System.Drawing.SystemColors.Window;
            cmb_DayOfWeek.ForeColor = System.Drawing.SystemColors.Window;
            //foreach (TextBox txt in pnl_Content.Controls.OfType<TextBox>())
            //{
            //    txt.Text = txt.Tag.ToString();
            //    txt.ForeColor = System.Drawing.SystemColors.Window;
            //}
            txt_ClassName.Texts = txt_ClassName.Tag.ToString();
            txt_Duration.Texts = txt_Duration.Tag.ToString();
            txt_TuitionTime.Texts = txt_TuitionTime.Tag.ToString();
            txt_ClassName.ForeColor = System.Drawing.SystemColors.Window;
            txt_Duration.ForeColor = System.Drawing.SystemColors.Window;
            txt_TuitionTime.ForeColor = System.Drawing.SystemColors.Window;
            cmb_Subject.Texts = "Subject";
            cmb_DayOfWeek.Texts = "Day Of Week";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Decalring Variable
            bool check = true;
            string class_Name = txt_ClassName.Texts;
            string subject = cmb_Subject.Texts;
            string tuition_Time = txt_TuitionTime.Texts;
            string duration = txt_Duration.Texts;
            string day_Of_Week = cmb_DayOfWeek.Texts;
            bool isTimeValid, isNumberValid;
            #endregion

            #region Filter Empty Input
            foreach (TextBox txt in pnl_Content.Controls.OfType<TextBox>())
            {
                if (txt.Text == txt.Tag.ToString())
                {
                    check = false;
                    txt.ForeColor = Color.Red;
                }

            }
            if (cmb_Subject.Texts == "Subject")
            {
                check = false;
                cmb_Subject.ForeColor = Color.Red;
            }

            else if (cmb_DayOfWeek.Texts == "Day Of Week") 
            {
                check = false;
                cmb_DayOfWeek.ForeColor = Color.Red;
            }
            Validation val = new Validation();
            //Can't validate the className enter
            bool[] valid = val.ValidateClassData(tuition_Time, duration);
            isTimeValid = valid[0];
            isNumberValid = valid[1];
            if (!isTimeValid && !isNumberValid)
            {
                txt_TuitionTime.ForeColor = Color.Red;
                txt_Duration.ForeColor = Color.Red;
                check = false;
            //}
            //else if (!isUsernameValid && !isEmailValid)
            //{
            //    txtUsername.ForeColor = Color.Red;
            //    txtEmail.ForeColor = Color.Red;
            //    check = false;
            //}
            //else if (!isUsernameValid && !isContactNumValid)
            //{
            //    txtUsername.ForeColor = Color.Red;
            //    txtContactNum.ForeColor = Color.Red;
            //    check = false;
            //}
            //else if (!isEmailValid && !isContactNumValid)
            //{
            //    txtEmail.ForeColor = Color.Red;
            //    txtContactNum.ForeColor = Color.Red;
            //    check = false;
            }
            else if (!isTimeValid)
            {
                txt_TuitionTime.ForeColor = Color.Red;
                check = false;
            }
            else if (!isNumberValid)
            {
                txt_Duration.ForeColor = Color.Red;
                check = false;
            }

            #endregion
            if (check)
            {
                #region Validate and Insert into Database
                Tutor tutor = new Tutor();
                string subjectID = tutor.RetriveSubject(subject, level);
                string staffID = tutor.RetriveStaffID(this.Username, this.Password);
                tutor.AddInfoToDatabase( staffID, class_Name, subjectID, tuition_Time, duration, day_Of_Week);
                Notification notice = new Notification("Class has been created");
                notice.Show();
                #endregion
            }
        }

        private void btn_ViewStudentList_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.EnrolStudentInClass();
            //Form_View_Student_List viewStudent = new Form_View_Student_List();
            //viewStudent.Show();
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.EditClass();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.UpdateOwnProfileForm();
        }

        private void btn_ClassInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.ViewClassInfo();
            //ClassInformation viewClass = new ClassInformation();
            //viewClass.Show();
        }
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.DeleteClassInfo();
        }
        private void updateCmb(int level)//P
        {
            Validation data = new Validation();
            foreach (string subject in data.GetSubjects(level))
            {
                cmb_Subject.Items.Add(subject);
            }
        }

        private void rjRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm5.Checked)
            {
                if (level != 5)
                {
                    cmb_Subject.Texts = "Subject";
                    level = 5;
                }
                cmb_Subject.Items.Clear();
                updateCmb(5);
            }
        }

        private void rjRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm4.Checked)
            {
                if (level != 4)
                {
                    cmb_Subject.Texts = "Subject";
                    level = 4;
                }
                cmb_Subject.Items.Clear();
                updateCmb(4);
            }
        }

        private void rjRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm3.Checked)
            {
                if (level != 3)
                {
                    cmb_Subject.Texts = "Subject";
                    level = 3;
                }
                cmb_Subject.Items.Clear();
                updateCmb(3);
            }
        }

        private void rjRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm2.Checked)
            {
                if (level != 2)
                {
                    cmb_Subject.Texts = "Subject";
                    level = 2;
                }
                cmb_Subject.Items.Clear();
                updateCmb(2);
            }
        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radForm1.Checked)
            {
                if (level != 1)
                {
                    cmb_Subject.Texts = "Subject";
                    level = 1;
                }
                cmb_Subject.Items.Clear();
                updateCmb(1);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.HomePageForm();
        }

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}