/*Programmer: Matthew Moore
  Description: Bar Chart
  Date: 10-8-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Chart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in postive values between 0 and 10 for any number of test scores: ");

            string uInput = "";

            List<int> val = new List<int>();
            List<int> counts = new List<int>();
            List<string> asterisks = new List<string>();

            while (true)
            {
                Console.WriteLine("To stop adding in values, please enter in '-1'");

                uInput = Console.ReadLine();

                if (uInput == "-1")
                {
                    break;
                }

                int value = Validate(uInput);

                val.Add(value);

            }

            for (int i = 0; i < 11; i++)
            {
                counts.Add(val.Where(e => e == i).Count()); //Will find all values of i in the entire list array and then assign that to the counts list array

                Console.WriteLine($"{i}: {new string('*', counts[i])}");
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
                    Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a positive whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0 || Convert.ToInt32(uInput) > 10)
                {
                    Console.WriteLine("Your input was greater than 10 or less than 0.\nPlease re-enter your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }
    }
}
