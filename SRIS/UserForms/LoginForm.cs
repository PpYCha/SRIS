using SRIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS.UserForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (SrisContext ctx = new SrisContext())
            {
                var user = ctx.Accounts.Where(u => u.Username.Equals(tb_Username.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password != tb_Password.Text)
                    {
                        MessageBox.Show("Invalid Password.");
                    }
                    else if (user.IsActive == false)
                    {
                        MessageBox.Show("Your Account is suspended. Please contact the administraor");


                    }
                    //else if (user.UserRole == "Clerk")
                    //{
                    //    LoginAsClerk = true;
                    //    this.Close();
                    //    this.Dispose();
                    //}

                    else
                    {
                        MainForm.isLogin = true;
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("No (" + tb_Username.Text + ") user found");
                }
            }


            Cursor.Current = Cursors.Default;


        }
    }
}
