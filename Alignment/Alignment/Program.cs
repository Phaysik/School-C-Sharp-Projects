using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t{0,-20} {1,-25}","Student Name:","Debbie Downer");
            Console.WriteLine("\t{0,-20} {1,-25}","Total credits: ", "43");
            Console.WriteLine("\t{0,-20}{1,11:C}","College Cost", 20034.04);
            Console.WriteLine("\t{0,-20}{1,10:C}", "Dorm Cost", 8039.65);
            Console.ReadLine();
        }
    }
}
