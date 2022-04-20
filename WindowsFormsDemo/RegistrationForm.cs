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
    public partial class RegistrationForm : Form
    {
        public static List<User> listUsers = null;
        public RegistrationForm()
        {
            if(listUsers==null)
            {
                listUsers = new List<User>();
            }
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserId = Int16.Parse(txtUserId.Text),
                UserName = txtUserName.Text,
                FirstName = txtName.Text,
                Password = txtPassword.Text,
                Address = txtAddress.Text
            };
            MessageBox.Show("User is registered");
            listUsers.Add(user);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
