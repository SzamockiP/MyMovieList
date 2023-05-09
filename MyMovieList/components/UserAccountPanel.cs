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

        private void CenterAccountFormPanel()
        {
            int marginWidth = (Width - accountFormPnl.Width) / 2;
            int marginHeight = (Height - accountFormPnl.Height) / 2;
            accountFormPnl.Location = new Point(marginWidth, marginHeight);
        }

        private void UserAccountPanel_Load(object sender, EventArgs e)
        {
            CenterAccountFormPanel();
        }

        private void UserAccountPanel_SizeChanged(object sender, EventArgs e)
        {
            CenterAccountFormPanel();
        }
    }
}
