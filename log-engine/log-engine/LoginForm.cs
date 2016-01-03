using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log_engine
{
    public partial class LoginForm : Form
    {
        Login login = new Login();
        public LoginForm()
        {
            InitializeComponent();            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AttemptLogin();         
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AttemptLogin();
        }

        private void AttemptLogin()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (login.CheckLogin(username, password))
            {
                descriptionLabel.Text = "Login successful!";

            }
            else descriptionLabel.Text = "Incorrect username or password, please try again.";
        }

    }
}
