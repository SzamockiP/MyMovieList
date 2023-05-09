namespace MyMovieList.components
{
    partial class MovieItemPanel
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
            this.components = new System.ComponentModel.Container();
            this.titleLbl = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.watchedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 214);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(226, 86);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Placeholder";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // watchedLbl
            // 
            this.watchedLbl.AutoSize = true;
            this.watchedLbl.BackColor = System.Drawing.Color.DimGray;
            this.watchedLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchedLbl.ForeColor = System.Drawing.Color.White;
            this.watchedLbl.Location = new System.Drawing.Point(3, 3);
            this.watchedLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.watchedLbl.Name = "watchedLbl";
            this.watchedLbl.Size = new System.Drawing.Size(86, 25);
            this.watchedLbl.TabIndex = 3;
            this.watchedLbl.Text = "Watched";
            // 
            // MovieItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.watchedLbl);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximumSize = new System.Drawing.Size(226, 300);
            this.MinimumSize = new System.Drawing.Size(226, 300);
            this.Name = "MovieItemPanel";
            this.Size = new System.Drawing.Size(226, 300);
            this.Load += new System.EventHandler(this.MovieItemPanel_Load);
            this.Click += new System.EventHandler(this.MovieItemPanel_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label watchedLbl;
    }
}
