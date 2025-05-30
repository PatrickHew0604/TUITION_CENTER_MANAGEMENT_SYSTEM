using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginInterface
{
    public partial class UpdateEnrollMent : Form
    {
        private int borderSize = 6;
        private bool isUpdateMode = true;
        private string Username, Password;
        public UpdateEnrollMent(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            grpAddSubject.Visible = false;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btnUpload.Enabled = false;
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
        // These code allow dragging of the form !
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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
            {
                txtUsername.Text = "Username";
            }
        }

        private void btnClearUsername_Click(object sender, EventArgs e)
        {
            //InvisibleInfo(false);
            foreach (Label label in grpSearcher.Controls.OfType<Label>())
            {
                label.Text = label.Tag.ToString();
            }
            txtUsername.Clear();
            txtUsername.Text = "Username";
            txtUsername.ForeColor = SystemColors.Window;
            cmbChangedTo.Texts = String.Empty;
            cmbChosenSubject.Texts = String.Empty;
            cmbChosenSubject.Items.Clear();
            cmbChangedTo.Items.Clear();
            cmbSub.Items.Clear();
            grpAddSubject.ForeColor = SystemColors.Window;
            grpChangeTo.ForeColor = SystemColors.Window;
            grpChosenSubject.ForeColor = SystemColors.Window;
        }

        /*public void InvisibleInfo(bool control)
        {
            lblName.Visible = control;
            lblCPassport.Visible = control;
            lblContactNum.Visible = control;
            picArrow1.Visible = control;
            picArrow2.Visible = control;
            picArrow3.Visible = control;
            pnlContact.Visible = control;
            pnlICPassport.Visible = control;
            pnlName.Visible = control;
            picContact.Visible = control;
            picICPassport.Visible = control;
            picName.Visible = control;
        }*/

        private void UpdateEnrollMent_Load(object sender, EventArgs e)
        {
            //InvisibleInfo(false);
        }

        private void GroupBoxColor()
        {
            grpAddSubject.ForeColor = System.Drawing.SystemColors.Window;
            grpChangeTo.ForeColor = System.Drawing.SystemColors.Window;
            grpChosenSubject.ForeColor = System.Drawing.SystemColors.Window;
        }



        private void cmbUpdate()
        {
            cmbSub.Texts = String.Empty;
            cmbChangedTo.Texts = String.Empty;
            cmbChosenSubject.Texts = string.Empty;
            cmbSub.Items.Clear();
            cmbChangedTo.Items.Clear();
            cmbChosenSubject.Items.Clear();
            Validation valid = new Validation();
            if (valid.isStudentExist(txtUsername.Text))
            {
                List<string> chosenSub = new List<string>();
                Receptionist receptionist = new Receptionist();
                Dictionary<string, string> stuInfo = receptionist.RetrieveStudentData(txtUsername.Text);
                lblName.Text = stuInfo["studentName"];
                lblCPassport.Text = stuInfo["studentIC"];
                lblContactNum.Text = stuInfo["studentContact"];
                chosenSub = receptionist.checkStuChosenSub(txtUsername.Text);
                foreach (string sub in chosenSub)
                {
                    cmbChosenSubject.Items.Add(sub);
                }
                foreach (string subject in valid.GetSubjects(Convert.ToInt32(stuInfo["studentLevel"])))
                {
                    if (!cmbChosenSubject.Items.Contains(subject))
                    {
                        cmbChangedTo.Items.Add(subject);
                        cmbSub.Items.Add(subject);
                    }
                }
                if (chosenSub.Count > 1)
                {
                    cmbChangedTo.Items.Add("Remove");
                }
                txtUsername.ForeColor = SystemColors.Window;
                GroupBoxColor();
                btnUpload.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                txtUsername.ForeColor = Color.Red;
                //InvisibleInfo(false);
                btnUpload.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbUpdate();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //List<string> subs = new List<string>();
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Receptionist receptionist = new Receptionist();
            Dictionary<string, string> studentInfo = receptionist.RetrieveStudentData(txtUsername.Text);
            string studentLevel = studentInfo["studentLevel"];
            string studentID = studentInfo["studentID"];
            // These subsIDPair is what available to that student level !
            Dictionary<string, string> subsIDPair = receptionist.AvailableSubIDValuePair(studentLevel);
            // Drag All the subid and sub name as key value pair
            if (isUpdateMode && cmbChangedTo.Texts != string.Empty && cmbChosenSubject.Texts != string.Empty && txtUsername.Text != String.Empty)
            {
                string changeSub = cmbChosenSubject.Texts;
                string changeSubID = subsIDPair[changeSub];
                if (cmbChangedTo.Texts != "Remove")
                {

                    string changeToSub = cmbChangedTo.Texts;
                    string changeToSubID = subsIDPair[changeToSub];
                    con.UpdateData($"UPDATE student_subject SET subject_id = {changeToSubID} WHERE student_id = {studentID} AND subject_id = {changeSubID}");
                    Notification noti = new Notification("Enrollment has been updated");
                    cmbUpdate();
                    noti.Show();
                }
                else
                {
                    con.DeleteData($"DELETE FROM student_subject WHERE student_id = {studentID} AND subject_id = {changeSubID}");
                    Notification noti = new Notification("Enrollment has been updated");
                    cmbUpdate();
                    noti.Show();
                }
            }
            else if (!isUpdateMode && cmbSub.Texts != string.Empty && txtUsername.Text != String.Empty)
            {
                receptionist.EnrollSubject(txtUsername.Text, cmbSub.Texts, Convert.ToInt32(studentLevel));
                Notification noti = new Notification("Enrollment has been updated");
                cmbUpdate();
                noti.Show();
            }
            else if (txtUsername.Text == "Username")
            {
                txtUsername.ForeColor = Color.Red;
            }
            else if (isUpdateMode && cmbChosenSubject.Texts == String.Empty && cmbChangedTo.Texts == String.Empty)
            {
                grpChosenSubject.ForeColor = Color.Red;
                grpChangeTo.ForeColor = Color.Red;
            }
            else if (isUpdateMode && cmbChosenSubject.Texts == String.Empty)
            {
                grpChosenSubject.ForeColor = Color.Red;
            }
            else if (isUpdateMode && cmbChangedTo.Texts == String.Empty)
            {
                grpChangeTo.ForeColor = Color.Red;
            }
            else if (!isUpdateMode && cmbSub.Texts == String.Empty)
            {
                grpAddSubject.ForeColor = Color.Red;
            }
            con.Close();

        }


        private void btnStudentList_Click(object sender, EventArgs e)
        {
            StudentsDBView DBstu = new StudentsDBView();
            DBstu.Show();
        }

        private void btnMode_CheckedChanged(object sender, EventArgs e)
        {
            // Upload Mode
            if (btnMode.Checked)
            {
                grpChangeTo.Visible = false;
                grpChosenSubject.Visible = false;
                picExchange.Visible = false;
                grpAddSubject.Visible = true;
                if (this.WindowState != FormWindowState.Maximized)
                    grpAddSubject.Location = new Point(450, 480);
                else
                    grpAddSubject.Location = new Point(650, 520);
                lblTitle.Text = "Add Subject Enrollment";
                isUpdateMode = false;
            }
            // Change Mode
            else
            {
                grpChangeTo.Visible = true;
                grpChosenSubject.Visible = true;
                picExchange.Visible = true;
                grpAddSubject.Visible = false;
                lblTitle.Text = "Update Subject Enrollment";
                isUpdateMode = true;
            }
        }

        private void cmbChosenSubject_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            grpChosenSubject.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void cmbChangedTo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            grpChangeTo.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.RegisterStudentForm();
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

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.UpdateOwnProfileForm();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Receptionist receptionist = new Receptionist(this.Username, this.Password);
            receptionist.HomePageForm();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbUpdate();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void cmbSub_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            grpAddSubject.ForeColor = SystemColors.Window;
        }
    }
}
