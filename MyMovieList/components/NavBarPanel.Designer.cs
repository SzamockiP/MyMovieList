﻿namespace MyMovieList
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
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(222, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Wyloguj";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // NavBarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.logoutBtn);
            this.Name = "NavBarPanel";
            this.Size = new System.Drawing.Size(300, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
    }
}