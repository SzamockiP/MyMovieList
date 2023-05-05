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
    public partial class MainForm : Form
    {
        // Set variables for user
        public string m_username;
        public string m_password;

        public bool m_isLoggedIn = false;

        // Set variables for panels
        public LoginPanel m_loginPanel = new LoginPanel();
        public RegisterPanel m_registerPanel = new RegisterPanel();
        public MovieDetailPanel m_movieDetailPanel = new MovieDetailPanel();
        public MovieSearchPanel m_movieSearchPanel = new MovieSearchPanel();
        public UserAccountPanel m_userAccountPanel = new UserAccountPanel();
        public UserMovieListPanel m_userMovieListPanel = new UserMovieListPanel();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Clear the form
            Controls.Clear();

            // Show the login panel
            ShowLoginForm();
        }

        public void ShowLoginForm()
        {
            // Logout
            m_isLoggedIn = false;

            // Show login panel
            Controls.Clear();
            Controls.Add(m_loginPanel);
        }

        public void ShowRegisterForm()
        {
            // Logout
            m_isLoggedIn = false;

            // Show register panel
            Controls.Clear();
            Controls.Add(m_registerPanel);
        }
    }
}
