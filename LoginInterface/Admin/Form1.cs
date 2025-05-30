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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginInterface
{
    public partial class Form1 : Form
    {    
        private string Username, Password;
        int bordersize = 6;
        public Form1(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(64,64,64);
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
        #endregion

        private void btnMene_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width > 240)
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
        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this.Username,this.Password);
            admin.ReceptionistForm();
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
             //this.Hide();
       }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage_Admin homepage = new HomePage_Admin(this.Username,this.Password);
            homepage.Show();
            //this.Hide();
        }
        #endregion

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = String.Empty;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == String.Empty)
            {
                txtSearch.Text = "Search...";
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form4 tutor_registration = new Form4();
            tutor_registration.Show();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Form5 tutor_assign = new Form5();
            tutor_assign.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form7 tutor_delete = new Form7();
            tutor_delete.Show();
        }

        private void picClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search...";
        }

        private void Search()
        { 
            if (txtSearch.Text != string.Empty && txtSearch.Text != "Search...")
            {
                Admin admin = new Admin();
                dgvTutor.DataSource = admin.SearchTutor(txtSearch.Text);
            }
            else
            {
                txtSearch.ForeColor = Color.Red;
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.tuitionManagementSystemDataSet2.staff);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            dgvTutor.DataSource = (DataTable)con.RetriveDataInTable("SELECT * FROM staff");
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }


    }

}
