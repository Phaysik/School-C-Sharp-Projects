/*Programmer: Matthew Moore
 * Date: 10-25-18
 * Description: Flight class
 */
 using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightClass newFlight = new FlightClass();

            FeedInfo(newFlight);

            Console.ReadLine();
        }

        /// <summary>
        /// Will get all the user inputs and validate them using Regex
        /// </summary>
        /// <param name="newFlight"></param>
        public static void FeedInfo(FlightClass newFlight)
        {
            Console.WriteLine("Please enter in the flight number: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not completely positive whole numbers. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            newFlight.FlightNumber = Convert.ToInt32(uInput);

            Console.WriteLine("Please enter in your destination: ");

            uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[A-z0-9\s',-]+$") == false)
            {
                Console.WriteLine("Your input was not completely letters. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            newFlight.Destination = uInput;

            Console.WriteLine("Please enter in the distance in miles: ");

            uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]*(?:\.[0-9]*)?$") == false)
            {
                Console.WriteLine("Your input was not a positive numeric value. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            newFlight.Distance = (float)Convert.ToDouble(uInput);

            newFlight.Fuel = FlightClass.GetFuel(newFlight.Distance);

            ShowInfo(newFlight);
        }

        /// <summary>
        /// Will show the information the user entered
        /// </summary>
        /// <param name="newFlight"></param>
        public static void ShowInfo(FlightClass newFlight)
        {
            Console.Clear();

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;   //Using this so that I can make sure the user's destination is properly capitalized

            Console.WriteLine("Your flight information: \n");
            Console.WriteLine($"Your flight number is: {newFlight.FlightNumber}.");
            Console.WriteLine($"Your destination is: {textInfo.ToTitleCase(newFlight.Destination)}.");
            Console.WriteLine($"The distance to {newFlight.Destination} is: {newFlight.Distance} miles.");
            Console.WriteLine($"The total cost of your fuel is: {newFlight.Fuel:c2}.");
        }
    }
}
