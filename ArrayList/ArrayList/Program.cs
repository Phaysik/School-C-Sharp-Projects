/*Programmer: Matthew Moore
  Description: ArrayLists
  Date: 10-10-18
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExampes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomVal = new Random();

            ArrayList array = new ArrayList(Enumerable.Range(1, 100).Select(r => randomVal.Next(1, 100)).ToArray()); //Sorts and gets a 1-100

            int random = 0;

            while(array.Count > 50)
            {
                random = randomVal.Next(0, array.Count);

                array.Remove(random);
            }

            Console.WriteLine("Contents of the removed array");

            foreach (var val in array)
            {
                Console.Write($"{val,8}");  //Displays it nicely
            }

            Console.ReadLine();
        }
    }
}
