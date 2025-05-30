using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    public partial class HomePage : Form
    {
        private int borderSize = 6;
        private string Password;
        private string Username;
        private string Names;
        public HomePage(string username,string password,string name)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.Names = name;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            lblName.Text = this.Names;
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
                    button.Padding = new Padding(30,0,0,0);
                }
            }
        }
        // These code allow dragging of the form !
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //this.Hide();
        }

        private void btnStudentRequest_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.StudentRequestForm();
        }

        //protected override void WndProc(ref Message m)
        //{
        //const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
        //                                     //const int WM_SYSCOMMAND = 0x0112;
        //                                     //const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        //                                     //const int SC_RESTORE = 0xF120; //Restore form (Before)
        //const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        //const int resizeAreaSize = 10;
        //#region Form Resize
        //// Resize/WM_NCHITTEST values
        //const int HTCLIENT = 1; //Represents the client area of the window
        //const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        //const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        //const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        //const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        //const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        //const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        //const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        //const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
        /////<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
        //if (m.Msg == WM_NCHITTEST)
        //{ //If the windows m is WM_NCHITTEST
        //    base.WndProc(ref m);
        //    if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
        //    {
        //        if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
        //        {
        //            Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
        //            Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
        //            if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
        //            {
        //                if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
        //                    m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
        //                else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
        //                    m.Result = (IntPtr)HTTOP; //Resize vertically up
        //                else //Resize diagonally to the right
        //                    m.Result = (IntPtr)HTTOPRIGHT;
        //            }
        //            else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
        //            {
        //                if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
        //                    m.Result = (IntPtr)HTLEFT;
        //                else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
        //                    m.Result = (IntPtr)HTRIGHT;
        //            }
        //            else
        //            {
        //                if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
        //                    m.Result = (IntPtr)HTBOTTOMLEFT;
        //                else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
        //                    m.Result = (IntPtr)HTBOTTOM;
        //                else //Resize diagonally to the right
        //                    m.Result = (IntPtr)HTBOTTOMRIGHT;
        //            }
        //        }
        //    }
        //    return;
        //}
        //#endregion

        // Remove the window border and keep snap window
        //if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //{
        //    return;
        //}
        //base.WndProc(ref m);


    }
}