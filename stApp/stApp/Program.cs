using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace stApp
{
    class Program
    {
        static void Main(string[] args)
        {
            student firstStudentObject = new student();
            student secondStudentObject = new student(2356);
            student thirdStudentObject = new student(5678, "Spade", "Sam");
            student lastStudentObject = new student(8975, "John", "Kruger", 45, 65, 76, "Computer Science");

            firstStudentObject.StudentLastName = AskforStudentName("Last");
            firstStudentObject.StudentFirstName = AskforStudentName("First");
            firstStudentObject.StudentNumber = AskforStudentNumber();
            firstStudentObject.Major = AskforMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.Score1 = AskforScore(1);
            firstStudentObject.Score2 = AskforScore(2);
            firstStudentObject.Score3 = AskforScore(3);
            secondStudentObject.Score1 = AskforScore(1);
            secondStudentObject.Score2 = AskforScore(2);
            secondStudentObject.Score3 = AskforScore(3);
            thirdStudentObject.Score1 = AskforScore(1);
            thirdStudentObject.Score2 = AskforScore(2);
            thirdStudentObject.Score3 = AskforScore(3);

            Console.Clear();

            Console.WriteLine("First Student");
            Console.WriteLine(firstStudentObject.ToString());
            Console.WriteLine("\n\nSecond Student");
            Console.WriteLine(secondStudentObject.ToString());
            Console.WriteLine("\n\nThird Student");
            Console.WriteLine(thirdStudentObject.ToString());
            Console.WriteLine("\n\nLast Student");
            Console.WriteLine(lastStudentObject);
            Console.WriteLine($"\n\nPress any key to continue...");

            Console.ReadKey();
        }

        public static string AskforStudentName(string whichone)
        {
            Console.WriteLine($"Enter student {whichone} Name: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[a-zA-Z ]+$") == false)
            {
                Console.WriteLine("Please only enter alphabetic characters: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static string AskforMajor(string fName)
        {
            Console.WriteLine($"Please enter {fName}'s major: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[a-zA-Z ]+$") == false)
            {
                Console.WriteLine("Please only enter alphabetic characters: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static int AskforStudentNumber()
        {
            Console.WriteLine($"Enter student number: ");

            string uInput = Console.ReadLine();

            while (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a number: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }

        public static int AskforScore(int val)
        {
            Console.WriteLine($"Enter a value for Score{val}: ");

            string uInput = Console.ReadLine();

            while(Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a number: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }
    }
}
