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
            this.loginPanelBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginPanelBtn
            // 
            this.loginPanelBtn.Location = new System.Drawing.Point(30, 116);
            this.loginPanelBtn.Name = "loginPanelBtn";
            this.loginPanelBtn.Size = new System.Drawing.Size(75, 23);
            this.loginPanelBtn.TabIndex = 0;
            this.loginPanelBtn.Text = "Logowanie";
            this.loginPanelBtn.UseVisualStyleBackColor = true;
            this.loginPanelBtn.Click += new System.EventHandler(this.loginPanelBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginPanelBtn);
            this.Name = "RegisterPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginPanelBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}
