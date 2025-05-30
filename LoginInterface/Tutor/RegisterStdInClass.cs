using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class RegisterStdInClass : Form
    {
        private int borderSize = 6;
        private string Username, Password;
        public RegisterStdInClass(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Enabled = false;
            pnl_DashBoard.BorderStyle = BorderStyle.FixedSingle;
            pnl_Content.BorderStyle = BorderStyle.FixedSingle;
            pnl_Menu.BorderStyle = BorderStyle.Fixed3D;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if ((new Validation()).isClassExist(txtClassID.Texts))
            {
                SqlDataReader dr = con.DataReader($"SELECT class_name,subject_name,subject.subject_level," +
                    $"starting_time,day_of_week FROM class INNER JOIN subject ON class.subject_id = subject.subject_id " +
                    $"WHERE class_id = {txtClassID.Texts}");
                while (dr.Read())
                {
                    lblClassName.Text = dr[0].ToString();
                    lblTuitionTime.Text = dr[3].ToString();
                    lblDOW.Text = dr[4].ToString();
                }
                btn_Clear.Enabled = true;
                txtClassID.ForeColor = Color.White;
                    
            }
            else
            {
                txtClassID.ForeColor = Color.Red;
                btn_Search.Enabled = false;
                lblClassName.Text = lblClassName.Tag.ToString();
                lblTuitionTime.Text = lblTuitionTime.Tag.ToString();
                lblDOW.Text = lblDOW.Tag.ToString();
                btnSave.Enabled = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            btnSave.Enabled = false;
            btn_Search.Enabled = true;
            txtClassID.Texts = String.Empty;
            txtStudentID.Texts = String.Empty;
            txt_ClassID.Texts = String.Empty;
            txtClassID.Texts = txtClassID.Tag.ToString();
            txtStudentID.Texts = txtStudentID.Tag.ToString();
            txt_ClassID.Texts = txt_ClassID.Tag.ToString();
            lblClassName.Text = lblClassName.Tag.ToString();
            lblTuitionTime.Text = lblTuitionTime.Tag.ToString();
            lblDOW.Text = lblDOW.Tag.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                CheckAndSave();
            
        }

        public bool IsSubjectIdMatch(List<string> stdSubID, string classSubID) 
        {
            foreach (string id in stdSubID)
            {
                if (id == classSubID)
                {
                    return false;
                }
            }
            return true;
        }

        private void CheckAndSave() 
        {
            List<string> stdSubID = new List<string>();
            Tutor tutor = new Tutor();
            #region Declare Variable
            bool check = true;
            string clsSubID = txt_ClassID.Texts;
            string stdID = txtStudentID.Texts;
            Validation valid = new Validation();
            bool isStudentIdValid = valid.isStdIdEnterValid(stdID);
            if (isStudentIdValid)
            {
                stdSubID = tutor.RetrieveSubjectView(stdID);
            }
            else
            {
                Notification noti = new Notification("Invalid Student ID");
                noti.Show();
            }
            bool isClassExist = valid.isClassExist(clsSubID);
            #endregion
            #region Filter and Validate Input
            if (txtClassID.Texts == txtClassID.Tag.ToString())
            {
                check = false;
                txtClassID.ForeColor = Color.Red;
            }

            else if (stdID == txtStudentID.Tag.ToString())
            {
                check = false;
                txtStudentID.ForeColor = Color.Red;
            }

            else if (txt_ClassID.Texts == txt_ClassID.Tag.ToString()) 
            {
                check = false;
                txt_ClassID.ForeColor = Color.Red;
            }

            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if ((new Validation()).isStudentInClass(stdID,clsSubID) && clsSubID != txtClassID.Texts)
            {
                
                check = false;
                Notification noti = new Notification("Student already in class and ClassId not match");
                noti.Show();
                txtStudentID.ForeColor = Color.Red;
                txt_ClassID.ForeColor = Color.Red;
            }

            else if (!isStudentIdValid)
            {
                check = false;
                Notification noti = new Notification("Student ID has 5 digit number,please re-enter");
                noti.Show();
            }

            else if (!isClassExist) 
            {
                check = false;
                Notification noti = new Notification("Class is not exist");
                noti.Show();
            }

            else if ((new Validation()).isStudentInClass(stdID, clsSubID))
            {
                check = false;
                Notification noti = new Notification("Student already in class");
                noti.Show();
            }

            else if (clsSubID != txtClassID.Texts)
            {
                txt_ClassID.ForeColor = Color.Red;
                check = false;
            }

            else if (IsSubjectIdMatch(stdSubID, clsSubID) == false)
            {
                check = false;
                Notification noti = new Notification("Student does not have current subject");
                noti.Show();
            }
            #endregion
            if (check)
            {
                btnSave.Enabled = true;
                tutor.RetrieveClassSubID(clsSubID);
                tutor.AssignStudentToClass(txtStudentID.Texts, txt_ClassID.Texts);
                Notification noti = new Notification("Student has been registered into class");
                noti.Show();
            }
        }

        private void txtClassID_Enter(object sender, EventArgs e)
        {
            txtClassID.ForeColor = System.Drawing.SystemColors.Window;
            btn_Search.Enabled = true;
            if (txtClassID.Texts == "Class ID")
            {
                txtClassID.Texts = String.Empty;
            }
        }

        private void txtClassID_Leave(object sender, EventArgs e)
        {
            if (txtClassID.Texts == String.Empty)
            {
                txtClassID.Texts = "Class ID";
            }
        }

        private void txtStudentID_Enter(object sender, EventArgs e)
        {
            txtStudentID.ForeColor = System.Drawing.SystemColors.Window;
            if (txtStudentID.Texts == "Student ID")
            {
                txtStudentID.Texts = String.Empty;
            }
        }

        private void txtStudentID_Leave(object sender, EventArgs e)
        {
            if (txtStudentID.Texts == String.Empty)
            {
                txtStudentID.Texts = "Student ID";
            }
        }

        private void txt_ClassID_Enter(object sender, EventArgs e)
        {
            txt_ClassID.ForeColor = System.Drawing.SystemColors.Window;
            if (txt_ClassID.Texts == "Class ID")
            {
                txt_ClassID.Texts = String.Empty;
            }
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

        private void btnViewStdList_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.ViewStdList();
        }

        private void btn_ClassInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.ViewClassInfo();
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.EditClass();
        }

        private void btn_AddInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.AddClassInfo();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.DeleteClassInfo();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.UpdateOwnProfileForm();
        }

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_ClassID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtClassID.Texts != txtClassID.Tag.ToString() && txtStudentID.Texts != txtStudentID.Tag.ToString() && txt_ClassID.Texts != txt_ClassID.Tag.ToString())
                {
                    btnSave.Enabled = true;
                }
            }
        }

        private void btnEnrolStudentClass_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.AssignStudentToClass();
        }

        private void txt_ClassID_Leave(object sender, EventArgs e)
        {
            if (txt_ClassID.Texts == String.Empty)
            {
                txt_ClassID.Texts = "Class ID";
            }
        }
    }
}
