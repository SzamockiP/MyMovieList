using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovieList.components
{
    public partial class MovieItemPanel : UserControl
    {
        public string m_movieId;
        public string m_movieTitle = "EMT";
        public float m_movieRating = 10.23f;

        public MovieItemPanel()
        {
            InitializeComponent();
        }

        private void MovieItemPanel_Load(object sender, EventArgs e)
        {
            // Load movie image
            m_movieId = "2";

            titleLbl.Text = m_movieTitle;
            ratingLbl.Text = m_movieRating.ToString();
            try
            {
                BackgroundImage = Image.FromFile(@"ImagesDB\" + m_movieId + ".jpg");
            }
            catch (Exception ex)
            {
                // Show error in console
                Console.WriteLine(ex);
            }
        }

        private void MovieItemPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
