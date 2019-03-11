/*Programmer: Matthew Moore
  Description: Markup item prices
  Date: 8-28-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your item's wholesale price: ");

            string num1 = Console.ReadLine();

            double num3 = CheckValidity1(num1);

            Console.WriteLine("Please enter in your markup price (This program will assume you are entering in the percent of the markup and will move the decimal back two places for any \nvalue): ");

            string num2 = Console.ReadLine();

            double num4 = CheckValidity2(num2);

            double retailPrice = DoMath(num3, num4);

            DisplayInformation(num3, num4, retailPrice);

            Console.ReadLine();
        }

        public static double CheckValidity1(string num1)
        {
            double value;
            while(!(double.TryParse(num1, out value))){
                Console.WriteLine("Please re-enter in your item's wholesale price: ");

                num1 = Console.ReadLine();
            }

            double num2 = Convert.ToDouble(num1);

            return num2;
        }

        public static double CheckValidity2(string num2)
        {
            double value;
            while (!(double.TryParse(num2, out value))){
                Console.WriteLine("Please re-enter in your markup price: ");

                num2 = Console.ReadLine();
            }

            double num1 = Convert.ToDouble(num2);

            return num1;
        }

        public static double DoMath(double num1, double num2)
        {
            num2 = (num2 / 100);

            double num3 = num1 + (num1 * num2);
             
            return num3;
        }

        public static void DisplayInformation(double num1, double num2, double num3)
        {
            string percent = num2 + "%";
            Console.WriteLine("\n\tMarkup App\n\nThe wholesale price is: {0:c2}\nThe markup is: {1}\nThe retail price is: {2:c2}", num1, percent, num3);
        }

    }
}
