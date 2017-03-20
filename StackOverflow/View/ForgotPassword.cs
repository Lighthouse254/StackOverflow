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
    public partial class fmForgotPassword : Form
    {
        public fmForgotPassword()
        {
            InitializeComponent();
            lbCodeConfirm.Text = RandomCode().ToString();
        }

        private long RandomCode()
        {
            Random rd = new Random();
            return rd.Next(00000, 99999);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            lbCodeConfirm.Text = RandomCode().ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Data.User> user = new List<Data.User>();
            user = UserService.User_CheckEmail(txtUsername.Text, txtEmail.Text);
            if (user.Count != 0)
            {
                if (txtCodeConfirm.Text == lbCodeConfirm.Text)
                {
                    fmChangeNewPassword changePass = new fmChangeNewPassword();
                    this.Hide();
                    changePass.username = txtUsername.Text;
                    changePass.ShowDialog();
                    this.Show();
                }
                else
                {
                    lbError.Text = "Code confirm is incorrect";
                    txtCodeConfirm.Text = "";
                    lbCodeConfirm.Text = RandomCode().ToString();
                    txtCodeConfirm.Focus();
                }
            }
            else
            {
                lbError.Text = "Username or Email is incorrect";
                txtUsername.Text = "";
                txtEmail.Text = "";
                lbCodeConfirm.Text = RandomCode().ToString();
                txtCodeConfirm.Text = "";
                txtUsername.Focus();
            }
        }
    }
}
