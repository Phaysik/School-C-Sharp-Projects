/*Programmer: Matthew Moore
  Description: 4 Random Numbers
  Date: 8-29-18
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

namespace fourNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal uInput = this.num1.Value;

            int num1 = Convert.ToInt32(Math.Round(uInput));

            List<int> randomNums = new List<int>();
            
            randomNums = RandomNumbers(randomNums, num1);

            txtNum1.Text = Convert.ToString(randomNums[0]);
            txtNum2.Text = Convert.ToString(randomNums[1]);
            txtNum3.Text = Convert.ToString(randomNums[2]);
            txtNum4.Text = Convert.ToString(randomNums[3]);
        }

        public static List<int> RandomNumbers(List<int> rndNums, int num1)
        {
            Random rndNumber = new Random();

            rndNums.Add(rndNumber.Next(1, num1 + 1));

            for (int l = 0; l < 3; l++)
            {
                rndNums.Add(rndNumber.Next(rndNums[l], rndNums[l] + 101));
            }

            return rndNums;
        }
    }
}
