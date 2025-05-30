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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginInterface
{
    public partial class Form5 : Form
    {
        private int bordersize = 6;
        private int level;
        public Form5()
        {
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(64, 64, 64);
        }

        #region Dashboard Window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region button close,max,min
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion





        private void cmbSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                grpLevel.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = System.Drawing.SystemColors.Window;
            }
            foreach (RadioButton radioButton in grpLevel.Controls.OfType<RadioButton>())
                if (radioButton.Checked)
                    radioButton.Checked = false;
        }

        private void radForm1_CheckedChanged(object sender, EventArgs e)
        {
            if(radForm1.Checked)
            {
                level = 1;
            }
        }

        private void radForm2_CheckedChanged(object sender, EventArgs e)
        {
            if(radForm2.Checked)
            {
                level = 2;
            }
        }

        private void radFrom3_CheckedChanged(object sender, EventArgs e)
        {
            if(radForm3.Checked)
            {
                level = 3;
            }
        }

        private void radForm4_CheckedChanged(object sender, EventArgs e)
        {
            if(radForm4.Checked)
            {
                level = 4;
            }
        }

        private void radForm5_CheckedChanged(object sender, EventArgs e)
        {
            if(radForm5.Checked)
            {
                level = 5;
            }
        }

        private void cmbUpdate()
        {
            cmbChangedTo.Texts = String.Empty;
            cmbChosenSubject.Texts = string.Empty;
            cmbChangedTo.Items.Clear();
            cmbChosenSubject.Items.Clear();
            List<string> subs = new List<string>();
            Validation data = new Validation();
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd_tutor = con.DataReader
                ($"SELECT name,ic_number,contact_number FROM staff WHERE username = '{txtUsername.Text}'");
            while (drd_tutor.Read())
            {
                con.EstablishConnection();
                lblName.Text = drd_tutor[0].ToString();
                lblICPassport.Text = drd_tutor[1].ToString();
                lblContactNumber.Text = drd_tutor[2].ToString();
                con.Close();
            }
            con.EstablishConnection();
            int staff_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{txtUsername.Text}'"));
            int subject_ID = Convert.ToInt32(con.RetrieveData($"SELECT subject_id FROM staff_subject WHERE staff_id = {staff_ID}"));
            SqlDataReader drd_tutor_sub = con.DataReader($"SELECT subject_name FROM subject WHERE subject_id = {subject_ID}");
            while (drd_tutor_sub.Read())
            {
                subs.Add(drd_tutor_sub[0].ToString());
            }
            if (!drd_tutor.HasRows)
            {
                txtUsername.ForeColor = Color.Red;
                btnAssign.Enabled = false;
            }
            else
            {
                txtUsername.ForeColor = SystemColors.Window;
                btnAssign.Enabled = true;
                foreach (string subject in subs)
                {
                    cmbChosenSubject.Items.Add(subject);
                }
                foreach (string subject in data.Subjects)
                {
                    if (!cmbChosenSubject.Items.Contains(subject))
                    {
                        cmbChangedTo.Items.Add(subject);
                    }
                }
            }
            con.Close();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbUpdate();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                cmbUpdate();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.White;
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = string.Empty;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.White;
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (Label label in pnlDisplay.Controls.OfType<Label>())
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
        }



        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbChangedTo.Texts != string.Empty && cmbChosenSubject.Texts != string.Empty && txtUsername.Text != String.Empty)
            {
                DBConnection con = new DBConnection();
                con.EstablishConnection();
                int staff_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{txtUsername.Text}'"));
                int subject_ID_ori = Convert.ToInt32(con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_name = '{cmbChosenSubject.Texts}'"));
                int subject_ID_change = Convert.ToInt32(con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_name = '{cmbChangedTo.Texts}' AND subject_level = {level}"));
                con.UpdateData
                        ($"UPDATE staff_subject SET subject_id = {subject_ID_change} WHERE subject_id = {subject_ID_ori} AND staff_id = {staff_ID}");
                //need to change to Patrcik special message box
                Notification noti = new Notification("Subject has been updated");
                noti.Show();
                this.Close();
                cmbUpdate();
                con.Close();
            }
            else
            {
                //need to change to Patrcik special message box
                Notification noti = new Notification("Please choose all the choices");
                noti.Show();
            }
        }
            
            

        private void cmbChosenSubject_Enter(object sender, EventArgs e)
        {
            grpLevel.Enabled = true;
            Admin admin = new Admin();
            int Level = admin.TutorSubjectLevel(txtUsername.Text, cmbChosenSubject.Texts);
            if(Level == 1)
            {
                radForm1.Checked = true;
            }
            else if(Level == 2)
            {
                radForm2.Checked = true;
            }
            else if(Level == 3)
            {
                radForm3.Checked = true;
            }
            else if(Level == 4)
            {
                radForm4.Checked = true;
            }
            else if(Level == 5)
            {
                radForm5.Checked = true;
            }
        }

    }
}

