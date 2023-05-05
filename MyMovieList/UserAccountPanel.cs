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
    public partial class UserAccountPanel : UserControl
    {

        public string m_username;
        public string m_password;

        public UserAccountPanel()
        {
            InitializeComponent();
        }

        public void SetUser(string username, string password)
        {
            // Set username and password
            m_username = username;
            m_password = password;

            // Set username and password labels
            usernameLbl.Text = m_username;
        }
    }
}
