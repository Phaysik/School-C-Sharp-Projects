/*Programmer: Matthew Moore
  Description: Speed of Sound
  Date: 9-11-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedofSound
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInformation();

            string value = GetValue();

            double distance = GetDistance();

            double val = Calculate(value, distance);

            Console.WriteLine($"It takes {val:n4} seconds to travel in {value}.");

            Console.ReadLine();
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("\t\tMedium\tSpeed");
            Console.WriteLine("\t\tAir\t1100 feet per second");
            Console.WriteLine("\t\tWater\t4900 feet per second");
            Console.WriteLine("\t\tSteel\t16,400 feet per second");
        }

        public static string GetValue()
        {
            string value = "";

            Console.WriteLine("\nPlease select one of the mediums: 'Air', 'Water' or 'Steel': ");

            value = Console.ReadLine();

            value = Validate(value);

            return value;
        }

        public static string Validate(string value)
        {
            while((value.ToUpper() != "AIR") && (value.ToUpper() != "WATER") && (value.ToUpper() != "STEEL"))
            {
                Console.WriteLine("Your input did not match the expected inputs. Please re-enter your choice: ");

                value = Console.ReadLine();
            }

            return value.ToLower();
        }

        public static double GetDistance()
        {
            Console.WriteLine("Please enter in what distance you would like the sound wave to travel: ");

            string val = Console.ReadLine();

            double value = ValidateDistance(val);

            return value;
        }

        public static double ValidateDistance(string val)
        {
            double value;

            while(!(double.TryParse(val, out value)))
            {
                Console.WriteLine("Your value was not a numeric value; Please re-enter in your desired distance: ");

                val = Console.ReadLine();

                if(Convert.ToDouble(val) > 0)
                {
                    Console.WriteLine("Your value cannot be negative; Please re-enter your desired distance: ");

                    val = Console.ReadLine();
                }
            }

            value = Convert.ToDouble(val);

            return value;
        }

        public static double Calculate(string value, double distance)
        {
            double val = 0;

            const int AIR = 1100;
            const int WATER = 4900;
            const int STEEL = 16400;

            if(value == "air")
            {
                val = distance / AIR;
            }
            else if(value == "water")
            {
                val = distance / WATER;
            }
            else
            {
                val = distance / STEEL;
            }

            return val;
        }
    }
}
