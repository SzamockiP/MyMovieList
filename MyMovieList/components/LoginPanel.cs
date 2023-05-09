﻿using System;
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

            // Show user account panel
            parent.SetUser(username, password);
            parent.ShowMovieSearchPanel();
        }

        private void CenterLoginForm()
        {
            int marginWidth = (Width - loginFormPnl.Width) / 2;
            int marginHeight = (Height - loginFormPnl.Height) / 2;
            loginFormPnl.Location = new Point(marginWidth, marginHeight);
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            CenterLoginForm();
        }

        private void LoginPanel_Resize(object sender, EventArgs e)
        {
            CenterLoginForm();
        }
    }
}
