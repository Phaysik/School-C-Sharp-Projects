/*Programmer: Matthew Moore
 * Description: Calculate the profit ratio
 * Date: 9-10-18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profitRatio
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal profit = GetInfo();

            decimal percentage = Calculate(profit);

            Console.WriteLine("Your sales are {0:c2} and your profit ratio is {1}%.", profit, percentage);

            Console.ReadLine();
        }

        public static decimal GetInfo()
        {
            Console.WriteLine("Please enter in how much the total sales figure for your organization is: ");

            string uInput = Console.ReadLine();

            decimal value = Validate(uInput);

            return value;
        }

        public static decimal Validate(string uInput)
        {
            decimal val;

            while(!(decimal.TryParse(uInput, out val)))
            {
                Console.WriteLine("Please enter in a numeric value: ");

                uInput = Console.ReadLine();

                if(Convert.ToDecimal(uInput) < 0)
                {
                    Console.WriteLine("Please enter in a number greater than 0: ");

                    uInput = Console.ReadLine();
                }
            }

            val = Convert.ToDecimal(uInput);

            return val;
        }

        public static decimal Calculate(decimal profit)
        {
            decimal percentage = 0;

            if(profit >= 0 && profit <= 1000)
            {
                percentage = 3;
            }
            else if(profit > 1000 && profit <= 5000)
            {
                percentage = 3.5m;
            }
            else if(profit > 5000 && profit <= 10000)
            {
                percentage = 4;
            }
            else
            {
                percentage = 4.5m;
            }

            return percentage;
        }
    }
}
