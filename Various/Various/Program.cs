/*Programmer: Matthew Moore
Desc: Division, Equations and Answers,Placeholder, String Placeholder
Date: 8-16-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The answer to the problem, 139 / 6 is: " + 139 / 6 +"\n");
            Console.Write("-1 + 4 * 6 is equal to: " + (-1 + 4 * 6) + "\n(35 + 5) modulus 7 is equal to: " + ((35 + 5) % 7) + 
            "\n14 + -4 x 6 / 11 is equal to: " + (14 + ((-4 * 6) / 11)) + "\n2 + 15 / 6 x 1 - 7 mod 2 is equal to: " + ((2 + (15 / 6) - 7) % 2) + "\n");
            Console.Write("{0} * {1} = {2}", 5, 6, 30 + "\n");
            string s1 = "string1";
            string s2 = "string2";
            string s3 = "string3";
            Console.Write("{0},    {1},    {2}", s1, s2, s3);
            Console.ReadLine();
        }
    }
}
