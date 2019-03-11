/*Programmer: Matthew Moore
   Description: Carpet Calculator Classes
   Date: 10-23-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CarpetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            carpet berberCarpet = new carpet(25.99);
            carpet shagCarpet = new carpet(17.95);

            Console.WriteLine("Berber Carpet");

            berberCarpet.totSqYards = GetDimension();

            Console.WriteLine("\n\nShag Carpet");

            shagCarpet.totSqYards = GetDimension();

            Console.Clear();
            
            Console.WriteLine("Berber Carpet");
            Console.WriteLine($"{berberCarpet.ToString()}");
            Console.WriteLine("\n\nShag Carpet");
            Console.WriteLine($"{shagCarpet.ToString()}\n\nPress any key to end the program...");

            Console.ReadKey();
        }

        public static int GetDimension()
        {
            Console.WriteLine("Enter in the length of your carpet in yards: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a number: ");

                uInput = Console.ReadLine();
            }

            int length = Convert.ToInt32(uInput);

            Console.WriteLine("Enter in the width of your carpet in yards: ");

            uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a number: ");

                uInput = Console.ReadLine();
            }

            int width = Convert.ToInt32(uInput);

            return (width * length);
        }
    }
}
