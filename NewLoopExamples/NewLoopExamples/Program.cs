/*Programmer: Matthew Moore
  Description: More loop examples
  Date: 9-19-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for(int val = 0; val < 10; val++)
            {
                if(val == 5)
                {
                    break;
                }

                total += val;

                Console.WriteLine(val + "\t");
            }

            Console.ReadLine();
        }
    }
}
