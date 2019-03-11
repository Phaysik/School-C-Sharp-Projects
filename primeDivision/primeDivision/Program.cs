using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long primeNum = Calculate();

            Console.WriteLine("The largest prime factor is: {0:n0}", primeNum);

            Console.ReadLine();
        }

        public static long Calculate()
        {
            Console.WriteLine("Please enter in a number you wish to get the largest prime number of: ");

            string num1 = Console.ReadLine();

            long testNumber = Validate(num1);
            long largestPrimeFactor = 2;

            while (testNumber > largestPrimeFactor)
            {
                if (testNumber % largestPrimeFactor == 0)
                {
                    testNumber /= largestPrimeFactor;
                }
                else
                {
                    largestPrimeFactor++;
                }
            }

            return largestPrimeFactor;
        }

        public static long Validate(string num1)
        {
            long value;

            while(!(long.TryParse(num1, out value))){

                Console.WriteLine("Please re-enter your number: ");

                num1 = Console.ReadLine();
            }

            long value1 = Convert.ToInt64(num1);

            return value1;
        }
    }
}
