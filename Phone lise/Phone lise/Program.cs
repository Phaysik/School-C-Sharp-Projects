/*Programmer: Matthew Moore
   Description: Phone List
   Date: 11-26-18
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Phone_lise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneList = new string[] 
            {
                "Becky Warren, 678-1223",
                "Joe Looney, 586-0097",
                "Geri Palmer, 223-8787",
                "Lynn Persnell, 887-1212",
                "Holly Gaddis, 223-8878",
                "Sam Wiggins, 468-0998",
                "Bob Kain, 586-8712",
                "Tim Haynes, 586-7676",
                "Warren Gaddis, 223-9037",
                "Jean James, 678-4939",
                "Ron Palmer, 486-2783",
                "Kenney McCarthy, 232-7914"
            };

            Console.WriteLine("Please enter in a name or partial name to search: ");

            string name = Console.ReadLine();

            name = ValidateString(name);

            Console.Clear();

            bool isTrue = false;

            foreach (var searchName in phoneList)
            {
                if (searchName.Contains(name))
                {
                    Console.WriteLine($"{searchName}");
                    isTrue = true;
                }
            }

            if(isTrue == false)
            {
                Console.WriteLine($"Sorry, there were no matches to the given name provided: {name}.");
            }
            else
            {
                Console.WriteLine($"\nThese are all the matches to the given name provided: {name}.");
            }

            Console.WriteLine("\nPlease press any key to continue...");
            Console.ReadKey();
        }

        public static string ValidateString(string name)
        {
            while (true)
            {
                if (!Regex.IsMatch(name, @"^[A-z]"))
                {
                    Console.WriteLine("Your input was not entirely a string. Please re-enter: ");
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return name;
        }
    }
}
