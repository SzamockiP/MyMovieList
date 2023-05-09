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

namespace MyMovieList
{
    public partial class UserMovieListPanel : UserControl
    {
        private string m_sqlConnectionString = Properties.Settings.Default.MyMovieList_DBConnectionString;
        public UserMovieListPanel()
        {
            InitializeComponent();
        }

        public void PopulateList()
        {
            // Clear list
            movieListFlp.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(m_sqlConnectionString))
            {  
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(
                        "SELECT Movies.Id, Movies.Title, Movies.ImageId " +
                        "FROM Movies " +
                        "JOIN MovieRates ON Movies.Id = MovieRates.MovieId " +
                        "WHERE MovieRates.UserId=@currentUserID", connection);

                    MainForm parent = (MainForm)Parent;
                    sqlCommand.Parameters.AddWithValue("@currentUserID", parent.m_userID);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
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

        private void UserMovieListPanel_Load(object sender, EventArgs e)
        {
            PopulateList();
            CenterItemsInList();
        }

        private void CenterItemsInList()
        {
            // get size of list panel
            int width = movieListFlp.ClientSize.Width;

            // get item width 
            if (movieListFlp.Controls.Count <= 0) return;
            int itemWidth = movieListFlp.Controls[0].Width;
            int itemMargin = movieListFlp.Controls[0].Margin.Left + movieListFlp.Controls[0].Margin.Right;

            int leftSpace = width % (itemWidth + itemMargin);

            // set padding to movieListFlp
            movieListFlp.Padding = new Padding(leftSpace / 2, 50, leftSpace / 2, 50);
        }

        private void UserMovieListPanel_SizeChanged(object sender, EventArgs e)
        {
            CenterItemsInList();
        }

        private void movieListFlp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
