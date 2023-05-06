using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovieList
{
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void registerPanelBtn_Click(object sender, EventArgs e)
        {
            // Run parent function to show register form
            MainForm parent = (MainForm)this.Parent;
            parent.ShowRegisterPanel();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Get username and password
            string username = "Admin";
            string password = "Admin";

            // Set main form variables
            MainForm parent = (MainForm)this.Parent;
            parent.m_username = username;
            parent.m_password = password;
            parent.m_isLoggedIn = true;

            // Show user account panel
            parent.ShowUserAccountPanel(username, password);
        }
    }
}
