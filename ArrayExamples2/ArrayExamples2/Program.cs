/*Programmer: Matthew Moore
  Description: Array Examples
  Date: 9-26-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Method()));

            string[] arr = new string[]
            {
                "cat", "dog", "mouse", "horse"
            };

            Console.WriteLine(arr[arr.Length - 1]);

            foreach(string pet in arr)
            {
                Console.WriteLine(pet);
            }

            //Create an empty array

            int[] array = new int[]{};

            Console.WriteLine(array.Length == 0);

            //Same result, different syntax

            int[] array2 = new int[0];

            Console.WriteLine(array.Length == 0);

            string[] food = { "pizza", "pie", "hamburger", "banana" };

            int foodIdx = Array.IndexOf(food, "hamburger");

            Console.WriteLine(Array.IndexOf(food, "ice cream") != -1);

            string[] elements = { "iron", "silver", "gold", "oxygen"};

            Console.WriteLine(string.Join("|", elements.Reverse()));

            string join = string.Join("|", elements);

            string[] seperated = join.Split('|');

            foreach(string x in seperated)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        static string[] Method()
        {
            string[] array = new string[3];

            array[0] = "Thank";
            array[1] = "You";
            array[2] = "you very much.";

            return array;
        }
    }
}
