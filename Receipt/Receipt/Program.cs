/*Programmer: Matthew Moore
   Description: Recipt Classes
   Date: 10-23-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            receipt newReceipt = new receipt("1234 One Lane Road", 14.45);

            newReceipt.CustomerName = GetCustomerName();
            newReceipt.CustomerNum = GetCustomerNum();
            newReceipt.CustomerPhone = GetCustomerPhone();
            newReceipt.ReciptNum = GetReceiptNum();
            newReceipt.ItemDesc = GetItemDesc();
            newReceipt.ItemNum = GetItemNum();
            newReceipt.QuantPurchased = GetQuantity();

            Console.Clear();
            Console.WriteLine(newReceipt.ToString() + "\n\nPress any key to continue...");

            Console.ReadKey();
        }
        public static int GetCustomerPhone()
        {
            Console.WriteLine("Enter the customer's phone number (10 characters): ");

            string uInput = Console.ReadLine();

            int val = ValidatePhone(uInput);

            return val;
        }

        public static int GetQuantity()
        {
            Console.WriteLine("Enter the quantity purchased: ");

            string uInput = Console.ReadLine();

            int val = ValidateInt(uInput);

            return val;
        }

        public static int GetItemNum()
        {
            Console.WriteLine("Enter the item's number: ");

            string uInput = Console.ReadLine();

            int val = ValidateInt(uInput);

            return val;
        }

        public static int GetReceiptNum()
        {
            Console.WriteLine("Enter the customer's receipt number: ");

            string uInput = Console.ReadLine();

            int val = ValidateInt(uInput);

            return val;
        }

        public static int GetCustomerNum()
        {
            Console.WriteLine("Enter the customer's ticket number: ");

            string uInput = Console.ReadLine();

            int val = ValidateInt(uInput);

            return val;
        }

        public static string GetCustomerName()
        {
            Console.WriteLine("Enter the customer's name: ");

            string uInput = Console.ReadLine();

            return (uInput = ValidateString(uInput));
        }

        public static string GetItemDesc()
        {
            Console.WriteLine("Enter the item's description: ");

            string uInput = Console.ReadLine();

            return (uInput = ValidateItem(uInput));
        }

        public static string ValidateString(string uInput)
        {
            while (Regex.IsMatch(uInput, @"^[a-zA-Z ]+$") == false)
            {
                Console.WriteLine("Your input was not completely letters; please re-enter: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static string ValidateItem(string uInput)
        {
            while (Regex.IsMatch(uInput, @"^[a-zA-Z0-9 ]+$") == false)
            {
                Console.WriteLine("Your input was invalid. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static int ValidateInt(string uInput)
        {
            while (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
            {
                Console.WriteLine("Your input was not a positive numeric value;\nplease re-enter in a positive number: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }

        public static int ValidatePhone(string uInput)
        {
            while (true)
            {
                if (Regex.IsMatch(uInput, @"^[0-9]+$") == false)
                {
                    Console.WriteLine("Your input was not a positive numeric value;\nplease re-enter in a positive number: ");

                    uInput = Console.ReadLine();
                }

                else if (uInput.Length != 10)
                {
                    Console.WriteLine("Your input was not 10 characters;\npelase re-enter in 10 positive numeric characters: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return Convert.ToInt32(uInput);
        }
    }
}
