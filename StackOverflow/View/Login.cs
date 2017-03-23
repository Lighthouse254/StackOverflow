using StackOverflow.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackOverflow.View
{
    public partial class fmLogin : Form
    {
        public string username;

        public fmLogin()
        {
            InitializeComponent();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Data.User> user = new List<Data.User>();
            user = UserService.User_CheckLogin(txtUsername.Text, txtPassword.Text);
            if (user.Count == 0)
            {
                lbIncorrect.Text = "Username or Password is incorrect";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            else
            {
                fmHomePage hp = new fmHomePage();
                hp.Show();
                this.Hide();
            }
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmSignUp su = new fmSignUp(this);
            this.Hide();
            if (su.ShowDialog() == DialogResult.OK)
            {
                this.txtUsername.Text = username;
            }
            this.Show();
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmForgotPassword forgot = new fmForgotPassword();
            this.Hide();
            forgot.ShowDialog();
            this.Show();
        }
    }
}
