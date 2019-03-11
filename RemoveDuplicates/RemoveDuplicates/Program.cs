/*Programmer: Matthew Moore
  Description: Remove Duplicates
  Date: 9-28-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will remove duplicates from a list of 25 items. The values will all be randomized from 1-20.");

            List<int> randomized = Rrandom();

            List<string> item = new List<string>();

            int z = 1;

            for (int i = 0; i < randomized.Count; i++)
            {
               item.Add($"{randomized[i]}");

                if (item.Count <= (8 * z))
                {
                    Console.Write(item[i] + " ");
                }

                if (item.Count == (8 * z))
                {
                    Console.WriteLine();
                    z++;
                }
            }

            Duplicate(randomized);

            Console.ReadLine();
        }

        public static void Duplicate(List<int> randomized)
        {
            List<int> dup = new List<int>();
            List<int> dupe = new List<int>();

            int dupes = 0;

            for(int i = 0; i < randomized.Count; i++)
            {
                if (!dup.Contains(randomized[i]))
                {
                    dup.Add(randomized[i]);
                }

                else
                {
                    dupes++;
                    if (!dupe.Contains(randomized[i]))
                    {
                        dupe.Add(randomized[i]);
                    }
                }
            }

            Console.WriteLine($"\n\nCout of Dupes: {dupes}\nCount of Non-Dups: {randomized.Count - dupes}\n\nRemoved Duplicates");

            foreach(int val in dup)
            {
                Console.Write($"{val} ");
            }

            Console.WriteLine("\n\nThe duplicated value(s) are: ");

            foreach(int vals in dupe)
            {
                Console.Write($"{vals} ");
            }
        }

        public static List<int> Rrandom()
        {
            Random randomval = new Random();

            List<int> items = new List<int>();

            int val = 0;

            for(int i = 0; i < 25; i++)
            {
                val = randomval.Next(1, 21);

                items.Add(val);
            }

            return items;
        }
    }
}
