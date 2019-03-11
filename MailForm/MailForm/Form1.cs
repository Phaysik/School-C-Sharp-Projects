/*Programmer: Mattthew Moore
  Description: Create a Mail Label
  Date: 8-17-18
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

namespace MailForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtEnter.Text = txtfName.Text + " " + txtlName.Text + "\n" + txtAdd.Text + "\n" + txtCity.Text + ", " + txtState.Text + "  " + txtZip.Text;
        }
    }
}
