using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TripClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Trip newTrip = new Trip();

            newTrip.Destination = GetDestination();
            newTrip.DistanceTraveled = GetDistanceTraveled();
            newTrip.TotalCostOfGasoline = GetTotalCostOfGasoline();
            newTrip.NumberOfGallonsConsumed = GetNumberOfGallonsConsumed();

            Console.Clear();
            Console.WriteLine(newTrip.ToString() + "\n\nPress any key to continue...");

            Console.ReadKey();
        }

        public static string GetDestination()
        {
            Console.WriteLine("Please enter your destination: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[a-zA-Z ]+$") == false)
            {
                Console.WriteLine("Your input was not completely letters; please re-enter: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static int GetNumberOfGallonsConsumed()
        {
            Console.WriteLine("Please enter your total number of gallons consumed as a whole number: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a positive whole number. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }

        public static double GetTotalCostOfGasoline()
        {
            Console.WriteLine("Please enter your total cost of gasoline: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"-?\d+(?:\.\d+)?") == false)
            {
                Console.WriteLine("Your input was not a positive numeric value. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToDouble(uInput);
        }

        public static double GetDistanceTraveled()
        {
            Console.WriteLine("Please enter your distance traveled in miles: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]*(?:\.[0-9]*)?$") == false)
            {
                Console.WriteLine("Your input was not a positive numeric value. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToDouble(uInput);
        }
    }
}

