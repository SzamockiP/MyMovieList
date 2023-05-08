namespace MyMovieList
{
    partial class MovieSearchPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBarPnl = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.sortingOptionsCbx = new System.Windows.Forms.ComboBox();
            this.searchTbx = new System.Windows.Forms.TextBox();
            this.movieListFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBarPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBarPnl
            // 
            this.searchBarPnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchBarPnl.Controls.Add(this.searchBtn);
            this.searchBarPnl.Controls.Add(this.sortingOptionsCbx);
            this.searchBarPnl.Controls.Add(this.searchTbx);
            this.searchBarPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBarPnl.Location = new System.Drawing.Point(0, 0);
            this.searchBarPnl.Name = "searchBarPnl";
            this.searchBarPnl.Size = new System.Drawing.Size(672, 100);
            this.searchBarPnl.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(457, 46);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "button1";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // sortingOptionsCbx
            // 
            this.sortingOptionsCbx.FormattingEnabled = true;
            this.sortingOptionsCbx.Location = new System.Drawing.Point(538, 48);
            this.sortingOptionsCbx.Name = "sortingOptionsCbx";
            this.sortingOptionsCbx.Size = new System.Drawing.Size(121, 21);
            this.sortingOptionsCbx.TabIndex = 1;
            // 
            // searchTbx
            // 
            this.searchTbx.Location = new System.Drawing.Point(16, 48);
            this.searchTbx.Name = "searchTbx";
            this.searchTbx.Size = new System.Drawing.Size(435, 20);
            this.searchTbx.TabIndex = 0;
            // 
            // movieListFlp
            // 
            this.movieListFlp.AutoScroll = true;
            this.movieListFlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieListFlp.Location = new System.Drawing.Point(0, 100);
            this.movieListFlp.Name = "movieListFlp";
            this.movieListFlp.Size = new System.Drawing.Size(672, 333);
            this.movieListFlp.TabIndex = 1;
            this.movieListFlp.SizeChanged += new System.EventHandler(this.movieListFlp_SizeChanged);
            // 
            // MovieSearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movieListFlp);
            this.Controls.Add(this.searchBarPnl);
            this.Name = "MovieSearchPanel";
            this.Size = new System.Drawing.Size(672, 433);
            this.Load += new System.EventHandler(this.MovieSearchPanel_Load);
            this.searchBarPnl.ResumeLayout(false);
            this.searchBarPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchBarPnl;
        private System.Windows.Forms.FlowLayoutPanel movieListFlp;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox sortingOptionsCbx;
        private System.Windows.Forms.TextBox searchTbx;
    }
}
