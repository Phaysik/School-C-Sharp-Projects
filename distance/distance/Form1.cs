/*Programmer: Matthew Moore
  Description: Distance Converter App
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

namespace distance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
                decimal miles = Decimal.Parse(txtMiles.Text);   //Parses the text in the hours box to decimal
                decimal feetConv = (miles * 5280m);
                decimal inchConv = (miles * 63360m);

                txtMiles.Text = miles.ToString("#,##0.00");   /*Converts the variable into a string - The "#" means to show that IF there's something there to show, 
                                                              otherwise show nothing. The "0", on the other hand, will show a "0" if that's the case or the value if it's
                                                              not zero. */
                txtFeet.Text = feetConv.ToString("###,###0.00"); /*Converts the variable into a string - the "###,###0.00" adds commas after hundredth places and will 
                                                                 add two decimal places if there are none */
                txtInches.Text = inchConv.ToString("###,###0.00");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
    }

