using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class DeleteClass : Form
    {
        private int borderSize = 6;
        private string Username, Password;
        public DeleteClass(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btnRemove.Enabled = false;
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

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            btnRemove.Enabled = false;
            txtClassID.ForeColor = Color.Red;
            txtClassID.Clear();
            txtClassID.Text = txtClassID.Tag.ToString();
            lblClassName.Text = lblClassName.Tag.ToString();
            lblSubject.Text = lblSubject.Tag.ToString();
            lblLevel.Text = lblLevel.Tag.ToString();
            lblTuitionTime.Text = lblTuitionTime.Tag.ToString();
            lblDOW.Text = lblDOW.Tag.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtClassID_Enter(object sender, EventArgs e)
        {
            txtClassID.ForeColor = System.Drawing.SystemColors.Window;
            if (txtClassID.Text == "Class ID")
            {
                txtClassID.Clear();
            }
        }

        private void txtClassID_Leave(object sender, EventArgs e)
        {
            if (txtClassID.Text == String.Empty)
            {
                txtClassID.Text = "Class ID";
            }
        }

        private void btn_AddInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.AddClassInfo();
        }

        private void btn_ClassInfo_Click(object sender, EventArgs e)
        {
            ClassInformation viewCls = new ClassInformation();
            viewCls.Show();
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.EditClass();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            int classID = Convert.ToInt32(txtClassID.Text);
            tutor.DeleteClass(classID);
            Notification noti = new Notification("Class has been deleted");
            noti.Show();
        }

        private void txtClassID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void btn_ViewStudentList_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username,this.Password);
            tutor.EnrolStudentInClass();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor(this.Username, this.Password);
            tutor.UpdateOwnProfileForm();
        }

        private void Search()
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if ((new Validation()).isClassExist(txtClassID.Text))
            {
                SqlDataReader dr = con.DataReader($"SELECT class_name,subject_name,subject.subject_level,starting_time,day_of_week FROM class INNER JOIN subject ON class.subject_id = subject.subject_id WHERE class_id = {txtClassID.Text}");
                while (dr.Read())
                {
                    lblClassName.Text = dr[0].ToString();
                    lblSubject.Text = dr[1].ToString();
                    lblLevel.Text = dr[2].ToString();
                    lblTuitionTime.Text = dr[3].ToString();
                    lblDOW.Text = dr[4].ToString();
                }
                btnRemove.Enabled = true;
                txtClassID.ForeColor = SystemColors.Window;
            }
            else
            {
                txtClassID.ForeColor = Color.Red;
                btnDeleteClass.Enabled = false;
                lblClassName.Text = lblClassName.Tag.ToString();
                lblSubject.Text = lblSubject.Tag.ToString();
                lblLevel.Text = lblLevel.Tag.ToString();
                lblTuitionTime.Text = lblTuitionTime.Tag.ToString();
                lblDOW.Text = lblDOW.Tag.ToString();
                btnRemove.Enabled = false;
            }
        }
    }
}

