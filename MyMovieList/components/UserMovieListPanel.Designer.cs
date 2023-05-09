namespace MyMovieList
{
    partial class UserMovieListPanel
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
            this.movieListFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // movieListFlp
            // 
            this.movieListFlp.AutoScroll = true;
            this.movieListFlp.BackColor = System.Drawing.Color.Ivory;
            this.movieListFlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieListFlp.Location = new System.Drawing.Point(0, 0);
            this.movieListFlp.Name = "movieListFlp";
            this.movieListFlp.Size = new System.Drawing.Size(748, 627);
            this.movieListFlp.TabIndex = 2;
            // 
            // UserMovieListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movieListFlp);
            this.Name = "UserMovieListPanel";
            this.Size = new System.Drawing.Size(748, 627);
            this.Load += new System.EventHandler(this.UserMovieListPanel_Load);
            this.SizeChanged += new System.EventHandler(this.UserMovieListPanel_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel movieListFlp;
    }
}
