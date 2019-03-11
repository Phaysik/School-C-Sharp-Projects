/*Programmer: Matthew Moore
  Desciption: Validate input to be positive less than 100
  DatE: 9-18-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopValidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a positive whole number less than 100: ");

            string uInput = Console.ReadLine();

            int val = Validate(uInput);

            Console.WriteLine("Your valid value is: " + val + ".");

            Console.ReadLine();
        }

        public static int Validate(string uInput)
        {
            int val;

            while(true)
            {
                if(!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a numeric value; please re-enter in a positive whole number less than 100: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0 || Convert.ToInt32(uInput) >= 100)
                {
                    Console.WriteLine("Your input was greater than or equal to 100 or less than 0\nPlease re-enter your value: ");

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
    }
}
