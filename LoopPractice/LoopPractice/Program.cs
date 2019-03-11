/*Programmer: Matthew Moore
  Description: Loop Practice
  Date: 9-18-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while(x < 11)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.Write("\n");

            for(int l = 0; l < 11; l++)
            {
                Console.WriteLine(l);
            }

            Console.Write("\n");

            int j = 0;

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 11);

            Console.Write("\n");

            Console.WriteLine("This program will let you enter value after value. To stop the entry of values, enter '-99'");

            string inp = Console.ReadLine();

            while (inp != "-99")
            {
                Console.Write("Eneter value was " + inp + ".\n");
                Console.WriteLine("Enter next value or '-99' to quit.");
                inp = Console.ReadLine();
            }

            int intValue;   

            Console.Write("Enter an integer value: ");

            string inString = Console.ReadLine();

            while(!(int.TryParse(inString, out intValue)))
            {
                Console.WriteLine("Your input was not an integer; please re-enter in an integer: ");
                inString = Console.ReadLine();
            }

            Console.WriteLine("Your valid value was: " + inString);

            Console.ReadLine();
        }
    }
}
