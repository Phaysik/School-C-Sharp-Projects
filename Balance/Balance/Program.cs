 /*Programmer: Matthew Moore
  Description: Balance
  Date: 10-2-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomVal = new Random();

            List<int> arr = new List<int>();

            int random = randomVal.Next(20, 31);

            int binars = 0;

            for(int i = 0; i < random; i++)
            {
                binars = randomVal.Next(1, 4);

                arr.Add(binars);
            }

            Print(arr, random);

            Console.ReadLine();
        }

        public static void Print(List<int> arr, int random)
        {
            int counter = 0;
            int totCount = 0;

            string output = "";

            foreach (int nums in arr)
            {
                counter++;
                totCount++;

                if ((counter < 10) && (totCount != random))
                {
                    output += ($"{nums}, ");
                }
                else
                {
                    output += ($"{nums}, ");

                    output = output.Substring(0, (output.Length - 2));

                    Console.Write(output);

                    output = "";

                    counter = 0;

                    Console.WriteLine();
                }
            }
        }
    }
}
