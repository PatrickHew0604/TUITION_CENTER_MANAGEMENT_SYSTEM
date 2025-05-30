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

namespace LoginInterface
{
    public partial class Form2 : Form
    {
        private string Username, Password;
        int bordersize = 6;
        public Form2(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(64, 64, 64);
        }

        #region Dashboard Window

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region button closed,max,min
        private void btnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 240)
            {
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
                pnlMenu.Width = 130;
                picLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = String.Empty;
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
                    button.Padding = new Padding(30,0,0,0);
                }
            }
        }

        #region button menu
        private void btnTutor_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.TutorForm();
            //this.Hide();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.IncomeReportForm();
            //this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.OwnProfileForm();
            //this/Hide();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username, this.Password);
            admin.HomePage();
            //this.Hide();
        }
        #endregion

        private void Search()
        {
            if (txtSearch.Text != string.Empty && txtSearch.Text != "Search...")
            {
                Admin admin = new Admin();
                dgvReceptionist.DataSource = admin.SearchReceptionist(txtSearch.Text);
            }
            else
            {
                txtSearch.ForeColor = Color.Red;
            }
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form6 receptionist_registration = new Form6();
            receptionist_registration.Show();  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form8 receptionist_delete = new Form8();
            receptionist_delete.Show();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void picClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search...";
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search...")
            {
                txtSearch.Text = string.Empty;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.tuitionManagementSystemDataSet2.staff);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            dgvReceptionist.DataSource = (DataTable)con.RetriveDataInTable("SELECT * FROM staff");
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "Search";
            }
        }

    }
}
