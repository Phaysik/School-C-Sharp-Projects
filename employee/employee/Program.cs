/*Programmer: Matthew Moore
  Description: Calculate Employee Taxes
  Date: 8-22-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName = "Nesbith Lang";

            const decimal GROSS = .07m;
            const decimal FEDTAX = .18m;
            const decimal SS = .06m;
            const decimal RETIREMENT = .1m;

            Console.WriteLine("How much did was your total sales worth: ");

            decimal total = Convert.ToDecimal(Console.ReadLine());

            decimal grossPay = (GROSS * total);
            decimal federalTax = (FEDTAX * grossPay);
            decimal socialSecurity = (SS * grossPay);
            decimal retirement = (RETIREMENT * grossPay);
            decimal deduction = federalTax + socialSecurity + retirement;

            Console.WriteLine("\tEmployee:      " + employeeName);
            Console.WriteLine("Total Sale: \t\t\t{0:C2}",total);
            Console.WriteLine("Gross Pay (7%): \t\t{0:C2}",grossPay);
            Console.WriteLine("Federal Taxes: \t\t\t{0:C2}", federalTax);
            Console.WriteLine("Social Security Taxes: \t\t{0:C2}", socialSecurity);
            Console.WriteLine("Retirement Contribution: \t{0:C2}", retirement);
            Console.WriteLine("\t\t\t\t-----------");
            Console.WriteLine("Total Deductions: \t\t{0:C2}",deduction);
            Console.WriteLine("\nTake Home Pay:: \t\t{0:C2}", (grossPay - deduction));

            Console.ReadLine();

        }
    }
}
