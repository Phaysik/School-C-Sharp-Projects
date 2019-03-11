/*Programmer: Matthew Moore
  Description: Day Number
  Date: 10-8-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("January starts at the index of 1, and December ends at the index of 12.\nPlease enter in a number between 1 and 12 to determine your month: ");

            string uInput = Console.ReadLine();

            int monthVal = Validate(uInput);

            Console.WriteLine("Please enter in a date of the month: ");

            uInput = Console.ReadLine();

            int monthDay = Validate1(uInput);

            string month = "";

            for (int i = 11; i < months.Length; i--)
            {
                if (monthVal == months.Length - i)
                {
                    month = months[months.Length - i - 1];

                    monthVal = daysInMonth[months.Length - i - 1];

                    break;
                }

                else
                {
                    continue;
                }
            }

            while (monthVal < monthDay)
            {
                Console.WriteLine("You day input was greater than the days in the month;\nPlease re-enter in your days: ");

                uInput = Console.ReadLine();

                monthDay = Validate1(uInput);
            }


            int value = dayMonthtoDay(daysInMonth, months, monthDay, month);

            Console.WriteLine($"{month} {monthDay} is the {value} day of the year.");

            Console.ReadLine();
        }

        public static int Validate(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 1 || Convert.ToInt32(uInput) > 12)
                {
                    Console.WriteLine("Your input was less than 1 or greater than 12;\nplease re-enter in a whole number that is greater than 0 or less than 13: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }

        public static int Validate1(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 1 || Convert.ToInt32(uInput) > 31)
                {
                    Console.WriteLine("Your input was less than 1 or greater than 12;\nplease re-enter in a whole number that is greater than 0 or less than 13: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }

        public static int dayMonthtoDay(int[] daysInMonth, string[] months, int monthDay, string month)
        {
            int value = 0;
            int monthHolder = 0;

            for (int i = 0; i < months.Length; i++)
            {
                if (month == months[i])
                {
                    monthHolder = i;
                }

                else
                {
                    continue;
                }
            }

            if(monthHolder > 0)
            {
                for (int i = 0; i < monthHolder; i++)
                {
                    value += daysInMonth[i];
                }
            }

            value += monthDay;

            return value;
        }
    }
}
