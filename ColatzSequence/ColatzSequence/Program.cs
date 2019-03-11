/*Programmer: Matthew Moore
  Descripition: Colatz Sequence
  Date: 9-21-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will show the Colatz Sequence. Please enter in any positive whole number: ");

            string uInput = Console.ReadLine();

            int startNum = Validate(uInput);

            Colatz(startNum);
            
            Console.ReadLine();
        }
        /// <summary>
        /// Validates Program
        /// </summary>
        /// <param name="uInput"></param>
        /// <returns>Validated value</returns>
        public static int Validate(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0)
                {
                    Console.WriteLine("Your input was less than 0, please re-enter in a whole number that is greater than 0: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }
        /// <summary>
        /// Calculates the Colatz Sequence
        /// </summary>
        /// <param name="startNum"></param>
        public static void Colatz(int startNum)
        {

            string output = "";

            Console.Write($"{startNum} ");

            while (startNum != 1)
            {
                if ((startNum % 2) == 0)
                {
                    startNum = (startNum / 2);

                    output += ($"{startNum} ");
                }
                else
                {
                    startNum = ((startNum * 3) + 1);

                    output += ($"{startNum} ");
                }
            }

            output = output.Substring(0, (output.Length - 1));

            Console.Write(output);
        }
    }
}
