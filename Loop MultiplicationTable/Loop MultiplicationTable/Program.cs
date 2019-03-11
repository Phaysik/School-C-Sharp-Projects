/*Programmer: Matthew Moore
  Desciption: Multiplication Table
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
            Console.WriteLine("Please enter in a positive whole number from the range of 2-8: ");

            string uInput = Console.ReadLine();

            int val = Validate(uInput);

            Console.WriteLine("Please enter in a positive whole number that is greater than your previous\nnumber. If you want to only see one column, please enter in the same value as your previous entry.");

            uInput = Console.ReadLine();

            int val2 = Validate(uInput);

            while(true)
            {

                if (val2 < val)
                {
                    Console.WriteLine("Your second value was less than your first value. Please re-enter your second value.");

                    uInput = Console.ReadLine();

                    val2 = Validate(uInput);
                }
                
                else
                {
                    break;
                }
            }

            DisplayInformation(val, val2);

            Console.ReadLine();
        }

        public static int Validate(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a whole numeric value; please re-enter in a positive whole number less than 100: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 2 || Convert.ToInt32(uInput) > 8)
                {
                    Console.WriteLine("Your input was greater than 8 or less than 2\nPlease re-enter your value: ");

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

        public static void DisplayInformation(int val, int val2)
        {
            int value = val2 - val;

            List<int> vall = new List<int>();

            Console.Write("n\t");

            int l = 0;

            for(int i = val; i <= val2; i++)
            {
                vall.Add(val + l);
                
                Console.Write($"{vall[l]}\t");

                l++;
            }

            bool vari = true;

            for(int i = 1; i <= 25; i++)
            {
                if (vari == true)
                {
                    Console.Write("\n" + i);
                    vari = false;
                }

                for(int j = 0; j < vall.Count; j++)
                {
                    Console.Write("\t" + (vall[j] * i));
                }

                vari = true;
                
            }
        }
    }
}
