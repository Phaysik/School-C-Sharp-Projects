using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tot = Calculate();

            Console.WriteLine("The sum of all even numbers in the fibonnaci sequence whose values are lower than 4 million is: {0:n0}", tot);

            Console.ReadLine();
        }

        public static int Calculate()
        {
            int[] newFib = new int[34];

            int total = 0;

            int arrayLength = newFib.Length;

            newFib[0] = 0;
            newFib[1] = 1;

            for(int i = 2; i < 34; i++)
            {
                newFib[i] = newFib[i - 2] + newFib[i - 1];
            }

            for(int l = 0; l < arrayLength; l++)
            {
                if((newFib[l] % 2) == 0)
                {
                    total += newFib[l];
                }
            }

            return total;
        }
    }
}
