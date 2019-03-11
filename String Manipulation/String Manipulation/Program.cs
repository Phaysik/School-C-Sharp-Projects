/*Programmer: Matthew Moore
   Description: String Manipulation
   Date: 11-26-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Albert";
            lname = "Enstein";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sArray = { "Today", "is", "Monday." };

            string fullname = fname + lname;
            Console.WriteLine($"Full Name: {fullname}.\n");

            //Using string constructor
            string greetings = new string(letters);
            Console.WriteLine(greetings + "\n");

            //join
            string message = String.Join(" ", sArray);
            Console.WriteLine(message + "\n");

            //formatting method to convert a value
            DateTime waiting = new DateTime(2018, 11, 26, 13, 58, 1);
            string chat = String.Format($"Message send at {waiting:t} on {waiting:D}.");
            Console.WriteLine(chat + "\n");

            //comparing strings
            string str1 = "Today is Monday.";
            string str2 = "Today is Midday.";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine($"{str1} and {str2} are equal.\n");
            }
            else
            {
                Console.WriteLine($"{str1} and {str2} are not equal.\n");

            }

            //String contains string
            string str = "Today is Monday.";

            if (str.Contains("day"))
            {
                Console.WriteLine($"The sequence 'day' was found.\n");
            }
            else
            {
                Console.WriteLine($"The sequence 'day' was not found.\n");
            }

            //Getting a substring
            string stra = "The wise never marry and when the marry, they become otherwise.";
            string substr = stra.Substring(4, 4); //First is the index posistion and second is the length
                                                  //1 number it goest to that index position and take from there to end and puts it into the string.
            Console.WriteLine(substr + "\n");

            //Joining string
            string[] strarray = new string[] { "You don't know", "what you have", "until it's gone.", "For example,", "toilet paper." };
            string strb = string.Join("\n", strarray);

            Console.WriteLine($"{strb}\n");

            //string to char array
            string x = "Expert";
            char[] arr = x.ToCharArray();
            string array = new string(arr);

            Console.WriteLine($"{array}\n");

            //Empty and Null strings
            Console.WriteLine("Enter your name: ");

            string name = Console.ReadLine();

            if (name == string.Empty)
            {
                Console.WriteLine("The name field cannot be left empty.\n");
                name = null;
            }
            else
            {
                Console.WriteLine($"There are {name.Length} characters in your name.\n");
            }

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Name has been set to null.\n");
            }
            else
            {
                Console.WriteLine($"Name has been set to {name}.\n");
            }

            //startswith
            string namex = "Albert is an Einstein";

            Console.WriteLine($"{namex.StartsWith("Albert")}\n");

            //endswith
            Console.WriteLine($"{namex.EndsWith("Einstein.")}\n");

            //Indexof
            namex = "expert";
            Console.WriteLine($"{namex.IndexOf("per")}\n");
            Console.WriteLine($"{namex.IndexOf("PER", StringComparison.InvariantCultureIgnoreCase)}\n");

            //insert
            name = "Expert";
            string sub = name.Insert(2, "--"); //2 is the position where the value will be inserted at
            Console.WriteLine($"{sub}\n");

            //remove
            name = sub;
            sub = name.Remove(2, 2);
            Console.WriteLine($"{sub}\n");

            //trim
            name = "          I am in the class today.         ";
            sub = name.Trim();  //When nothing is specified, it will trim white spaces from the start and end. TrimStart or TrimEnd methods
            Console.WriteLine($"{sub}\n");

            //split
            string[] strx = sub.Split();

            foreach(string ele in strx)
            {
                Console.WriteLine($"{ele}\n");
            }

            //replace
            string greet = "Hi Albert Einstein";
            greet = greet.Replace("Hi", "Hello");
            Console.WriteLine($"{greet}\n");

            

            Console.ReadKey();
        }
    }
}
