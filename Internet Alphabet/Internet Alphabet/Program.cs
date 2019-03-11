/*Programmer: Matthew Moore
   Description: Internet Alphabet
   Date: 11-27-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"a", "@"},
                { "b", "8" },
                { "c", "(" },
                { "d", "|)" },
                { "e", "3" },
                { "f", "#" },
                { "g", "6" },
                { "h", "[-]" },
                { "i", "|" },
                { "j", "_|" },
                { "k", "|<" },
                { "l", "1" },
                { "m", "[]\\/[]" },
                { "n", "[]\\[]" },
                { "o", "0" },
                { "p", "|D" },
                { "q", "(,)" },
                { "r", "|Z" },
                { "s", "$" },
                { "t", "']['" },
                { "u", "|_|" },
                { "v", "\\/" },
                { "w", "\\/\\/" },
                { "x", "}{" },
                { "y", "`/" },
                { "z", "2" }
            };
            Console.WriteLine("Please enter in a string of characters: ");

            string line = Console.ReadLine().ToLower();

            if(line.Length > 5000)
            {
                line.Substring(0, 5000);
            }

            dict.ToList().ForEach(pair => { line = line.Replace(pair.Key, pair.Value); });  //Converts the dictionary to a list and then loops over every item. Will then replace the given key with the given value if it matches.

            Console.WriteLine(line);

            Console.WriteLine("Please press any key to continue...");
            Console.ReadLine();
        }
    }
}
