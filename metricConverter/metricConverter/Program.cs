/*Programmer: Matthew Moore
  Description: Metric Converter
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
            const decimal POUNDCONV = .220462m;

            Console.WriteLine("What is your food item: ");

            string food = Console.ReadLine();

            Console.WriteLine("What is the cost of your food item per 100 grams: ");

            decimal foodCost = Convert.ToDecimal(Console.ReadLine());

            decimal gramToPound = (foodCost / POUNDCONV);

            Console.WriteLine("\tMetric Converter");
            Console.WriteLine("\nProduct Name: {0}", food);
            Console.WriteLine("Price per 100 grams: {0:C2}", foodCost);
            Console.WriteLine("Cost per Pound: {0:C2}", gramToPound);

            Console.ReadLine();

        }
    }
}
