using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class EditInfo : Form
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private int borderSize = 6;
//        private int level;
        public EditInfo(string username, string password/* string className, string subject, string tuitionTime, string duration, string dayOfWeek, string level, string feePerMonth*/)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(37, 37, 37);
            //txtClassName.Text = className;
            //cmb_Subject.Texts = subject;
            //txtTuitionTime.Text = tuitionTime;
            //txtDuration.Text = duration;
            //cmb_DayOfWeek.Text = dayOfWeek;
            //cmbLevel.Text = level;
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

        private void pnl_Content_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            System.Windows.Forms.Application.Exit();
        }
        //Above all from Patrick
        private void infoShow()
        {
            txtClassID.ForeColor = Color.White;
            txtClassName.Text = String.Empty;
            cmb_Subject.Texts = String.Empty;
            cmbLevel.Texts = String.Empty;
            cmbLevel.Items.Clear();
            txtTuitionTime.Text = String.Empty;
            txtDuration.Text = String.Empty;
            cmb_DayOfWeek.Text = String.Empty;
            //Depends on situation, if the cmb.items repeated, then it is needed
            cmb_Subject.Items.Clear();
            Validation valid = new Validation();
            if (valid.isClassExist(txtClassID.Texts))
            {
                Tutor tutor = new Tutor();
                //int classID = Convert.ToInt32(txtClassID.Text);
                Dictionary<string, string> classInfo = tutor.RetrieveClassData(txtClassID.Texts);
                txtClassName.Text = classInfo["className"];
                cmb_Subject.Texts = classInfo["subjectName"];
                cmb_Subject.Items.Clear(); //only when repeated situation needed
                cmbLevel.Texts = classInfo["subjectLevel"];
                txtTuitionTime.Text = classInfo["startingTime"];
                txtDuration.Text = classInfo["duration"];
                cmb_DayOfWeek.Texts = classInfo["dayOfWeek"];
                for (int i = 1; i < 6; i++) 
                {
                    cmbLevel.Items.Add(i.ToString());
                }
            }
            else
            {
                txtClassID.ForeColor = Color.Red;
                btnUpdate.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            infoShow();
            txtClassID.Enabled = false;
        }

        private void updateCmb(int level)//P
        {
            //cmb_Subject.Items.Clear();
            Validation data = new Validation();
            foreach (string subject in data.GetSubjects(level))
            {
                cmb_Subject.Items.Add(subject);
            }
        }
        private void cmbLevel_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLevel.SelectedIndex == 0)
            {
                cmb_Subject.Texts = "Subject";
                //level = 1;
                cmb_Subject.Items.Clear();
                updateCmb(1);

            }
            else if (cmbLevel.SelectedIndex == 1)
            {
                cmb_Subject.Texts = "Subject";
                //level = 2;
                cmb_Subject.Items.Clear();
                updateCmb(2);
            }

            else if (cmbLevel.SelectedIndex == 2)
            {

                cmb_Subject.Texts = "Subject";
                //level = 3;
                cmb_Subject.Items.Clear();
                updateCmb(3);
            }
            else if (cmbLevel.SelectedIndex == 3)
            {

                cmb_Subject.Texts = "Subject";
                //level = 4;
                cmb_Subject.Items.Clear();
                updateCmb(4);
            }
            else if (cmbLevel.SelectedIndex == 4)
            {
                cmb_Subject.Texts = "Subject";
                //level = 5;
                cmb_Subject.Items.Clear();
                updateCmb(5);
            }
            else
            {
                cmbLevel.ForeColor = Color.Red;
                btnUpdate.Enabled = false;
            }
        }
        

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string subjectName = cmb_Subject.Texts.ToString();
            int subjectLevel = Convert.ToInt32(cmbLevel.Texts);
            bool isTimeValid, isNumberValid;
            Validation val = new Validation();
            bool[] valid = val.ValidateClassData(txtTuitionTime.Text, txtDuration.Text);
            isTimeValid = valid[0];
            isNumberValid = valid[1];

            if (isTimeValid && isNumberValid)
            {
                //If problem occure, maybe it need to convert the classid, subjectid to int because the column is int type
                btnUpdate.Enabled = true;
                Tutor tutor = new Tutor();
                string subjectID = tutor.RetriveSubject(subjectName, subjectLevel);
                tutor.UpdateClassInfo(txtClassID.Texts, txtClassName.Text, subjectID, cmb_DayOfWeek.Texts, txtTuitionTime.Text,txtDuration.Text);
            }
            else if (!isTimeValid && !isNumberValid)
            {
                btnUpdate.Enabled = false;
                txtTuitionTime.ForeColor = Color.Red;
                txtDuration.ForeColor = Color.Red;
            }

            else if (!isTimeValid)
            {
                btnUpdate.Enabled = false;
                txtTuitionTime.ForeColor = Color.Red;
            }
            else if (!isNumberValid)
            {
                btnUpdate.Enabled = false;
                txtDuration.ForeColor = Color.Red;
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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

        private void btn_AddInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.AddClassInfo();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.DeleteClassInfo();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
            txtClassID.Enabled = true;
        }
        private void Clear()
        {

            btnUpdate.Enabled = false;
            txtClassID.Texts = txtClassID.Tag.ToString();
            txtClassName.Text = txtClassName.Tag.ToString();
            cmb_Subject.Texts = cmb_Subject.Tag.ToString();
            cmbLevel.Texts = cmbLevel.Tag.ToString();
            cmbLevel.Items.Clear();
            txtTuitionTime.Text = txtTuitionTime.Tag.ToString();
            txtDuration.Text = txtDuration.Tag.ToString();
            cmb_DayOfWeek.Text = String.Empty;
            cmb_DayOfWeek.Texts = cmb_DayOfWeek.Tag.ToString();
            btnUpdate.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.HomePageForm();
        }


        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.UpdateOwnProfileForm();
        }

        private void txtClassID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                infoShow();
            }
        }

        private void txtClassID__TextChanged(object sender, EventArgs e)
        {
            txtClassID.ForeColor = Color.White;
        }

        private void txtClassID_Enter(object sender, EventArgs e)
        {
            txtClassID.ForeColor = Color.White;
            if (txtClassID.Texts == "Class ID")
            {
                txtClassID.Texts = String.Empty;
            }
        }

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
    

