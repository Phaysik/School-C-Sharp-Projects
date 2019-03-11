/*Programmer: Matthew Moore
  Description: Array List Examples
  Date: 10-10-18
*/
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Array - strongly typed
   ArrayList - stores any type of data
   Array - fixed number of elements
   ArrayList - grows automatically and no size is needed
*/
namespace ArrayListExampes
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(true);
            a.Add("string");
            a.Add(34.55);

            Console.WriteLine(a.Count);

            Console.WriteLine(a.Contains(34.55));

            Console.WriteLine(a[1]);

            a.RemoveAt(1);

            Console.WriteLine(a[1]);

            a.Insert(1, "New Item");

            foreach (var val in a)
            {
                Console.WriteLine(val);
            }

            ArrayList b = new ArrayList();

            b.Add(99);
            b.Add("2nd array");
            b.InsertRange(2, a);

            foreach (var val in b)
            {
                Console.WriteLine(val);
            }

            a.Reverse();

            foreach (var val in a)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
