using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class MenuForm : Form
    {
        RegistrationForm registrationForm = new RegistrationForm();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.MdiParent = this;
            registrationForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result =  fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                menuStrip1.Font = fontDialog1.Font;
                registrationForm.Font = fontDialog1.Font;
            }

        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result =   colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                //RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.BackColor = colorDialog1.Color;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          

        }

        private void saveDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.WriteLine("Hello");
                writer.WriteLine("Bye");
                writer.Close();

            }

        }

        private void openDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\ClassDemos";
            openFileDialog1.Filter="txt files (*.txt) | *.txt";




            
            DialogResult result = openFileDialog1.ShowDialog();
            if(result  == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }
    }
}
