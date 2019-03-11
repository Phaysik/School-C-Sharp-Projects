/*Programmer: Matthew Moore
  Descripition: Arithmetic Progression
  Date: 9-20-18
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
            Console.WriteLine("This program will determine the sum of an arithmetic progression series.\nPlease enter in the start of the series: ");

            string uInput = Console.ReadLine();

            int startProg = Validate(uInput);

            Console.WriteLine("Please enter in the number of items in this progression series: ");

            uInput = Console.ReadLine();

            int itemProg = Validate(uInput);

            Console.WriteLine("Please enter in the common difference of this progression series: ");

            uInput = Console.ReadLine();

            int diffProg = Validate(uInput);

            int total = Calc(startProg, itemProg, diffProg);

                Console.Write($"= {total}.");


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
                else if (Convert.ToInt32(uInput) < 0)
                {
                    Console.WriteLine("Your input was less than 0, please re-enter in a whole number that is greater than 0: ");

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

        public static int Calc(int startProg, int itemProg, int diffProg)
        {
            int total = 0;
            int displayTotal = 0;

            string output = "";

            Console.WriteLine("\nThe equation used is:");

            for(int i = 0; i < itemProg; i++)
            {
                total += (startProg + (diffProg * i));
                displayTotal = (startProg + (diffProg * i));

                output += ($" {displayTotal} +");
            }

            output = output.Substring(0, (output.Length - 1));

            Console.Write(output);

            return total;
        }
    }
}
