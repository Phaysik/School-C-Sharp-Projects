/*Programmer: Matthew Moore
  Descripition: Hex
  Date: 9-18-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will combine the total value of a series of numbers. Please enter in a positive whole value that is less than 20");

            string uInput = Console.ReadLine();

            int value = Validate(uInput);

            long total = Calc(value);

            Console.WriteLine($"Your total of the sum of series is {total}.");

            Console.ReadLine();
        }

        public static int Validate(string uInput)
        {
            int val;
            bool value = true;

            while (value == true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0)
                {
                    Console.WriteLine("Your input was less than 0, please re-enter in positive number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) > 19)
                {
                    Console.WriteLine("Your input was greater than 19, please re-enter in a positive number: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    value = false;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static long Calc(int value)
        {
            long total = 5;

            string val = "11";

            long vals = 0;

            for(double i = 1; i < value; i++)
            {
                vals = Convert.ToInt64(val);

                total += (5 * vals);

                val += ("1");
            }

            return total;
        }
    }
}
