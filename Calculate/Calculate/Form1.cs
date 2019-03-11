/*Programmer: Matthew Moore
  Desciprtion: Calculater
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

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Adding your two numbers comes out to be: " + (this.num1.Value + this.num2.Value).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Subtracting your two numbers comes out to be: " + (this.num1.Value - this.num2.Value).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Dividing your two numbers comes out to be: " + (this.num1.Value / this.num2.Value).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Multiplying your two numbers comes out to be: " + (this.num1.Value * this.num2.Value).ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Using Modulus, your two numbers comes out to be: " + (this.num1.Value % this.num2.Value).ToString();
        }
    }
}
