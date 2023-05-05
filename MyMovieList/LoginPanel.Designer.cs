namespace MyMovieList
{
    partial class LoginPanel
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
            this.registerPanelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerPanelBtn
            // 
            this.registerPanelBtn.Location = new System.Drawing.Point(35, 103);
            this.registerPanelBtn.Name = "registerPanelBtn";
            this.registerPanelBtn.Size = new System.Drawing.Size(75, 23);
            this.registerPanelBtn.TabIndex = 0;
            this.registerPanelBtn.Text = "Rejestracja";
            this.registerPanelBtn.UseVisualStyleBackColor = true;
            this.registerPanelBtn.Click += new System.EventHandler(this.registerPanelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(53, 43);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Zaloguj";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registerPanelBtn);
            this.Name = "LoginPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerPanelBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}
