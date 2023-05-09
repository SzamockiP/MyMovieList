using MyMovieList.components;
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
    public partial class MovieSearchPanel : UserControl
    {
        public MovieSearchPanel()
        {
            InitializeComponent();
        }

        private void PopulateList(string searchQuery)
        {    
            // populate movieListFlp with 10 MovieItemPanels
            for (int x = 0; x < 10; x++)
            {
                MovieItemPanel movieItemPanel = new MovieItemPanel();
                movieListFlp.Controls.Add(movieItemPanel);
            }
        }

        private void CenterItemsInList()
        {
            // get size of list panel
            int width = movieListFlp.ClientSize.Width;

            // get item width 
            int itemWidth = movieListFlp.Controls[0].Width;
            int itemMargin = movieListFlp.Controls[0].Margin.Left + movieListFlp.Controls[0].Margin.Right;

            int leftSpace = width % (itemWidth + itemMargin);

            // set padding to movieListFlp
            movieListFlp.Padding = new Padding(leftSpace / 2, 0, leftSpace / 2, 50);
        }

        private void MovieSearchPanel_Load(object sender, EventArgs e)
        {
            movieListFlp.CausesValidation = false;
            PopulateList("");
            CenterItemsInList();
            CenterSearchFormPanel();
        }

        private void movieListFlp_SizeChanged(object sender, EventArgs e)
        {
            CenterItemsInList();
            CenterSearchFormPanel();
        }

        private void CenterSearchFormPanel()
        {
            int marginHeight = (searchBarPnl.Height - searchFormPnl.Height) / 2;
            int marginWidth = (searchBarPnl.Width - searchFormPnl.Width) / 2;
            searchFormPnl.Location = new Point(marginWidth, marginHeight);
        }
    }
}
