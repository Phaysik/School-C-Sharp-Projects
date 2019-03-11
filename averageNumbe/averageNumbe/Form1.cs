/*Programmer: Mattthew Moore
  Description: Average Five Numbers
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

namespace averageNumbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            label7.Text = ((this.num1.Value + this.num2.Value + this.num3.Value + this.num4.Value + this.num5.Value) / 5).ToString();
        }
    }
}
