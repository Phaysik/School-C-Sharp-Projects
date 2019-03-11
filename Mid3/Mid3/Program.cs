/*Programmer: Matthew Moore
  Description: Find middle of the array and print it out
  Date: 10-2-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum1 = new Random();

            int randomVal = randomNum1.Next(3, 26);

            while(randomVal % 2 != 1)
            {
                randomVal = randomNum1.Next(3, 26);
            }

            int[] arr = new int[randomVal];

            for(int l = 0; l < arr.Length; l++)
            {
                arr[l] = randomNum1.Next(1, 1001);
            }

            Array.Sort(arr);

            int counter = 0;

            string output = "";

            foreach(int nums in arr)
            {
                counter++;
                if ((counter < 10) && (nums != arr[arr.Length - 1]))
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

            int middle = arr.Length / 2;
            int lower = 0;
            int higher = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[middle] == arr[i])
                {
                    middle = arr[i];
                    lower = arr[i - 1];
                    higher = arr[i + 1];

                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\nThe middle of the random numbers is: " + lower + " " + middle + " " + higher);

            Console.ReadLine();
        }
    }
}
