namespace StackOverflow.View
{
    partial class fmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            this.ckbShowPass = new System.Windows.Forms.CheckBox();
            this.lbIncorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StackOverflow.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(305, 308);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 29);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(305, 355);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(218, 473);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(336, 39);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.Location = new System.Drawing.Point(311, 529);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(151, 19);
            this.llbForgotPassword.TabIndex = 3;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Forgot your password?";
            this.llbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgotPassword_LinkClicked);
            // 
            // llbSignUp
            // 
            this.llbSignUp.AutoSize = true;
            this.llbSignUp.Location = new System.Drawing.Point(284, 564);
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.Size = new System.Drawing.Size(205, 19);
            this.llbSignUp.TabIndex = 4;
            this.llbSignUp.TabStop = true;
            this.llbSignUp.Text = "Don\'t have an account. Sign Up!";
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.Location = new System.Drawing.Point(244, 400);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(127, 23);
            this.ckbShowPass.TabIndex = 5;
            this.ckbShowPass.Text = "Show Password";
            this.ckbShowPass.UseVisualStyleBackColor = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // lbIncorrect
            // 
            this.lbIncorrect.AutoSize = true;
            this.lbIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lbIncorrect.Location = new System.Drawing.Point(240, 437);
            this.lbIncorrect.Name = "lbIncorrect";
            this.lbIncorrect.Size = new System.Drawing.Size(0, 19);
            this.lbIncorrect.TabIndex = 6;
            // 
            // fmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 609);
            this.Controls.Add(this.lbIncorrect);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.llbSignUp);
            this.Controls.Add(this.llbForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llbForgotPassword;
        private System.Windows.Forms.LinkLabel llbSignUp;
        private System.Windows.Forms.CheckBox ckbShowPass;
        private System.Windows.Forms.Label lbIncorrect;
    }
}