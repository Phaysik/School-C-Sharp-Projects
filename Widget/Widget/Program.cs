/*Programmer: Matthew Moore
   Description: Widget Factory
   Date: 10-30-18
*/

using System;
using System.Text.RegularExpressions;

namespace Widget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in how many widgets you would like to order: ");

            string uInput = Console.ReadLine();

            widgetFactory widgets = new widgetFactory(ValidateInt(uInput));

            Console.WriteLine("\nPlease enter any key to continue...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine($"It will take {widgets.TotalDays():n2} days to complete your order.");

            Console.ReadKey();
        }

        public static int ValidateInt(string uInput)
        {
            while(Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a whole positive number. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }
    }
}
