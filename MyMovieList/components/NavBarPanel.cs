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
    public partial class NavBarPanel : UserControl
    {
        public NavBarPanel()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Run parent function to show login form
            MainForm parent = (MainForm)Parent;
            parent.ShowLoginPanel();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)Parent;
            parent.ShowUserAccountPanel();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)Parent;
            parent.ShowUserMovieListPanel();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)Parent;
            parent.ShowMovieSearchPanel();
        }
    }
}
