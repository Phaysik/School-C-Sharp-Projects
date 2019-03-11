/*Programmer: Matthew Moore
  Description: Ion Reality
  Date: 9-26-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonReality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will show the total of your sales, as well as the percentage each sell contributed to the total.");

            Console.WriteLine("\n\t\tPlease press any key to continue....");

            ConsoleClear();

            Console.WriteLine("Please enter in how many sales you have made over the past few months: ");

            string uInput = Console.ReadLine();

            int salesNum = ValidateInt(uInput);

            double[] sales = new double[salesNum];

            double total = GetRayVal(sales);
            double[] percentage = GetPercentage(total, sales);

            Console.WriteLine("To see resultes please press any key....");

            ConsoleClear();

            Console.WriteLine($"Your total amount of sales is {total:c2}.\n\nThese are the sales you entered and the percentage they make up of the total: ");

            for(int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Sale " + i + $" -- {sales[i]:n2} | Percentage -- {percentage[i]:n267}%");
            }

            Console.ReadLine();
        }

        public static int ValidateInt(string uInput)
        {
            int val;

            while (true)
            {

                while (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not an integer. Please re-enter in your value: ");

                    uInput = Console.ReadLine();
                }

                if (val < 0)
                {
                    Console.WriteLine("Your input was less than 0. Please re-enter in your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }

        public static double ValidateDoub(string uInput)
        {
            double val;

            while (true)
            {

                while (!(double.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not an number. Please re-enter in your value: ");

                    uInput = Console.ReadLine();
                }

                if (val < 0)
                {
                    Console.WriteLine("Your input was less than 0. Please re-enter in your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }

        public static double GetRayVal(double[] sales)
        {
            double salesVal = 0;
            double total = 0;

            string uInput = "";

            for(int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Please enter in one of your sales: ");

                uInput = Console.ReadLine();

                salesVal = ValidateDoub(uInput);

                sales[i] = salesVal;

                total += sales[i];
            }

            return total;
        }

        public static double[] GetPercentage(double total, double[] sales)
        {
            double[] percentSales = new double[sales.Length];

            for(int i = 0; i < sales.Length; i++)
            {
                percentSales[i] = ((sales[i] / total) * 100);
            }

            return percentSales;
        } 

        public static void ConsoleClear()
        {
            ConsoleKeyInfo uInput = Console.ReadKey();

            if (!Console.KeyAvailable)
            {
                Console.Clear();
            }
        }
    }
}
