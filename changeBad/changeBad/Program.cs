/*Programmer: Matthew Moore
  Description: Calculate change from user input
  Date: 8-23-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the total cost of your sale: ");

            decimal totSale = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter how much you are paying with: ");

            decimal userPay = Convert.ToDecimal(Console.ReadLine());

            while (userPay < totSale) //Prevent the user from paying will less money than what is required
            {
                Console.WriteLine("Please enter a value more than what your total sale cost: ");

                userPay = Convert.ToDecimal(Console.ReadLine());
            }

            decimal changeNeeded = userPay - totSale;

            changeNeeded = Change(changeNeeded, .25m, "quarter(s)");
            changeNeeded = Change(changeNeeded, .10m, "dime(s)");
            changeNeeded = Change(changeNeeded, .05m, "nickle(s)");
            changeNeeded = Change(changeNeeded, .01m, "penny(pennies)");


            Console.ReadLine();
        }

        public static decimal Change(decimal origAmt, decimal change, string type)
        {
            int modulo = Convert.ToInt32(Math.Floor((100 * origAmt) / (100 * change))); // convert the value to an integer and round down after dividing to get a whole number and decimal
            Console.WriteLine("You should recieve: " + modulo + " " + type);
            return origAmt % change;
        }
    }
}