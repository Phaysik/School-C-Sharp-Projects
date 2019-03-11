/*Programmer: Matthew Moore
  Description: Convert to Upper
  Date: 9-11-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper
{
    class Program
    {
        static char[] lower =
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        static char[] upper =
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        static void Main(string[] args)
        {
            char uInput = GetInfo();
            char returnval = ' ';

            for(int i = 0; i < lower.Length; i++)
            {
                if(uInput == lower[i])
                {
                    returnval = upper[i];
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Your character uppercased is: " + returnval.ToString() + ".");

            Console.ReadLine();
        }

        public static char GetInfo()
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

                while (decimal.TryParse(uInput, out value))
                {
                    Console.WriteLine("Please enter in an alphabetic character and not a numeric character: ");

                    uInput = Console.ReadLine();

                    value2 = true;
                }
            }

            val = Convert.ToChar(uInput.ToLower());

            return val;
        }
    }
}
