/*Programmer: Matthew Moore
  Description: Overtime Work
  Date: 9-7-18
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

namespace widgetPayroll
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            decimal num2 = 0;

            decimal checkNum1 = 40, checkNum2 = 7.14m;

            int[] hours = { 40, 45, 50 };
            decimal[] hourlyPay = { 7.14m, 10.25m, 12.88m };

            if (!(Array.IndexOf(hours, (int)this.num1.Value) != -1))
            {
                MessageBox.Show("You hours worked was not a valid time. Please only enter 40, 45, or 50 hours.");
                this.num1.Value = checkNum1;
            }

            else
            {
                num1 = (int)this.num1.Value;
            }

            if (!(Array.IndexOf(hourlyPay, this.num2.Value) != -1))
            {
                MessageBox.Show("Your hourly pay rate was not valid. Please only enter 7.14, 10.25, 12.88");
                this.num2.Value = checkNum2;
            }

            else
            {
                num2 = this.num2.Value;
                Pay calc = new Pay(num1, num2);
                DisplayInformation(calc);
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void DisplayInformation(Pay pay)
        {
            txtInfo.Text = $"The total hours worked is: {pay.HoursWorked:n0}.\r\nThe hourly rate is: {pay.Rate:c2}.\r\nThe regular pay for 40 hours is: {pay.RegularPay:c2}.\r\nThe overtime pay is: {pay.Overtime:c2}.\r\nThe total pay is: {pay.Total:c2}.";
        }

        
    }
    public class Pay
    {

        public Pay(decimal num1, decimal num2)
        {
            decimal total = 0, overtime = 0, regularPay = 0;

            HoursWorked = num1;
            Rate = num2;

            if (num1 == 40)
            {
                regularPay = num1 * num2;
                total = regularPay;
            }

            else if (num1 == 45)
            {
                regularPay = ((num1 - 5) * num2);
                overtime = ((num1 - 40) * (2 * num2));
                total = regularPay + overtime;
            }

            else
            {
                regularPay = ((num1 - 10) * num2);
                overtime = ((num1 - 40) * (2 * num2));
                total = regularPay + overtime;
            }

            Overtime = overtime;
            RegularPay = regularPay;
            Total = total;
        }

        public decimal HoursWorked { get; set; }
        public decimal Rate { get; set; }
        public decimal Overtime { get; set; }
        public decimal RegularPay { get; set; }
        public decimal Total { get; set; }
    }
}

