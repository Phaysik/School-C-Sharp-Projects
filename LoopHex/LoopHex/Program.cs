/*Programmer: Matthew Moore
  Descripition: Hex
  Date: 9-18-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hexa = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            List<string> decimalVal = new List<string>();
            List<int> decimalValue = new List<int>();

            Console.WriteLine("Please enter in a valid hexadecimal value: ");

            string value = Console.ReadLine();

            value = Validate(hexa, value);

            decimalVal.Add(value.ToUpper());

            while (true)
            {
                Console.WriteLine("If you would like to stop adding hexadecimal values, please enter in '-1'");

                value = Console.ReadLine();

                if(value == "-1")
                {
                    break;
                }

                else
                {
                    value = Validate(hexa, value);

                    decimalVal.Add(value.ToUpper());
                }
            }

            int val = 0;

            for (int i = 0; i < decimalVal.Count; i++)
            {
                for (int l = 10; l < hexa.Length; l++)
                {
                    if (hexa[l] == decimalVal[i])
                    {
                        val = l;

                        decimalValue.Add(val);

                        break;
                    }
                    else if ((l + 1) == hexa.Length)
                    {
                        decimalValue.Add(Convert.ToInt32(decimalVal[i]));
                    }
                }
            }

            int tot = 0;

            Console.Write("Your originial hex value is ");

            for(int z = 0; z < decimalValue.Count; z++)
            {
                tot += decimalValue[z];
            }

            for (int c = 0; c < decimalVal.Count; c++)
            {
                Console.Write(decimalVal[c]);
            }

            Console.WriteLine($". Your decimal value of your hexadecimal inputs is {tot}.");

            Console.ReadLine();
        }

        public static string Validate(string[] hexa, string value)
        {
            for(int i = 0; i < hexa.Length; i++)
            {
                if((value.Length > 1) && (value != "-1"))
                {
                    Console.WriteLine("Your input was greater than one character. Please re-enter :");

                    value = Console.ReadLine();

                    i = -1;
                }
                else if (value.ToUpper() == hexa[i])
                {
                    break;
                }

                else if((i + 1) == hexa.Length)
                {
                    Console.WriteLine("Your input was not a valid hexadecimal value. Please re-enter in a value: ");

                    value = Console.ReadLine();

                    i = -1;
                }
            }

            return value;
        }
    }
}
