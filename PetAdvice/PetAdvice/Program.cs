/*Programmer: Matthew Moore
  Decsription: Pet Advice
  Date: 9-10-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvice
{
    class Program
    {
        static void Main(string[] args)
        {
            string residence = GetResidence();
            double hours = GetHours();
            string recommended = GetRecommened(residence, hours);

            DisplayInformation(recommended);

            Console.ReadLine();
        }

        public static string GetResidence()
        {
            string uInput = "";

            char value;

            Console.WriteLine("Please enter in what your residence is. 'A' for Apartment. 'D' for Dormitory.\n 'H' for House.");

            uInput = Console.ReadLine();

            value = GetValidate(uInput);

            switch (value)
            {
                case 'A':
                    uInput = "Apartment";
                    break;
                case 'D':
                    uInput = "Dormitory";
                    break;
                case 'H':
                    uInput = "House";
                    break;
            }

            return uInput;
        }

        public static char GetValidate(string uInput)
        {
            char val;

            while (!(char.TryParse(uInput, out val)))
            {
                Console.WriteLine("Please enter in only a single character. 'A', 'D', or 'H'.");

                uInput = Console.ReadLine();
            }

            while ((Convert.ToChar(uInput.ToUpper()) != 'A') && (Convert.ToChar(uInput.ToUpper()) != 'D') && ((Convert.ToChar(uInput.ToUpper()) != 'H')))
            {
                Console.WriteLine("Please enter in 'A', 'D', or 'H'. Please don't enter in any other characters.");

                uInput = Console.ReadLine();

                while(uInput.Length > 1)
                {
                    Console.WriteLine("Please enter in only one character: ");

                    uInput = Console.ReadLine();
                }
            }

            char value = Convert.ToChar(uInput.ToUpper());

            return value;
        }

        public static double GetHours()
        {
            string uInput = "";

            Console.WriteLine("Please enter in a how many hours you worked that is greater that is greater than or equal to 0: ");

            uInput = Console.ReadLine();

            double value = GetValidate1(uInput);

            return value;
        }

        public static double GetValidate1(string uInput)
        {
            double val;

            while(!(double.TryParse(uInput, out val)))
            {
                Console.WriteLine("Please enter in a number, and not characters: ");

                uInput = Console.ReadLine();
            }

            while(Convert.ToDouble(uInput) < 0)
                {
                    Console.WriteLine("Please enter in a number that is equal to or greater than 0: ");

                    uInput = Console.ReadLine();
                }

            double value = Convert.ToDouble(uInput);

            return value;
        }

        public static string GetRecommened(string residence, double hours)
        {
            string pet = "";
            if(residence == "House")
            {
                if(hours >= 18)
                {
                    pet = "Pot bellied pig";
                }
                else if((hours >= 10) && (hours <= 17))
                {
                    pet = "Dog";
                }
                else
                {
                    pet = "Snake";
                }
            }

            else if(residence == "Apartment")
            {
                if(hours >= 10)
                {
                    pet = "Cat";
                }
                else
                {
                    pet = "Hamster";
                }
            }

            else 
            {
                if(hours >= 6)
                {
                    pet = "Fish";
                }
                else
                {
                    pet = "Ant farm";
                }
            }

            return pet;
        }

        public static void DisplayInformation(string recommened)
        {
            Console.WriteLine("Your recommnded pet is: " + recommened + ".");
        }
    }
}
