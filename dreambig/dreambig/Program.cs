/*Programmer: Matthew Moore
 * Desc: Three different outputs of the same line
 * Date: 8-16-18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dreambig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Output #1\n");
            Console.Write("Laugh often, ");
            Console.Write("Dream big, ");
            Console.Write("Reach for the stars!\n\n");
            Console.Write("Output #2\n");
            Console.Write("Laugh often,\n");
            Console.Write("Dream big,\n");
            Console.Write("Reach for the stars!\n\n");
            Console.WriteLine("Output #3");
            Console.WriteLine("\tLaugh");
            Console.WriteLine("\toften,");
            Console.WriteLine("\tDream");
            Console.WriteLine("\tbig,");
            Console.WriteLine("\tReach");
            Console.WriteLine("\tfor");
            Console.WriteLine("\tthe");
            Console.WriteLine("\tstars!");
            Console.ReadLine();
        }
    }
}
