using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddThemUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Will remove the character unless it's a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNum1.Text, "[^0-9]"))
            {
                txtNum1.Text = txtNum1.Text.Remove(txtNum1.Text.Length - 1);
            }
        }
        /// <summary>
        /// Will remove the character unless it's a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNum2.Text, "[^0-9]"))
            {
                txtNum2.Text = txtNum2.Text.Remove(txtNum2.Text.Length - 1);
            }
        }

        /// <summary>
        /// Convert TextBox Values to longs, remove one from the second number to make it an even number (if it isn't), sum second num, subtract 2, loop until less than the first num
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            long num1 = Convert.ToInt64(this.txtNum1.Text), num2 = Convert.ToInt64(this.txtNum2.Text), sum = 0;

            if ((num2 % 2) != 0)
            {
                num2--;
            }

            while (num2 >= num1)
            {
                sum += num2;

                num2 -= 2;
            }

            txtDisplay.Text = sum.ToString();
        }
    }
}
