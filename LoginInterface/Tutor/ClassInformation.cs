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
    public partial class ClassInformation : Form
    {
        private int borderSize = 6;
        public ClassInformation()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            btn_Maximize.Enabled = false;
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
        private void ClassInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tuitionManagementSystemDataSet2._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.tuitionManagementSystemDataSet2._class);
            // TODO: This line of code loads data into the 'c_assignmentDataSet2._class' table. You can move, or remove it, as needed.
//            this.classTableAdapter.Fill(this.c_assignmentDataSet2._class);

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

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.HomePageForm();
        }

        private void pnl_DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Search()
        {
            int i = 0;
            if (txt_Search.Texts != String.Empty && txt_Search.Texts != "Class ID" && int.TryParse(txt_Search.Texts,out i))
            {
                Tutor tutor = new Tutor();
                int classID = Convert.ToInt32(txt_Search.Texts);
                dgvClassInfo.DataSource = tutor.SearchClass(classID);
            }
            else
            {
                txt_Search.ForeColor = Color.Red;
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txt_Search.Texts = String.Empty;
            txt_Search.Texts = "Class ID";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable =  (DataTable)con.RetriveDataInTable($"SELECT * FROM class");
            dgvClassInfo.DataSource = dtable;
        }

        private void txt_Search_Enter_1(object sender, EventArgs e)
        {
            txt_Search.ForeColor = SystemColors.Window;
            if (txt_Search.Texts == "Student ID")
            {
                txt_Search.Texts = String.Empty;
            }
        }

        private void txt_Search_Leave_1(object sender, EventArgs e)
        {
            if (txt_Search.Texts == String.Empty)
            {
                txt_Search.Texts = "Class ID";

            }
        }

        private void txt_Search_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            Search();
        }
    }
}