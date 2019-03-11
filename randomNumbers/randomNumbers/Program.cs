/*Programmer: Matthew Moore
  Description: Random Numbers
  Date: 8-28-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number: ");

            string num1 = Console.ReadLine();

            long num2 = CheckValidity(num1);

            GetRandom(num2);

            Console.ReadLine();
        }

        public static long CheckValidity(string num1)   //Make sure the number entered was a number
        {
            long value;
            while(!(long.TryParse(num1, out value)))
            {
                Console.WriteLine("Please re-enter your number: ");

                num1 = Console.ReadLine();
            }

            long num2 = Convert.ToInt64(num1);

            return num2;
        }

        public static void GetRandom(long num1)
        {
            List<long> numbers = new List<long>();  //Create one list to hold 1-num1
            List<long> rndNumbers = new List<long>();   //Create another list to pass the random order of numbers from the first list into this list

            for (int i = 1; i < num1 + 1; i++)
            {
                numbers.Add(Convert.ToInt64(i)); //For loop to add all the numbers incrementing by 1 to the list
            }

            Random num = new Random();

            for(long l = (long)((num.NextDouble() * numbers.Count) * 1); rndNumbers.Count < num1; l = (long)((num.NextDouble() * numbers.Count) * 1))   //Get a randomized long number
            {
                rndNumbers.Add(numbers[Convert.ToInt32(l)]);    //Add the randomized position's value to the list
                numbers.RemoveAt(Convert.ToInt32(l));   //Remove the position's value
            }

            DisplayInformation(rndNumbers);
        }

        public static void DisplayInformation(List<long> rndNumbers)
        {
            Console.WriteLine("\nYour randomized order of numbers is: ");
            for(int i = 0; i < rndNumbers.Count; i++)
            {
                Console.WriteLine(rndNumbers[i]);   //Display all list
            }
        }
    }
}
