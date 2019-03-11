/*Programmer: Matthew Moore
  Description: Display pH levels
  Date: 9-7-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pHLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            int uInput = GetInfo();

            string pH = Calculate(uInput);

            DisplayInformation(pH);

            Console.ReadLine();
        }

        public static int GetInfo()
        {
            Console.WriteLine("Please enter in a whole number between 0 and 14.");

            string num1 = Console.ReadLine();

            int num2 = CheckValidity1(num1);

            return num2;
        }

        public static int CheckValidity1(string num1)
        {
            int value;
            while(!(int.TryParse(num1, out value)))
            {
                Console.WriteLine("Please re-enter a whole number between 0 and 14");

                num1 = Console.ReadLine();
            }
            
            int num2 = Convert.ToInt32(num1);

            CheckValidity2(num2);

            return num2;
        }

        public static void CheckValidity2(int num2)
        {
            while ((num2 < 0 || num2 > 14))
            {
                string num1 = "";

                Console.WriteLine("Your input was greater than 14, less than 0, or was not an integer. Please re-enter your number");

                num1 = Console.ReadLine(); ;

                num2 = CheckValidity1(num1);
            }
        }

        public static string Calculate(int num1)
        {
            string value = "";
            if((num1 >= 0) && (num1 < 7))
            {
                value = "Acidic";
            }

            else if(num1 == 7)
            {
                value = "Neutral";
            }

            else
            {
                value = "Alkaline";
            }

            return value;
        }

        public static void DisplayInformation(string Input)
        {
            Console.WriteLine("The pH you selected is: " + Input + ".");
        }
    }
}
