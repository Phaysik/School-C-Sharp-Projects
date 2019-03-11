/*Programmer: Matthew Moore
Desc: Rectangle of Numbers from User Input
Date: 8-16-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n{0}{1}{2}{3}\n{4}  {5}\n{6}{7}{8}{9}",num1,num1,num1,num1,num1,num1,num1,num1,num1,num1);
            Console.ReadLine();
        }
    }
}
