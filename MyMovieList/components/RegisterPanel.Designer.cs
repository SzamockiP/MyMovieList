namespace MyMovieList
{
    partial class RegisterPanel
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
            this.registerFormPnl = new System.Windows.Forms.Panel();
            this.password1Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPanelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginTbx = new System.Windows.Forms.TextBox();
            this.password2Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerFormPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerFormPnl
            // 
            this.registerFormPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.registerFormPnl.Controls.Add(this.password2Tbx);
            this.registerFormPnl.Controls.Add(this.registerPanelBtn);
            this.registerFormPnl.Controls.Add(this.label3);
            this.registerFormPnl.Controls.Add(this.password1Tbx);
            this.registerFormPnl.Controls.Add(this.label1);
            this.registerFormPnl.Controls.Add(this.label2);
            this.registerFormPnl.Controls.Add(this.loginBtn);
            this.registerFormPnl.Controls.Add(this.loginTbx);
            this.registerFormPnl.Location = new System.Drawing.Point(274, 146);
            this.registerFormPnl.Margin = new System.Windows.Forms.Padding(0);
            this.registerFormPnl.Name = "registerFormPnl";
            this.registerFormPnl.Size = new System.Drawing.Size(368, 252);
            this.registerFormPnl.TabIndex = 7;
            // 
            // password1Tbx
            // 
            this.password1Tbx.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.password1Tbx.Location = new System.Drawing.Point(150, 70);
            this.password1Tbx.Margin = new System.Windows.Forms.Padding(10);
            this.password1Tbx.Name = "password1Tbx";
            this.password1Tbx.Size = new System.Drawing.Size(208, 43);
            this.password1Tbx.TabIndex = 3;
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
            // registerPanelBtn
            // 
            this.registerPanelBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.registerPanelBtn.Location = new System.Drawing.Point(10, 192);
            this.registerPanelBtn.Margin = new System.Windows.Forms.Padding(10);
            this.registerPanelBtn.Name = "registerPanelBtn";
            this.registerPanelBtn.Size = new System.Drawing.Size(153, 50);
            this.registerPanelBtn.TabIndex = 0;
            this.registerPanelBtn.Text = "Register";
            this.registerPanelBtn.UseVisualStyleBackColor = true;
            this.registerPanelBtn.Click += new System.EventHandler(this.registerPanelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password 1";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.loginBtn.Location = new System.Drawing.Point(205, 192);
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
            this.loginTbx.Location = new System.Drawing.Point(150, 7);
            this.loginTbx.Margin = new System.Windows.Forms.Padding(10);
            this.loginTbx.Name = "loginTbx";
            this.loginTbx.Size = new System.Drawing.Size(208, 43);
            this.loginTbx.TabIndex = 2;
            // 
            // password2Tbx
            // 
            this.password2Tbx.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.password2Tbx.Location = new System.Drawing.Point(150, 133);
            this.password2Tbx.Margin = new System.Windows.Forms.Padding(10);
            this.password2Tbx.Name = "password2Tbx";
            this.password2Tbx.Size = new System.Drawing.Size(208, 43);
            this.password2Tbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password 2";
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.registerFormPnl);
            this.Name = "RegisterPanel";
            this.Size = new System.Drawing.Size(1000, 642);
            this.Load += new System.EventHandler(this.RegisterPanel_Load);
            this.SizeChanged += new System.EventHandler(this.RegisterPanel_SizeChanged);
            this.registerFormPnl.ResumeLayout(false);
            this.registerFormPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerFormPnl;
        private System.Windows.Forms.TextBox password2Tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerPanelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginTbx;
    }
}
