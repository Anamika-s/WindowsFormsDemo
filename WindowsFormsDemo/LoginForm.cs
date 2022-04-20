using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach(var user in RegistrationForm.listUsers)
            {
                if(user.UserName == txtUserName.Text && user.Password== txtPassword.Text)
                {
                    MessageBox.Show("Valid User");
                    DetailsForm detailsForm = new DetailsForm();
                    detailsForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
        }
    }
}
