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
    public partial class fmChangeNewPassword : Form
    {
        public string username;

        public fmChangeNewPassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    Data.User user = new Data.User();
                    user.Username = username;
                    user.Password = txtNewPassword.Text;
                    bool check = UserService.User_ForgotPassword(user);
                    if (check == true)
                    {
                        MessageBox.Show("Change Password success");
                        fmLogin lg = new fmLogin();
                        this.Hide();
                        lg.Show();
                    }
                    else
                    {
                        MessageBox.Show("Change Password fail");
                    }
                }
                else
                {
                    lbError.Text = "Confirm password wrong";
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                }
            }
            else
            {
                lbError.Text = "Fill all the fields";
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();
            }
        }
    }
}
