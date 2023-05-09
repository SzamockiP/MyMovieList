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
            this.loginTbx = new System.Windows.Forms.TextBox();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginFormPnl = new System.Windows.Forms.Panel();
            this.loginFormPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanelBtn
            // 
            this.registerPanelBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPanelBtn.Location = new System.Drawing.Point(183, 133);
            this.registerPanelBtn.Margin = new System.Windows.Forms.Padding(10);
            this.registerPanelBtn.Name = "registerPanelBtn";
            this.registerPanelBtn.Size = new System.Drawing.Size(153, 50);
            this.registerPanelBtn.TabIndex = 0;
            this.registerPanelBtn.Text = "Register";
            this.registerPanelBtn.UseVisualStyleBackColor = true;
            this.registerPanelBtn.Click += new System.EventHandler(this.registerPanelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(10, 133);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(10);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(153, 50);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginTbx
            // 
            this.loginTbx.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.loginTbx.Location = new System.Drawing.Point(128, 7);
            this.loginTbx.Margin = new System.Windows.Forms.Padding(10);
            this.loginTbx.Name = "loginTbx";
            this.loginTbx.Size = new System.Drawing.Size(208, 43);
            this.loginTbx.TabIndex = 2;
            // 
            // passwordTbx
            // 
            this.passwordTbx.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.passwordTbx.Location = new System.Drawing.Point(128, 70);
            this.passwordTbx.Margin = new System.Windows.Forms.Padding(10);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(208, 43);
            this.passwordTbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // loginFormPnl
            // 
            this.loginFormPnl.Controls.Add(this.passwordTbx);
            this.loginFormPnl.Controls.Add(this.label1);
            this.loginFormPnl.Controls.Add(this.registerPanelBtn);
            this.loginFormPnl.Controls.Add(this.label2);
            this.loginFormPnl.Controls.Add(this.loginBtn);
            this.loginFormPnl.Controls.Add(this.loginTbx);
            this.loginFormPnl.Location = new System.Drawing.Point(132, 211);
            this.loginFormPnl.Margin = new System.Windows.Forms.Padding(0);
            this.loginFormPnl.Name = "loginFormPnl";
            this.loginFormPnl.Size = new System.Drawing.Size(346, 190);
            this.loginFormPnl.TabIndex = 6;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.loginFormPnl);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "LoginPanel";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Size = new System.Drawing.Size(721, 625);
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            this.Resize += new System.EventHandler(this.LoginPanel_Resize);
            this.loginFormPnl.ResumeLayout(false);
            this.loginFormPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerPanelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginTbx;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loginFormPnl;
    }
}
