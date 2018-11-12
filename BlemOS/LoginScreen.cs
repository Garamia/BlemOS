using BlemOS.Engine;
using BlemOS.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlemOS.Main
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(UserRegistry.checkPassword(txtUsername.Text, txtPassword.Text))
            {

                this.pnlLoadingContrainer.Visible = true;
                Desktop desktop = new Desktop();
                desktop.Shown += new System.EventHandler(handleLoad);
                desktop.Show();
            }
            else
            {
                AppRegistry.loadMessageDialog("Error", "The Username/Password combination has not been recognized. Please try again.");
            }
        }
        private void handleLoad(object sender, EventArgs e)
        {
            Close();
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistry.addUser("jtsshieh", "hi123");
        }
    }
}
