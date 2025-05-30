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
    public partial class DeleteStudent : Form
    {
        private int borderSize = 6;
        private string Username, Password;
        public DeleteStudent(string username,string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btnRemove.Enabled = false;
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

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Clear()
        {
            btnRemove.Enabled = false;
            txtUsername.ForeColor = Color.Red;
            txtUsername.Clear();
            lblContactNumber.Text = lblContactNumber.Tag.ToString();
            lblICPassport.Text = lblICPassport.Tag.ToString();
            lblName.Text = lblName.Tag.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Search()
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if ((new Validation()).isStudentExist(txtUsername.Text))
            {
                SqlDataReader dr = con.DataReader($"SELECT name,ic_number,contact_number FROM student WHERE username = '{txtUsername.Text}'");
                while (dr.Read())
                {
                    lblName.Text = dr[0].ToString();
                    lblICPassport.Text = dr[1].ToString();
                    lblContactNumber.Text = dr[2].ToString();
                }
                btnRemove.Enabled = true;
                txtUsername.ForeColor = SystemColors.Window;
            }
            else
            {
                txtUsername.ForeColor = Color.Red;
                btnDelete.Enabled = false;
                lblContactNumber.Text = lblContactNumber.Tag.ToString();
                lblICPassport.Text = lblICPassport.Tag.ToString();
                lblName.Text = lblName.Tag.ToString();
                btnRemove.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
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

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            StudentsDBView dbStu = new StudentsDBView();
            dbStu.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Receptionist recep = new Receptionist();
                recep.RemoveStudent(txtUsername.Text);
                Notification noti = new Notification("Student has been deleted");
                noti.Show();
            }
            catch (Exception)
            {

                Notification noti = new Notification("Username does not exist !");
                noti.Show();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

    }
    
}
