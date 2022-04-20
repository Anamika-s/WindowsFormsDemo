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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtChoice_TextChanged(object sender, EventArgs e)
        {
            if (txtChoice.Text == "1")
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }
            else if (txtChoice.Text == "2")
            {
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();
            }
            else
                MessageBox.Show("Invalid choice");
        }
    }
}
