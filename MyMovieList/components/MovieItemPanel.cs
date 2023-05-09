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
        private string m_sqlConnectionString = Properties.Settings.Default.MyMovieList_DBConnectionString;


        public MovieItemPanel(int movieId)
        {
            InitializeComponent();
            watchedLbl.Hide();
            m_movieId = movieId;
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
                        ratingLbl.Text = reader["Rating"].ToString();

                        imageId = reader["ImageId"].ToString();

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
                    reader.Close();
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
            }
            else
            {
                watchedLbl.Show();
                m_watched = true;
            }
        }

        private void rateBtn_Click(object sender, EventArgs e)
        {
            if(m_rate == 0)
            {
                m_rate = 1;
                rateBtn.BackColor = Color.Green;
                rateBtn.Text = "+";
            }
            else if(m_rate == 1) 
            {
                m_rate = -1;
                rateBtn.BackColor = Color.Red;
                rateBtn.Text = "-";
            }
            else { 
                m_rate = 0;
                rateBtn.BackColor = Color.Ivory;
                rateBtn.Text = "=";
            }
        }

        private void watchedLbl_Click(object sender, EventArgs e)
        {
            if (m_rate == 0)
            {
                m_rate = 1;
                rateBtn.BackColor = Color.Green;
                rateBtn.Text = "+";
            }
            else if (m_rate == 1)
            {
                m_rate = -1;
                rateBtn.BackColor = Color.Red;
                rateBtn.Text = "-";
            }
            else
            {
                m_rate = 0;
                rateBtn.BackColor = Color.Ivory;
                rateBtn.Text = "=";
            }
        }
    }
}
