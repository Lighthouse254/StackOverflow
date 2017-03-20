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
    public partial class fmSignUp : Form
    {
        fmLogin login;

        public fmSignUp(fmLogin lg)
        {
            InitializeComponent();
            this.login = lg;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    bool check1 = UserService.CheckMatchUsername(txtUsername.Text);
                    bool check2 = UserService.CheckMatchEmail(txtEmail.Text);
                    if (check1 == true && check2 == true)
                    {
                        Data.User user = new Data.User();
                        user.Username = txtUsername.Text;
                        user.Password = txtPassword.Text;
                        user.Email = txtEmail.Text;
                        // need being edited
                        //user.DisplayName = "";
                        //user.Gender = "";
                        //user.Avatar = "";
                        //user.AboutMe = "";
                        //user.Career = "";
                        //user.Birthday = "";
                        //
                        bool signup = UserService.User_SignUp(user);
                        if (signup == true)
                        {
                            login.username = txtUsername.Text;
                            MessageBox.Show("Sign Up Success!");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Sign Up Fail!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Email has already existed.");
                        txtUsername.Text = "";
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        txtUsername.Focus();
                    }
                }
                else
                {
                    lbError.Text = "Confirm Password wrong";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
            {
                lbError.Text = "Fill all the fields";
                txtUsername.Focus();
            }
        }

        private void fmSignUp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
