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
    public partial class Form1 : Form
    {
        Login login = new Login();
        public Form1()
        {
            InitializeComponent();            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (login.CheckLogin(username, password))
            {
                descriptionLabel.Text = "Login successful!";
            }
            else descriptionLabel.Text = "Wrong answer...";                        
        }
    }
}
