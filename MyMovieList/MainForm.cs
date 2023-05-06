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
        public UserAccountPanel m_userAccountPanel = new UserAccountPanel();
        public UserMovieListPanel m_userMovieListPanel = new UserMovieListPanel();
        public MovieDetailPanel m_movieDetailPanel = new MovieDetailPanel();
        public MovieSearchPanel m_movieSearchPanel = new MovieSearchPanel();
        public NavBarPanel m_navBarPanel = new NavBarPanel();

        public MainForm()
        {
            InitializeComponent();

            // Set display properties of panels
            m_navBarPanel.Dock = DockStyle.Top;
            m_loginPanel.Dock = DockStyle.Fill;
            m_registerPanel.Dock = DockStyle.Fill;
            m_userAccountPanel.Dock = DockStyle.Fill;
            m_userMovieListPanel.Dock = DockStyle.Fill;
            m_movieDetailPanel.Dock = DockStyle.Fill;
            m_movieSearchPanel.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Clear the form
            Controls.Clear();

            // Show the login panel
            ShowLoginPanel();
        }

        private void ResetPanels()
        {
            // Reset panels to default
            m_userAccountPanel = new UserAccountPanel();
            m_userMovieListPanel = new UserMovieListPanel();
            m_movieDetailPanel = new MovieDetailPanel();
            m_movieSearchPanel = new MovieSearchPanel();
            m_navBarPanel = new NavBarPanel();

            m_userAccountPanel.Dock = DockStyle.Fill;
            m_userMovieListPanel.Dock = DockStyle.Fill;
            m_movieDetailPanel.Dock = DockStyle.Fill;
            m_movieSearchPanel.Dock = DockStyle.Fill;
            m_navBarPanel.Dock = DockStyle.Top;
        }

        public void ShowLoginPanel()
        {
            // Triggers when logging out
            if (m_isLoggedIn)
                ResetPanels();

            // Logout
            m_isLoggedIn = false;

            // Show login panel
            Controls.Clear();
            Controls.Add(m_loginPanel);
        }

        public void ShowRegisterPanel()
        {
            // Triggers when logging out
            if (m_isLoggedIn)
                ResetPanels();

            // Logout
            m_isLoggedIn = false;

            // Show register panel
            Controls.Clear();
            Controls.Add(m_registerPanel);
        }

        public void ShowUserAccountPanel(string username, string password)
        {
            // Set userAccountPanel variables to parameters
            m_userAccountPanel.SetUser(username, password);

            // Show userAccoutntPanel
            Controls.Clear();
            Controls.Add(m_navBarPanel);
            Controls.Add(m_userAccountPanel);

            // I don't know why this is needed, but it is
            // Without this, parto of the userAccountPanel will be hidden behind the navBarPanel
            // With this, the userAccountPanel will be under the navBarPanel
            m_userAccountPanel.BringToFront();
        }

        public void ShowMovieSearchPanel()
        {
            // Show movieSearchPanel
            Controls.Clear();
            Controls.Add(m_navBarPanel);
            Controls.Add(m_movieSearchPanel);
            m_movieSearchPanel.BringToFront();
        }
    }
}
