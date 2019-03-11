/*Programmer: Matthew Moore
  Description: Multiples of 10
  Date: 10-2-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomVal = new Random();

            int randomNum = 0;

            List<int> arr = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                randomNum = randomVal.Next(1, 101);

                arr.Add(randomNum);
            }

            Console.WriteLine("Original Array\n");

            Print(arr);

            int tens = Run10s(arr);

            int twenties = Run20s(arr);

            int thirties = Run30s(arr);

            int fourties = Run40s(arr);

            int fifties = Run50s(arr);

            Console.WriteLine($"\nThere was {tens} tens. {twenties} twenties. {thirties} thirties. {fourties} fourties. {fifties} fifties.");

            Console.ReadLine();
        }

        public static int Run10s(List<int> arr)
        {
            int tens = 0;

            for(int i = 0; i < arr.Count(); i++)
            {
                if(arr[i] == 10)
                {
                    i++;
                    tens++;
                    while((i != 100) && (arr[i] % 10 != 0))
                    {
                        arr[i] = arr[i] * 10;
                        i++;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\n10s rules applied: \n");

            Print(arr);

            return tens;
        }

        public static int Run20s(List<int> arr)
        {
            int twenties = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == 20)
                {
                    i++;
                    twenties++;
                    while ((i != 100) && (arr[i] % 10 != 0))
                    {
                        arr[i] = arr[i] + 2;
                        i++;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\n20s rules applied: \n");

            Print(arr);

            return twenties;
        }

        public static int Run30s(List<int> arr)
        {
            int thirties = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == 30)
                {
                    i++;
                    thirties++;
                    while ((i != 100) && (arr[i] % 10 != 0))
                    {
                        arr[i] = arr[i] - 10;
                        i++;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\n30s rules applied: \n");

            Print(arr);

            return thirties;
        }

        public static int Run40s(List<int> arr)
        {
            int fourties = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == 40)
                {
                    i++;
                    fourties++;
                    while ((i != 100) && (arr[i] % 10 != 0))
                    {
                        arr[i] = arr[i] + 6;
                        i++;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\n40s rules applied: \n");

            Print(arr);

            return fourties;
        }

        public static int Run50s(List<int> arr)
        {
            int fifites = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == 50)
                {
                    i++;
                    fifites++;
                    while ((i != 100) && (arr[i] % 10 != 0))
                    {
                        arr[i] = (arr[i] * 5);
                        i++;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("\n50s rules applied: \n");

            Print(arr);

            return fifites;
        }

        public static void Print(List<int> arr)
        {
            int counter = 0;
            int totCount = 0;

            string output = "";

            foreach (int nums in arr)
            {
                counter++;
                totCount++;

                if ((counter < 15) && (totCount != 100))
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
