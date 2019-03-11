/*Programmer: Matthew Moore
  Decsription: Ternary
  Date: 9-10-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            string evenOrOdd = GetValue();

            DisplayInformation(evenOrOdd);

            Console.ReadLine();
        }

        public static string GetValue()
        {
            string evenOrOdd = "";

            Console.WriteLine("Please enter in a whole number: ");

            evenOrOdd = Console.ReadLine();

            long value = Validate(evenOrOdd);

            evenOrOdd = GetEvenOrOdd(value);

            return evenOrOdd;
        }

        public static long Validate(string evenOrOdd)
        {
            long val;

            while (!(long.TryParse(evenOrOdd, out val)))
            {
                Console.WriteLine("Please don't enter in letter; please re-enter in a number: ");

                evenOrOdd = Console.ReadLine();

                if ((Convert.ToInt64(evenOrOdd) % 1) != 0)
                {
                    Console.WriteLine("Please enter in a whole number: ");

                    evenOrOdd = Console.ReadLine();
                }
            }

            long value = Convert.ToInt64(evenOrOdd);

            return value;
        }

        public static string GetEvenOrOdd(long value)
        {
            return (value % 2 == 0) ? "Your number is even." : "Your number is odd.";
        }

        public static void DisplayInformation(string uInput)
        {
            Console.WriteLine(uInput);
        }
    }
}
