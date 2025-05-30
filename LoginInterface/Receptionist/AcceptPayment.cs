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
    public partial class AcceptPayment : Form
    {
        private string Username, Password;
        private List<string> subsSelected = new List<string>();
        private int borderSize = 6;
        public AcceptPayment(string username, string password)
        {

            this.Username = username;
            this.Password = password;
            InitializeComponent();
            txtUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold);
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            grpSub1.Visible = false;
            grpSub3.Visible = false;
            grpSub2.Visible = false;
            btnGenerate.Enabled = false;
            btnUpdate.Enabled = false;
            btnPrint.Enabled = false;
            rtxtbReceipt.Enabled = false;
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

        private void Search()
        {
            subsSelected.Clear();
            grpSub1.Visible = false;
            grpSub3.Visible = false;
            grpSub2.Visible = false;
            Validation valid = new Validation();
            if (valid.isStudentExist(txtUsername.Texts))
            {
                Receptionist receptionist = new Receptionist();
                Dictionary<string, string> stuInfo = receptionist.RetrieveStudentData(txtUsername.Texts);
                lblName.Text = stuInfo["studentName"];
                lblCPassport.Text = stuInfo["studentIC"];
                lblContactNum.Text = stuInfo["studentContact"];
                List<string> chosenSub = receptionist.checkStuChosenSub(txtUsername.Texts);
                if (chosenSub.Count == 2)
                {
                    grpSub2.Location = new System.Drawing.Point(135, 412);
                    grpSub2.Visible = true;
                    checkBox5.Text = $"{chosenSub[0]}";
                    checkBox6.Text = $"{chosenSub[1]}";
                }
                else if (chosenSub.Count == 3)
                {
                    //grpSearcher.Size = new System.Drawing.Size(566, 836);
                    grpSub3.Visible = true;
                    grpSub3.Location = new System.Drawing.Point(106, 417);
                    checkBox1.Text = $"{chosenSub[0]}";
                    checkBox2.Text = $"{chosenSub[1]}";
                    checkBox3.Text = $"{chosenSub[2]}";
                }
                else
                {
                    //grpSearcher.Size = new System.Drawing.Size(566, 736);
                    grpSub1.Visible = true;
                    checkBox7.Text = chosenSub[0];
                    checkBox7.Checked = true;
                    subsSelected.Add(chosenSub[0]);
                }
                btnGenerate.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtUsername.ForeColor = Color.Red;
                lblContactNum.Text = "Contact Number";
                lblCPassport.Text = "IC/Passport";
                lblName.Text = "Name";
                grpSub1.Visible = false;
                grpSub3.Visible = false;
                grpSub2.Visible = false;
                btnGenerate.Enabled = false;
                btnUpdate.Enabled = false;
                btnPrint.Enabled = false;
                rtxtbReceipt.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Clear()
        {
            lblContactNum.Text = "Contact Number";
            lblCPassport.Text = "IC/Passport";
            lblName.Text = "Name";
            txtUsername.Texts = "Username";
            grpSub1.Visible = false;
            grpSub3.Visible = false;
            grpSub2.Visible = false;
            btnGenerate.Enabled = false;
            btnUpdate.Enabled = false;
            btnPrint.Enabled = false;
            rtxtbReceipt.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.ForeColor = System.Drawing.SystemColors.Window;
            if (txtUsername.Texts == "Username")
            {
                txtUsername.Texts = String.Empty;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Texts == String.Empty)
            {
                txtUsername.Texts = "Username";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (subsSelected.Count != 0)
                {
                    Receptionist receptionist = new Receptionist();
                    Dictionary<string, string> stuInfo = receptionist.RetrieveStudentData(txtUsername.Texts);
                    rtxtbReceipt.Clear();
                    rtxtbReceipt.Text += "=======================================================\n";
                    rtxtbReceipt.Text += "                       Tuition Centre Management System\n";
                    rtxtbReceipt.Text += "=======================================================\n\n\n";
                    rtxtbReceipt.Text += "Date  :" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss" + "\n\n");
                    rtxtbReceipt.Text += "Student Name :" + lblName.Text + "\n\n";
                    rtxtbReceipt.Text += "Total :" + "RM" + receptionist.GetTotal(stuInfo["studentLevel"], subsSelected) + "\n\n";
                    rtxtbReceipt.Text += "Subjects  :" + string.Join(",", subsSelected) + "\n\n";
                    rtxtbReceipt.Text += "Contact Number  :" + lblContactNum.Text + "\n\n\n\n\n\n";
                    rtxtbReceipt.Text += "Note : This receipt is computer generated and no signature is required";
                    btnPrint.Enabled = true;
                }
                else
                {
                    Notification noti = new Notification("Please at least select 1 subject!");
                    noti.Show();
                }
            }
            catch (Exception)
            {

                Notification noti = new Notification("Please Enter a valid username !");
                noti.Show();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (!subsSelected.Contains(checkBox7.Text))
                {
                    subsSelected.Add(checkBox7.Text);
                }
            }
            else
            {
                checkBox7.Checked = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                subsSelected.Add(checkBox6.Text);
            }
            else
            {
                subsSelected.Remove(checkBox6.Text);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                subsSelected.Add(checkBox5.Text);
            }
            else
            {
                subsSelected.Remove(checkBox5.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                subsSelected.Add(checkBox1.Text);
            }
            else
            {
                subsSelected.Remove(checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                subsSelected.Add(checkBox2.Text);
            }
            else
            {
                subsSelected.Remove(checkBox2.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                subsSelected.Add(checkBox3.Text);
            }
            else
            {
                subsSelected.Remove(checkBox3.Text);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtbReceipt.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
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
                Search();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Receptionist recep = new Receptionist();
                recep.UpdatePayment(txtUsername.Texts, subsSelected);
                Notification noti = new Notification("Payment has been updated");
                noti.Show();
            }
            catch (Exception)
            {
                Notification noti = new Notification("Please Enter a valid username !");
                noti.Show();
            }
        }
    }
}
