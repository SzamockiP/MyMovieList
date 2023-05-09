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
    public partial class RegisterPanel : UserControl
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }


        private void CenterRegisterForm()
        {
            int marginWidth = (Width - registerFormPnl.Width) / 2;
            int marginHeight = (Height - registerFormPnl.Height) / 2;
            registerFormPnl.Location = new Point(marginWidth, marginHeight);
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
            // show msgbox with register success
            MessageBox.Show("Register success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string username = loginTbx.Text;
            string password = password1Tbx.Text;
            MainForm parent = (MainForm)Parent;
            parent.ShowLoginPanel();
            parent.SetLoginPanelData(username, password);
        }
    }
}
