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

namespace MyMovieList.components
{
    public partial class MovieItemPanel : UserControl
    {
        public int m_movieId;
        public int m_movieRating = 0;
        public int m_rate = 0;
        public bool m_watched = false;
        public string m_userID;
        private string m_sqlConnectionString = Properties.Settings.Default.MyMovieList_DBConnectionString;


        public MovieItemPanel(int movieId, string userId)
        {
            InitializeComponent();
            watchedLbl.Hide();
            m_movieId = movieId;
            m_userID = userId;
        }


        private void MovieItemPanel_Load(object sender, EventArgs e)
        {

            // Load movie title and image
            string imageId;

            using (SqlConnection connection = new SqlConnection(m_sqlConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Movies WHERE Id=@id", connection);
                    sqlCommand.Parameters.AddWithValue("@id", m_movieId);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        titleLbl.Text = reader["Title"].ToString();

                        imageId = reader["ImageId"].ToString();
                        reader.Close();

                        // get here data from this user, if movie is watched etc.
                        try
                        {
                            SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM MovieRates WHERE UserId=@userId AND MovieID=@movieID", connection);
                            sqlCommand2.Parameters.AddWithValue("@userID", Convert.ToInt32(m_userID));
                            sqlCommand2.Parameters.AddWithValue("@movieID", Convert.ToInt32(m_movieId));

                            SqlDataReader reader2= sqlCommand2.ExecuteReader();
                            if(reader2.Read())
                            {
                                m_rate = (int)reader2["Rate"];


                                m_watched = (bool)reader2["Watched"];

                                if (m_watched)
                                {
                                    watchedLbl.Show();
                                    m_watched = true;
                                }
                                else
                                {
                                    m_watched = false;
                                    watchedLbl.Hide();
                                }
                            }
                            reader2.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }


                        try
                        {
                            BackgroundImage = Image.FromFile(@"ImagesDB\" + imageId + ".jpg");
                        }
                        catch (Exception ex)
                        {
                            // Show error in console
                            Console.WriteLine(ex);
                        }

                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MovieItemPanel_Click(object sender, EventArgs e)
        {
            if (m_watched)
            {
                watchedLbl.Hide();
                m_watched = false;

                using (SqlConnection connection = new SqlConnection(m_sqlConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM MovieRates WHERE UserId=@userid", connection);
                        sqlCommand.Parameters.AddWithValue("@userId",m_userID);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                watchedLbl.Show();
                m_watched = true;

                using (SqlConnection connection = new SqlConnection(m_sqlConnectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand sqlCommand = new SqlCommand("INSERT INTO MovieRates(UserId,MovieId, Watched,Rate) VALUES (@userid, @movieID, 1, 0)", connection);
                        sqlCommand.Parameters.AddWithValue("@userId", m_userID);
                        sqlCommand.Parameters.AddWithValue("@movieId", m_movieId);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ratingLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
