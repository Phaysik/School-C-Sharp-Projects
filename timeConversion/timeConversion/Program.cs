/*Programmer: Matthew Moore
  Description: Time Conversion
  Date: 8-27-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many seconds you would like to convert: ");

            int seconds = Convert.ToInt32(Console.ReadLine());
            int seconds2 = seconds;
            int hours;
            int minutes;

            double mins;
            double secs;
            double hrs2 = seconds % 3600;
            double minute = hrs2 % 60;

            hours = ConvertTime(seconds);
            mins = ConvertTimes(hrs2);
            secs = SecondCalc(minute, seconds);

            minutes = Convert.ToInt32(mins);
            seconds = Convert.ToInt32(secs);

            DisplayInformation(hours, minutes, seconds, seconds2);

            Console.ReadLine();
        }

        public static int ConvertTime(int secs)
        {
            int hrs = secs / 3600;

            return hrs;
        }

        public static double ConvertTimes(double hurs)
        {
            int mins = Convert.ToInt32(hurs) / 60;

            return mins;
        }

        public static double SecondCalc(double time, int secs)
        {
            secs = Convert.ToInt32(time);

            return secs;
        }

        public static void DisplayInformation(int hrs, int mins, int secs, int secs2)
        {
            Console.WriteLine("\n\tTime Converter\n\nTotal Seconds: {0:n0}", secs2);
            Console.Write("\nHours: " + hrs + "\nMinutes: " + mins + "\nSeconds: " + secs);
        }

    }
}
