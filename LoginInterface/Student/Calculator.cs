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
    public partial class Calculator : Form
    {
        private double Num { get; set; }
        private string Equation { get; set; }
        private string Operator { get; set; }
        private double Ans { get; set; }
        private int borderSize = 6;
        public Calculator()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 64, 64);
            this.Ans = 0;
            this.Equation= "";
        }
        #region Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
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
            this.Close();
        }
        #endregion

        private void btn0_Click(object sender, EventArgs e) { lblResult.Text += "0"; }
        private void btn1_Click(object sender, EventArgs e) { lblResult.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) { lblResult.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { lblResult.Text += "3"; }
        private void btn4_Click(object sender, EventArgs e) { lblResult.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { lblResult.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { lblResult.Text += "6"; }
        private void btn7_Click(object sender, EventArgs e) { lblResult.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { lblResult.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { lblResult.Text += "9"; }
        private void btnDecimal_Click(object sender, EventArgs e) { lblResult.Text += "."; }
        private void MathOperator(string new_operator)
        {
            GetNumber();
            //Get latest equation
            if (this.Num != 0)
            {
                this.Equation = this.Ans.ToString() + this.Operator + this.Num.ToString(); //6+5
                switch (this.Operator)
                {
                    case "+":
                        this.Ans += this.Num;
                        break;
                    case "-":
                        this.Ans -= this.Num;
                        break;
                    case "×":
                        this.Ans *= this.Num;
                        break;
                    case "÷":
                        this.Ans /= this.Num;
                        break;
                    case "=":
                        break;
                    default:
                        this.Ans = this.Num;
                        break;
                }
            }            
            this.Num = 0;
            this.Operator = new_operator;
            if (this.Operator == "=") 
            { this.Equation += "=" + this.Ans.ToString(); this.Ans = 0;this.Num = 0; } //6+5=11
            else if (this.Operator == "-" && this.Equation == "") //Get negative number
            { this.Equation = "-"; }
            else { this.Equation = this.Ans.ToString() + this.Operator; }// 11+
            lblEquation.Text = this.Equation;
            lblResult.Text = "";
        }
        private void GetNumber()
        {
            if (double.TryParse(lblResult.Text, out double num)) { this.Num = num; }
            else { this.Num = 0; }
        }
        private void btnAdd_Click(object sender, EventArgs e) { MathOperator("+"); }
        private void btnMinus_Click(object sender, EventArgs e)  { MathOperator("-"); }
        private void btnTimes_Click(object sender, EventArgs e) { MathOperator("×"); }
        private void btnDivision_Click(object sender, EventArgs e) { MathOperator("÷"); }
        private void btnAC_Click(object sender, EventArgs e) 
        {
            lblResult.Text = string.Empty; 
            lblEquation.Text = string.Empty; 
            this.Ans = 0;
            this.Num = 0;
            this.Equation = "";
        }
        private void btnEqual_Click(object sender, EventArgs e) 
        {
            MathOperator("=");

            this.Operator = "";
            this.Equation = "";            
            lblResult.Text = "";
        }

    }
}
