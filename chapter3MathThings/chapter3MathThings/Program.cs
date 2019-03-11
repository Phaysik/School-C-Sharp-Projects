/*Programmer: Matthew Moore
  Description: Math Things
  Date: 8-28-18
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3MathThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI: {0}", Math.PI);
            Console.WriteLine("Find the largest of 3 numbers: \nInput the 1st number: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");

            int num3 = Convert.ToInt32(Console.ReadLine());

            int res = Math.Min(num1, num2);

            //Rounding: Round(), Ceiling(), Floor(), Truncate()
            //floor() and truncate() do weird things with negative numbers. Floor() rounds negative numbers down to the next "more negative number". Truncate() always round to zero when the input is negative

            double num = 45.36;

            int a = (int)Math.Floor(num);

            Console.WriteLine(a);

            a = (int)Math.Ceiling(num);

            Console.WriteLine(a);

            int a1 = 5 / 2;
            double a2 = 5 / 2;
            double a3 = 5.0 / 2.0;
            double a4 = 5 / 2.0;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}",a1,a2,a3,a4);

            //Math.     min(), max(), round()

            Console.ReadLine();
        }
    }
}
