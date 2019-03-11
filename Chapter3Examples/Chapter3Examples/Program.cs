/*Programmer: Matthew Moore
  Description: Calculates the total cost of carpet. User inputs room dimensions and carpet price
  Date: 8-27-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomLength;
            double roomWidth;
            double pricePerSquareYard;
            double nbrOfSquareYards;

            DisplayInstructions();

            roomLength = GetDimension("Length");    //The data between parentheses is called the actual parameter. It will be passed to the GetDimension method.
            roomWidth = GetDimension("Width");
            pricePerSquareYard = GetPrice();
            nbrOfSquareYards = DetermineSquareYards(roomWidth, roomLength);
            DisplayResults(nbrOfSquareYards, pricePerSquareYard);

            Console.ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("This program will determine how much carpet to purchase.\nYou will be asked to enter the size of the room and the price of the carpet, in price per square yards.");
        }

        public static double GetDimension(string side)
        {
            string inputValue;
            int feet, inches;

            Console.WriteLine("Enter the {0} in feet: ",side);

            inputValue = Console.ReadLine();

            feet = int.Parse(inputValue);   //Turns the string into an integer

            Console.WriteLine("Enter the {0} in inches: ", side);

            inputValue = Console.ReadLine();

            inches = int.Parse(inputValue);

            //Note: cast required to avoid int division

            return (feet + (double)inches / 12);
        }

        public static double GetPrice()
        {
            string inputValue;
            double price;
            Console.WriteLine("Enter the price per Square Yard: ");

            inputValue = Console.ReadLine();

            price = double.Parse(inputValue);

            return price;
        }

        public static double DetermineSquareYards(double width, double length)
        {
            const int SQ_FT_PER_SQ_YRD = 9;
            double nbrOfSqYards;

            nbrOfSqYards = (length * width) / SQ_FT_PER_SQ_YRD;

            return nbrOfSqYards;
        }

        public static void DisplayResults(double yards, double pricePerYard)
        {
            Console.WriteLine("\nSquare Yards needed: ");
            Console.WriteLine("{0:n2}", yards);
            Console.WriteLine("Total Cost at {0:c2}: ", pricePerYard);
            Console.WriteLine("per square Yard: " + "{0:c2}", DeterminePrice(yards, pricePerYard));
        }

        public static double DeterminePrice(double yrds, double prc)
        {
            return (prc * yrds);
        }
    }
}
