﻿namespace Autus {
    partial class loginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(40)))), ((int)(((byte)(170)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(475, 579);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(438, 49);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(475, 373);
            this.txtPassword.MaxLength = 24;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Hasło";
            this.txtPassword.Size = new System.Drawing.Size(438, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(475, 302);
            this.txtLogin.MaxLength = 24;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PlaceholderText = "Login";
            this.txtLogin.Size = new System.Drawing.Size(438, 29);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1384, 749);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 788);
            this.MinimumSize = new System.Drawing.Size(1400, 788);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autus : Panel Logowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtLogin;
    }
}