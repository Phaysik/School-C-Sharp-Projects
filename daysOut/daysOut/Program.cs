/*Programmer: Matthew Moore
  Description: Calculate the average number of days an employee is out
  Date: 8-28-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeCount = GetEmployeeNum();

            int daysMissed = dayMissed(employeeCount);

            float averageDaysMissed = CalculateAverage(employeeCount, daysMissed);

            DisplayInformation(employeeCount, daysMissed, averageDaysMissed);

            Console.ReadLine();
        }

        public static int GetEmployeeNum()  //Gets the amount of employees
        {
            Console.WriteLine("Please enter in the number of employees in your company: ");

            string uInput = Console.ReadLine();

            int value;

            while (!(int.TryParse(uInput, out value)))  //Will only allow numbers
            {
                Console.WriteLine("Please re-enter in the number of employees in your company: ");

                uInput = Console.ReadLine();
            }

            int count = Convert.ToInt32(uInput);

            return count;
        }

        public static int dayMissed(int employeeCount)  //Gets the total days missed
        {
            int daysMissed = 0;
            int totalDaysMissed = 0;

            for(int i = 1; i < employeeCount + 1; i++)  //Asks for how many days each employee missed
            {
                Console.WriteLine("Please enter how many days employee " + i + " missed: ");

                string uInput = Console.ReadLine();

                int value;

                while (!(int.TryParse(uInput, out value)))  //Will only allow numbers
                {
                    Console.WriteLine("Please re-enter how many days employee " + i + " missed: ");

                    uInput = Console.ReadLine();
                }

                daysMissed = Convert.ToInt32(uInput);
                totalDaysMissed += daysMissed;
            }

            return totalDaysMissed;
        }

        public static float CalculateAverage(int employeeCount, int daysMissed) //Calculates the average days missed
        {
            float averageDaysMissed = daysMissed / employeeCount;

            return averageDaysMissed;
        }

        public static void DisplayInformation(int employee, int daysMissed, float aveDaysMissed)    //Displays all the information
        {
            Console.WriteLine("\n\tAverage Days Missed App\n\nYour company has: {0:n0} employees.\nThe total days missed was: {1:n0} days.\nThe average days missed was: {2:n2} days.", employee, daysMissed, aveDaysMissed);
        }
    }
}
