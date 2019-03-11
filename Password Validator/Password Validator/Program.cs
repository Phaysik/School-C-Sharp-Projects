/*Programmer: Matthew Moore
   Description: Password Validator
   Date: 11-26-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a password based on the following specifications: ");
            Console.WriteLine("The password should be at least 8 characters long.");
            Console.WriteLine("The password should contain at least one uppercase and at least one lowercase letter.");
            Console.WriteLine("The password should have at least one special character.");
            Console.WriteLine("The password should have 1 combination of 2 numbers and a letter.");
            Console.WriteLine("The password should start with a letter.");

            string pass = Console.ReadLine();

            pass = ValidatePassword(pass);

            Console.Clear();
            Console.WriteLine($"Your validated password is {pass}");

            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }

        public static string ValidatePassword(string pass)
        {
            while (true)
            {
                if (pass.Length < 8)
                {
                    Console.WriteLine("Your password is less than eight characters. Please re-enter: ");
                    pass = Console.ReadLine();
                }
                else if (!pass.Any(char.IsUpper))
                {
                    Console.WriteLine("Your password does not have an uppercase character. Please re-enter: ");
                    pass = Console.ReadLine();
                }
                else if (!pass.Any(char.IsLower))
                {
                    Console.WriteLine("Your password does not have a lowercase character. Please re-enter: ");
                    pass = Console.ReadLine();
                }
                else if (!pass.Any(ch => !Char.IsLetterOrDigit(ch)))    //Sees if there is a special character
                {
                    Console.WriteLine("Your password does not have a special character. Please re-enter: ");
                    pass = Console.ReadLine();
                }
                else if (!Regex.IsMatch(pass, @"[A-z]\d{2}|\d{2}[A-z]")) //Sees if there is a combination of two numbers and a letter
                {
                    Console.WriteLine("Your password does not have a combination of 2 numbers and a letter. Please re-enter: ");
                    pass = Console.ReadLine();
                }
                else if (!Char.IsLetter(pass[0]))
                {
                    Console.WriteLine("Your password does not start with a letter. Please re-enter: ");
                    pass = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return pass;
        }
    }
}
