using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class EditInfo : Form
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private int borderSize = 6;
        public EditInfo(string username, string password)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(37, 37, 37);
        }

        
    }
}
