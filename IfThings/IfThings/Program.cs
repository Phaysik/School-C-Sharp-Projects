/* Programmer: Matthew Moore
   Description: If Statement Refresher
   Date: 9-6-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2;
            int result = a / b;

            if(result == 2)
            {
                Console.WriteLine("Result is 2.");
            }

            else if (result == 3)
            {
                Console.WriteLine("Result is 3.");
            }

            int c = 5, d = 6;
            int result1 = c - d;

            if(result1 > 0)
            {
                Console.WriteLine("Your result is greater than zero.");
            }

            else if (result1 < 0)
            {
                Console.WriteLine("Your result is less than zero.");
            }

            char grade = 'B';

            if (grade == 'A')
            {
                Console.WriteLine("Exceptional.");
            }

            else if (grade == 'B')
            {
                Console.WriteLine("Good job");
            }

            else if (grade == 'C' || grade == 'D')
            {
                Console.WriteLine("You passed");
            }

            else
                Console.WriteLine("You failed.");

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Exceptional");
                    break;
                case 'B':
                    Console.WriteLine("Good job");
                    break;
                case 'C':
                    Console.WriteLine("Alright");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("You failed");
                    break;
                default:
                    Console.WriteLine("Grade not recognized");
                    break;

            }

            //Ternary Operation
            int e = 20, f = 10;
            string result3 = e > f ? "e is greater than f": "f is greater than e";

            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
