/*Programmer: Matthew Moore
  Description: Drop lowest test score average the rest
  Date: 8-29-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowestDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> testScores = GetValues();

            testScores = GetLowest(testScores);

            DisplayInformation(testScores);

            Console.ReadLine();
        }

        public static List<double> GetValues()
        {
            List<double> testScores = new List<double>();

            Console.WriteLine("Please enter in your first test score: ");

            string uInput = Console.ReadLine();

            double test1 = Validate(uInput);

            Console.WriteLine("Please enter in your second test score: ");

            uInput = Console.ReadLine();

            double test2 = Validate(uInput);

            Console.WriteLine("Please enter in your third test score: ");

            uInput = Console.ReadLine();

            double test3 = Validate(uInput);

            Console.WriteLine("Please enter in your fourth test score: ");

            uInput = Console.ReadLine();

            double test4 = Validate(uInput);

            Console.WriteLine("Please enter in your fifth test score: ");

            uInput = Console.ReadLine();

            double test5 = Validate(uInput);

            testScores.Add(test1);
            testScores.Add(test2);
            testScores.Add(test3);
            testScores.Add(test4);
            testScores.Add(test5);

            return testScores;
        }

        public static double Validate(string input)
        {
            double value;

            while(!(double.TryParse(input, out value))){
                Console.WriteLine("Please re-enter your test score: ");

                input = Console.ReadLine();
            }

            double testScore = Convert.ToDouble(input);

            return testScore;
        }

        public static List<double> GetLowest(List<double> testScores)
        {
            List<double> newTestScores = testScores;

            double min = newTestScores.Min();

            for(int i = 0; i < newTestScores.Count; i++)
            {
                if(min == newTestScores[i])
                {
                    newTestScores.RemoveAt(i);
                    break;
                }
                else
                {
                    continue;
                }
            }

            return newTestScores;
        }

        public static void DisplayInformation(List<double> testScores)
        {
            double total = 0;
            for(int i = 0; i < testScores.Count; i++)
            {
                total += testScores[i];
            }

            total /= 4;

            Console.WriteLine("\n\tAverage Test Scores App\nYour test scores, after removing the worst score, are: ");

            for (int l = 0; l < testScores.Count; l++)
            {
                Console.WriteLine("{0}", testScores[l]);
            }

            Console.WriteLine("The average of your test scores, after removing the worst score, is: " + total);
        }
    }
}
