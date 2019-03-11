/*Programmer: Matthew Moore
  Descripition: Narsassistic Number
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
            Console.WriteLine("This program will determine if your number is a narsassistic number. This means that the cube of each individual number added together equals your input.\nPlease enter in a three digit number: ");

            string uInput = Console.ReadLine();

            int value = Validate(uInput);

            int total = Calc(value);

            if (total.Equals(value))
            {
                Console.WriteLine($"\n\nYour given input, {value}, was a narsassistic number.");
            }
            else
            {
                Console.WriteLine($"\n\nYou given input, {value}, was not a narsassistic number.");
            }

            Console.ReadLine();
        }

        public static int Validate(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 100)
                {
                    Console.WriteLine("Your input was less than 100, please re-enter in a whole number that is greater than 99: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) > 999)
                {
                    Console.WriteLine("Your input was greater than 999, please re-enter in a whole number that is less than 99: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static int Calc(int value)
        {
            int total = 0;

            string output = "";

            Console.WriteLine("\nThe equation used is:");

            foreach (char values in value.ToString().ToCharArray())
            {
                string values2 = values.ToString();
                int values3 = Convert.ToInt32(values2);
                total += (values3 * values3 * values3);

                output += ($" ({values2} * {values2} * {values2}) +");
            }

            output = output.Substring(0, (output.Length - 1));

            Console.Write(output);

            return total;
        }
    }
}
