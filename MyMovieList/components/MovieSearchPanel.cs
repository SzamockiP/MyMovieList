using MyMovieList.components;
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
using static System.Net.Mime.MediaTypeNames;

namespace MyMovieList
{
    public partial class MovieSearchPanel : UserControl
    {
        private string m_sqlConnectionString = Properties.Settings.Default.MyMovieList_DBConnectionString;
        public MovieSearchPanel()
        {
            InitializeComponent();
        }

        public void PopulateList(string searchQuery)
        {
           // clear list
            movieListFlp.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(m_sqlConnectionString))
            {
                SqlCommand sqlCommand;
                if (searchQuery != "")
                {
                    sqlCommand = new SqlCommand("SELECT * FROM Movies WHERE Title LIKE @searchQuery", connection);
                    sqlCommand.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                }
                else
                {
                    sqlCommand = new SqlCommand("SELECT * FROM Movies", connection);
                }
                try
                {
                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    MainForm parent = (MainForm)Parent;
                    while (reader.Read())
                    {
                        MovieItemPanel movieItemPanel = new MovieItemPanel((int)reader["Id"], parent.m_userID);
                        movieListFlp.Controls.Add(movieItemPanel);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CenterItemsInList()
        {
            // get size of list panel
            int width = movieListFlp.ClientSize.Width;
            if (movieListFlp.Controls.Count <= 0) return;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            movieListFlp.Controls.Clear();
            PopulateList(searchTbx.Text);
        }
    }
}
