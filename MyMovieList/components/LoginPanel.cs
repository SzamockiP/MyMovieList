using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyMovieList
{
    public partial class LoginPanel : UserControl
    {
        private string m_sqlConnectionString;
        public LoginPanel()
        {
            InitializeComponent();
            m_sqlConnectionString = Properties.Settings.Default.MyMovieList_DBConnectionString;
        }

        private void registerPanelBtn_Click(object sender, EventArgs e)
        {
            // Run parent function to show register form
            MainForm parent = (MainForm)Parent;
            parent.ShowRegisterPanel();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = loginTbx.Text;
            string password = passwordTbx.Text;

            // Check if username is empty
            if (username == "")
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if password is empty
            if (password == "")
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Connect to the database
            using (SqlConnection connection = new SqlConnection(m_sqlConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users WHERE Username='@login' AND Password='@pass'", connection);
                    sqlCommand.Parameters.AddWithValue("@login", username);
                    sqlCommand.Parameters.AddWithValue("@pass", password);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        // Set main form variables
                        MainForm parent = (MainForm)Parent;
                        string userId = reader["Id"].ToString();

                        // Show user account panel
                        parent.SetUser(username, password, userId);
                        parent.ShowMovieSearchPanel(); 

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
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

        public void SetLoginData(string username, string password)
        {
            loginTbx.Text = username;
            passwordTbx.Text = password;
        }
    }
}
