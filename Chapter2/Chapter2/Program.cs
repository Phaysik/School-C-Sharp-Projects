using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;   // declaring and assigning a value at compile time for an interger
            int num2 = 5;

            float num3 = 5.2f;  // The f is to make the variable a float. Without it the number will default to a double

            Console.WriteLine("{0} + {1}", num1, num1);

            decimal endownmentAmt = 3456.54m;   //if you leave off the m, the value will become a double. M or m

            bool moreData = true;

            string courseName = "WCP";

            const decimal TAX_RATE = .065432m;

            //C or c is for currency
            //D or d is for decimal
            //E or e is for scientific notation
            //F or f is for fixed point
            //N or n is for number
            //G or g is for general
            //P or p is for percent

            decimal pct = .456m;
            decimal change = 62.1567m;
            Console.WriteLine("Percent is {0:p1} and the change us {1:c2}", pct, change);    //put the value in a format of a percent with one decimal place

            Console.ReadLine();
        }
    }
}
