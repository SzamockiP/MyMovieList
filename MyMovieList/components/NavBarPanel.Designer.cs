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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.listBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(668, 40);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.Location = new System.Drawing.Point(587, 40);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(75, 23);
            this.accountBtn.TabIndex = 1;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(506, 40);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(75, 23);
            this.listBtn.TabIndex = 2;
            this.listBtn.Text = "List";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(370, 40);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(130, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search Movie";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // NavBarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "NavBarPanel";
            this.Size = new System.Drawing.Size(767, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}
