/*Programmer: Matthew Moore
  Description: Sun Projects
  Date: 8-21-18
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

namespace sunProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal hours = Decimal.Parse(txtHours.Text);   //Parses the text in the hours box to decimal
            decimal payRate = Decimal.Parse(txtRate.Text);
            decimal grossPay = (hours * payRate);
            decimal FWT = (grossPay / 5);
            decimal FICA = (grossPay * .08m);
            decimal Tax = (grossPay * .025m);
            decimal netPay = grossPay - (Tax + FICA + FWT);

            txtGross.Text = Convert.ToString(Math.Round(grossPay, 2));   //Round the variable to two decimal places and then converts it to a string
            txtFWT.Text = Convert.ToString(Math.Round(FWT, 2));
            txtFICA.Text = Convert.ToString(Math.Round(FICA, 2));
            txtTax.Text = Convert.ToString(Math.Round(Tax, 2));
            txtPay.Text = "$" + Convert.ToString(Math.Round(netPay, 2));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1); //Close out of the program
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
