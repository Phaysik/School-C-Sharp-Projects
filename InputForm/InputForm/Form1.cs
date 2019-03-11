/*Programmer: Matthew Moore
   Description: Input Form
   Date: 12-11-18
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            bool isTrue = true;

            if(name == "" || name == " " || email == "" || email == " " || phone == "" || phone == " ")
            {
                MessageBox.Show("Please fill out all fields.");
                isTrue = false;
            }

            if(isTrue == true)
            {
                MessageBox.Show($"{name}\n{email}\n{phone}");
            }
        }

        private void clearInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Matthew Moore.\nVersion 1.0");
        }
    }
}
