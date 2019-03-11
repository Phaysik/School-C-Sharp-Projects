/*Programmer: Matthew Moore
  Description: Display Hat, Shoe, and Neck size
  Date: 8-21-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleofThumb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your current weight: ");

            decimal weight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter your current waistline: ");

            decimal waistline = Convert.ToDecimal(Console.ReadLine());

            decimal neckSize = (3 * (weight / waistline));

            decimal hatSize = ((3 * weight) / (2.125m * waistline));

            decimal shoeSize = (50 * (waistline / weight));

            Console.WriteLine("Your neck size is: {0:f2}.\nYour hat size is: {1:f2}.\nYour shoe size is: {2:f2}.",neckSize,hatSize,shoeSize);

            Console.ReadLine();
        }
    }
}
