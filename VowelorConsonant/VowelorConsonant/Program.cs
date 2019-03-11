/*Programmer: Matthew Moore
 * Description: Determine if user input is a vowel or a consonant
 * Date: 9-10-18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelorConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char uInput = GetInput();

            string vowelConsonant = DetermineType(uInput);

            Console.WriteLine("The letter {0} is {1}", uInput, vowelConsonant);

            Console.ReadLine();
        }

        public static char GetInput()
        {
            Console.WriteLine("Please enter in a single alphabetic character: ");

            string uInput = Console.ReadLine();

            char val = Validate(uInput);

            return val;
        }

        public static char Validate(string uInput)
        {
            char val;
            decimal value;
            bool value2 = true;

            while (value2 == true)
            {
                while (!(char.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Please enter in a single alphabetic character: ");

                    uInput = Console.ReadLine();

                    while (uInput.Length > 1)
                    {
                        Console.WriteLine("Please enter in only one character: ");

                        uInput = Console.ReadLine();
                    }
                }

                value2 = false;

                while(decimal.TryParse(uInput, out value))
                {
                    Console.WriteLine("Please enter in an alphabetic character and not a numeric character: ");

                    uInput = Console.ReadLine();

                    value2 = true;
                }
            }

            val = Convert.ToChar(uInput.ToLower());

            return val;
        }

        public static string DetermineType(char uInput)
        {
            string value = "";
            switch (uInput)
            {
                case 'a':
                    value = "a vowel.";
                    break;
                case 'e':
                    value = "a vowel.";
                    break;
                case 'i':
                    value = "a vowel.";
                    break;
                case 'o':
                    value = "a vowel.";
                    break;
                case 'u':
                    value = "a vowel.";
                    break;
                case 'y':
                    value = "sometimes a vowel and sometimes a consonant.";
                    break;
                default:
                    value = "a consonant.";
                    break;

            }

            return value;
        }
    }
}
