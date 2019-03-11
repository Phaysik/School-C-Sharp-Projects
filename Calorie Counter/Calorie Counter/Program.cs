/*Programmer: Matthew Moore
  Description: Calorie Counter - 2 dim array
  Date: 10-8-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] calories = {{900, 750, 1020}, {300, 1000, 2700}, {500, 700, 2100}, {400, 900, 1780}, { 600, 1200, 1100 }, {575, 1150, 1900}, {600, 1020, 1700}};

            double[] dailyAverage = new double[7];
            double[] mealAverage = new double[3];

            dailyAverage = CalculateAverageByDay(calories);
            mealAverage = CalculateAverageByMeal(calories);

            DisplayDailyAverage(dailyAverage);
            DisplayMealAverage(mealAverage);
            DisplayAverageCaloriesPerMeal(calories);

            Console.ReadLine();
        }

        public static double[] CalculateAverageByDay(int[,] calories)
        {
            double[] daily = new double[7];

            double sum = 0;

            for (int r = 0; r < calories.GetLength(0); r++) //The (0) gets the rows of the array
            {
                for(int i = 0; i < calories.GetLength(1); i++)  //The (1) gets the columns of the array
                {
                    sum += calories[r, i];
                }
                    
                daily[r] = (sum / calories.GetLength(1));

                sum = 0;
            }

            return daily;
        }

        public static double[] CalculateAverageByMeal(int[,] calories)
        {
            double[] meal = new double[3];

            double sum = 0;

            for (int i = 0; i < calories.GetLength(1); i++)
            {
                for (int x = 0; x < calories.GetLength(0); x++)
                {
                    sum += calories[x, i];
                }

                meal[i] = (sum / calories.GetLength(0));

                sum = 0;
            }

            return meal;
        }

        public static void DisplayDailyAverage(double[] dailyAverage)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            for (int i = 0; i < dailyAverage.Length; i++)
            {
                Console.WriteLine($"{days[i]}: {dailyAverage[i]:n2} average calories.");
            }
        }

        public static void DisplayMealAverage(double[] mealAverage)
        {
            string[] meal = {"Breakfast", "Lunch", "Dinner"};

            Console.WriteLine();

            for (int i = 0; i < mealAverage.Length; i++)
            {
                Console.WriteLine($"{meal[i]}: {mealAverage[i]:n2} average calories.");

            }
        }

        public static void DisplayAverageCaloriesPerMeal(int[,] calories)
        {
            double sum = 0;

            for (int i = 0; i < calories.GetLength(0); i++)
            {
                for (int x = 0; x < calories.GetLength(1); x++)
                {
                    sum += calories[i, x];
                }
            }

            Console.WriteLine($"\nThe average calories is: {(sum / calories.Length):n2}");
        }
    }
}
