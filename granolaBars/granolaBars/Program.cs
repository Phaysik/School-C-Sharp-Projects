/*Programmer: Matthew Moore
  Description: Calculate Granola Bars
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
            const int CASECOST = 100;
            const decimal BARSELL = 1.5m;
            const decimal FEES = .1m;

            Console.WriteLine("How many granola bar cases did you sell: ");

            decimal cases = Convert.ToDecimal(Console.ReadLine());

            decimal caseTotal = (cases * CASECOST);
            decimal grossSales = (caseTotal * BARSELL);
            decimal studentFees = (grossSales - caseTotal) * FEES;
            decimal proceeds = grossSales - caseTotal - studentFees;

            Console.WriteLine("\tGranola Bar Sales");
            Console.WriteLine("\nCases Sold: \t\t{0}", cases);
            Console.WriteLine("Gross Sales: \t\t{0:C2}", grossSales);
            Console.WriteLine("Product Costs: \t\t{0:C2}", caseTotal);
            Console.WriteLine("SGA Fees: \t\t{0:C2}", studentFees);
            Console.WriteLine("\nNet Proceeds: \t\t{0:C2}", proceeds);

            Console.ReadLine();

        }
    }
}
