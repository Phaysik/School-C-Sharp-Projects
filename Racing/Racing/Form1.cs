using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int intScore = 0, intTimes = 0, swWin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            intTimes++;

            while (picMin1.Left < 1039 && picMin2.Left < 1039 && picMin3.Left < 1039)
            {
                if (picMin1.Left < 1039)
                {
                    picMin1.Left += random.Next(1,4);
                }
                if (picMin2.Left < 1039)
                {
                    picMin2.Left += random.Next(1, 4);
                }
                if (picMin3.Left < 1039)
                {
                    picMin3.Left += random.Next(1, 4);
                }

                if(picMin1.Left >= 1039)
                {
                    MessageBox.Show("Minion 1 is the winner.");
                    swWin = 1;
                }
                if(picMin2.Left >= 1039)
                {
                    MessageBox.Show("Minion 2 is the winner.");
                    swWin = 2;
                }
                if (picMin3.Left >= 1039)
                {
                    MessageBox.Show("Minion 3 is the winner.");
                    swWin = 3;
                }

                if ((swWin == 1 && radMin1.Checked) || (swWin == 2 && radMin2.Checked) || (swWin == 3 && radMin3.Checked))
                {
                    intScore++;
                }

                System.Threading.Thread.Sleep(10);

                Refresh();
            }

            swWin = 0;

            lblScore.Text = $"{intScore.ToString()} out of {intTimes.ToString()}";

            System.Threading.Thread.Sleep(10);

            while(picMin1.Left != 35 || picMin2.Left != 35 || picMin3.Left != 35)
            {
                if(picMin1.Left > 35)
                {
                    picMin1.Left--;
                }
                if(picMin2.Left > 35)
                {
                    picMin2.Left--;
                }
                if(picMin3.Left > 35)
                {
                    picMin3.Left--;
                }

                Refresh();
            }

            btnStart.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
