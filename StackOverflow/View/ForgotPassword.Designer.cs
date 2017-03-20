namespace StackOverflow.View
{
    partial class fmForgotPassword
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCodeConfirm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeConfirm = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(129, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code Confirm";
            // 
            // lbCodeConfirm
            // 
            this.lbCodeConfirm.AutoSize = true;
            this.lbCodeConfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeConfirm.ForeColor = System.Drawing.Color.Red;
            this.lbCodeConfirm.Location = new System.Drawing.Point(125, 128);
            this.lbCodeConfirm.Name = "lbCodeConfirm";
            this.lbCodeConfirm.Size = new System.Drawing.Size(75, 22);
            this.lbCodeConfirm.TabIndex = 0;
            this.lbCodeConfirm.Text = "XXXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code Confirm";
            // 
            // txtCodeConfirm
            // 
            this.txtCodeConfirm.Location = new System.Drawing.Point(129, 170);
            this.txtCodeConfirm.Name = "txtCodeConfirm";
            this.txtCodeConfirm.Size = new System.Drawing.Size(245, 26);
            this.txtCodeConfirm.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandom.Image = global::StackOverflow.Properties.Resources._1489949972_Refresh;
            this.btnRandom.Location = new System.Drawing.Point(212, 128);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(26, 22);
            this.btnRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRandom.TabIndex = 2;
            this.btnRandom.TabStop = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(136, 293);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(132, 41);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(58, 228);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 19);
            this.lbError.TabIndex = 4;
            // 
            // fmForgotPassword
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 367);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtCodeConfirm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbCodeConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.btnRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCodeConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeConfirm;
        private System.Windows.Forms.PictureBox btnRandom;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbError;
    }
}