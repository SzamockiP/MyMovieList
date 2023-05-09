namespace MyMovieList
{
    partial class NavBarPanel
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.listBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.navButtonsPnl = new System.Windows.Forms.Panel();
            this.navButtonsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.searchBtn.Location = new System.Drawing.Point(3, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(200, 50);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search Movie";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.logoutBtn.Location = new System.Drawing.Point(469, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(125, 50);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.listBtn.Location = new System.Drawing.Point(340, 3);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(125, 50);
            this.listBtn.TabIndex = 5;
            this.listBtn.Text = "My List";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.accountBtn.Location = new System.Drawing.Point(209, 3);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(125, 50);
            this.accountBtn.TabIndex = 6;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // navButtonsPnl
            // 
            this.navButtonsPnl.Controls.Add(this.searchBtn);
            this.navButtonsPnl.Controls.Add(this.accountBtn);
            this.navButtonsPnl.Controls.Add(this.logoutBtn);
            this.navButtonsPnl.Controls.Add(this.listBtn);
            this.navButtonsPnl.Location = new System.Drawing.Point(270, 12);
            this.navButtonsPnl.Margin = new System.Windows.Forms.Padding(0);
            this.navButtonsPnl.Name = "navButtonsPnl";
            this.navButtonsPnl.Size = new System.Drawing.Size(600, 59);
            this.navButtonsPnl.TabIndex = 7;
            // 
            // NavBarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.navButtonsPnl);
            this.Name = "NavBarPanel";
            this.Size = new System.Drawing.Size(870, 81);
            this.Load += new System.EventHandler(this.NavBarPanel_Load);
            this.SizeChanged += new System.EventHandler(this.NavBarPanel_SizeChanged);
            this.navButtonsPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Panel navButtonsPnl;
    }
}
