using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_15_8
{
    public partial class LoginPasswordUserControl : UserControl
    {
        //public readonly Login {get; set;}
        //public readonly Password {get; set;}

        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }

        private void LoginPasswordUserControl_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginLabelB.Text = loginTextBox.Text;
            passwordLabelB.Text = passwordTextBox.Text;
        }
    }
}
