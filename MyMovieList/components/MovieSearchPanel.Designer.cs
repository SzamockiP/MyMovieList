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
            this.searchFormPnl = new System.Windows.Forms.Panel();
            this.searchBarPnl.SuspendLayout();
            this.searchFormPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBarPnl
            // 
            this.searchBarPnl.BackColor = System.Drawing.Color.Ivory;
            this.searchBarPnl.Controls.Add(this.searchFormPnl);
            this.searchBarPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBarPnl.Location = new System.Drawing.Point(0, 0);
            this.searchBarPnl.Name = "searchBarPnl";
            this.searchBarPnl.Size = new System.Drawing.Size(881, 80);
            this.searchBarPnl.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.searchBtn.Location = new System.Drawing.Point(444, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(111, 43);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // sortingOptionsCbx
            // 
            this.sortingOptionsCbx.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.sortingOptionsCbx.FormattingEnabled = true;
            this.sortingOptionsCbx.Location = new System.Drawing.Point(648, 3);
            this.sortingOptionsCbx.Name = "sortingOptionsCbx";
            this.sortingOptionsCbx.Size = new System.Drawing.Size(147, 45);
            this.sortingOptionsCbx.TabIndex = 1;
            // 
            // searchTbx
            // 
            this.searchTbx.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.searchTbx.Location = new System.Drawing.Point(3, 3);
            this.searchTbx.Name = "searchTbx";
            this.searchTbx.Size = new System.Drawing.Size(435, 43);
            this.searchTbx.TabIndex = 0;
            // 
            // movieListFlp
            // 
            this.movieListFlp.AutoScroll = true;
            this.movieListFlp.BackColor = System.Drawing.Color.Ivory;
            this.movieListFlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieListFlp.Location = new System.Drawing.Point(0, 80);
            this.movieListFlp.Name = "movieListFlp";
            this.movieListFlp.Size = new System.Drawing.Size(881, 353);
            this.movieListFlp.TabIndex = 1;
            this.movieListFlp.SizeChanged += new System.EventHandler(this.movieListFlp_SizeChanged);
            // 
            // searchFormPnl
            // 
            this.searchFormPnl.BackColor = System.Drawing.Color.Transparent;
            this.searchFormPnl.Controls.Add(this.searchTbx);
            this.searchFormPnl.Controls.Add(this.searchBtn);
            this.searchFormPnl.Controls.Add(this.sortingOptionsCbx);
            this.searchFormPnl.Location = new System.Drawing.Point(24, 17);
            this.searchFormPnl.Name = "searchFormPnl";
            this.searchFormPnl.Size = new System.Drawing.Size(798, 53);
            this.searchFormPnl.TabIndex = 3;
            // 
            // MovieSearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movieListFlp);
            this.Controls.Add(this.searchBarPnl);
            this.Name = "MovieSearchPanel";
            this.Size = new System.Drawing.Size(881, 433);
            this.Load += new System.EventHandler(this.MovieSearchPanel_Load);
            this.searchBarPnl.ResumeLayout(false);
            this.searchFormPnl.ResumeLayout(false);
            this.searchFormPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchBarPnl;
        private System.Windows.Forms.FlowLayoutPanel movieListFlp;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox sortingOptionsCbx;
        private System.Windows.Forms.TextBox searchTbx;
        private System.Windows.Forms.Panel searchFormPnl;
    }
}
