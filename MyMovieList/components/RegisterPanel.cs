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

namespace MyMovieList
{
    public partial class RegisterPanel : UserControl
    {
        private string m_sqlConnectionString;
        public RegisterPanel()
        {
            InitializeComponent();
        }



        private void CenterRegisterForm()
        {
            int marginWidth = (Width - registerFormPnl.Width) / 2;
            int marginHeight = (Height - registerFormPnl.Height) / 2;
            registerFormPnl.Location = new Point(marginWidth, marginHeight);
            m_sqlConnectionString = Properties.Settings.Default.MyMovieList_DBConnectionString;
        }

        private void RegisterPanel_Load(object sender, EventArgs e)
        {
            CenterRegisterForm();
        }

        private void RegisterPanel_SizeChanged(object sender, EventArgs e)
        {
            CenterRegisterForm();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)Parent;
            parent.ShowLoginPanel();
        }

        private void registerPanelBtn_Click(object sender, EventArgs e)
        {
            // Check if username is empty
            if (loginTbx.Text == "")
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if password is empty
            if (password1Tbx.Text == "" || password2Tbx.Text == "")
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if passwords match
            if (password1Tbx.Text != password2Tbx.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Connect to the database
            using(SqlConnection connection = new SqlConnection(m_sqlConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users WHERE Username='@login'", connection);
                    sqlCommand.Parameters.AddWithValue("@login", loginTbx.Text);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reader.Close();

                    // Add user to db
                    sqlCommand = new SqlCommand("INSERT INTO users (Username, Password) VALUES ('@login', '@pass')", connection);
                    sqlCommand.Parameters.AddWithValue("@login", loginTbx.Text);
                    sqlCommand.Parameters.AddWithValue("@pass", password1Tbx.Text);

                    sqlCommand.ExecuteNonQuery();

                    // Everything went right
                    MessageBox.Show("Register success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string username = loginTbx.Text;
                    string password = password1Tbx.Text;
                    MainForm parent = (MainForm)Parent;
                    parent.ShowLoginPanel();
                    parent.SetLoginPanelData(username, password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
