using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int accounts = 0, managerPin = 1234;
            string uInput = "";

            List<Bank> Accounts = new List<Bank>(20);
            List<int> AccountNums = new List<int>(20);

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"O - Opens the bank.\nE - Exits the application");
                Console.WriteLine("\nWhat transaction type do you want?");

                uInput = Console.ReadLine();

                bool isOpen = false;

                if (uInput == "o")
                {
                    Console.Clear();

                    isOpen = Open(Accounts, AccountNums, managerPin);
                }
                else if (uInput == "e")
                {
                    Environment.Exit(0);
                }

                if (isOpen == true)
                {
                    break;
                }
            }

            do
            {
                DisplayMenu();

                Console.WriteLine("\nWhat transaction type do you want?");

                uInput = Console.ReadLine();

                uInput = ValidateChar(uInput);

                Console.Clear();

                switch (uInput.ToLower())
                {
                    case "a":
                        Add(Accounts, AccountNums);
                        break;
                    case "b":
                        Balance(Accounts, AccountNums);
                        break;
                    case "d":
                        Deposit(Accounts, AccountNums);
                        break;
                    case "w":
                        Withdrawl(Accounts, AccountNums);
                        break;
                    case "c":
                        Close(Accounts, AccountNums);
                        break;
                    case "i":
                        Interest(Accounts, managerPin);
                        break;
                    case "p":
                        Print(Accounts, managerPin);
                        break;
                    case "e":
                        Exit(managerPin);
                        break;
                }

            } while (accounts < 20);

            Console.ReadLine();
        }

        public static void DisplayMenu()
        {
            string[] inputChars = new string[] { "A", "B", "D", "W", "C", "I", "P", "E" };
            string[] descriptions = new string[] { "Open an account", "Check the balance of an account", "Deposit money to an account", "Withdraw money from an account", "Close an account", "Apply an interest rate to all account", "Print out all the accounts", "Exits the application"};

            for (int i = 0; i < inputChars.Length; i++)
            {
                Console.WriteLine($"{ inputChars[i]} - {descriptions[i]}");
            }
        }

        public static void Exit(int managersPin)
        {
            Console.WriteLine("Please enter in the manager's pin to exit the application: ");

            string uInput = Console.ReadLine();

            int manPin = ValidateManagerPin(uInput);

            if(manPin == managersPin)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nYou entered the incorrect pin.\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }
        }

        public static bool Open(List<Bank> Accounts, List<int> AccountNums, int managerPin)
        {
            Console.WriteLine("Please enter in the manager pin to open the bank: ");

            string uInput = Console.ReadLine();

            int manPin = ValidateManagerPin(uInput);

            if(manPin != managerPin)
            {
                Console.WriteLine("You do not have permission to do this action.");

                return false;
            }
            else
            {
                Console.WriteLine("\nYou have opened the bank.\n\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear();

                return true;
            }
        }

        public static int ValidateManagerPin(string uInput)
        {
            while ((Regex.IsMatch(uInput, @"^[0-9]+$") == false) || (uInput.Length != 4))
            {
                Console.WriteLine("\nYour input was not a four digit positive whole number.\n\nPlease re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }

        public static string ValidateChar(string uInput)
        {
            while ((uInput.All(char.IsLetterOrDigit) == false) || (uInput != "a" && uInput != "b" && uInput != "d" && uInput != "w" && uInput != "c" && uInput != "i" && uInput != "p" && uInput != "e" && uInput != "o"))
            {
                Console.WriteLine("The transaction type must be one character. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static void Add(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("What is your name?");

            string uInput = Console.ReadLine();

            uInput = ValidateString(uInput);

            Console.WriteLine("\nPlease enter in your account num between the ranges of 1001-1020.");

            string newUInput = Console.ReadLine();

            int accountNum = ValidateAccountNum(newUInput, AccountNums);

            AccountNums.Add(accountNum);

            accountNum = ValidateAccountNum(newUInput, AccountNums);

            Console.WriteLine($"\nOpened: {accountNum}.");

            Console.WriteLine("\nPlease enter in the four digit pin you wish to assign to this account: ");

            string newerUInput = Console.ReadLine();

            int accountPin = ValidateManagerPin(newerUInput);

            Console.WriteLine($"\nPin assigned: {accountPin}.");

            Console.WriteLine("\nPlease enter in the amount you wish to deposit; It must be at least 100: ");

            string newestUInput = Console.ReadLine();

            double deposit = ValidateAccountDeposit(newestUInput);

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            Accounts.Add(new Bank { AccountName = textInfo.ToTitleCase(uInput), AccountNum = accountNum, AccountBalance = deposit, AccountPin = accountPin });
            
            Console.WriteLine("\nPlease press any key to continue...");

            Console.ReadKey();

            Console.Clear();
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

        public static double ValidateAccountDeposit(string uInput)
        {
            while ((Regex.IsMatch(uInput, @"^[0-9]*(?:\.[0-9]*)?$") == false) || (Convert.ToDouble(uInput) < 100))
            {
                Console.WriteLine("Your input was not a positive numeric value above 100. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToDouble(uInput);
        }

        public static int ValidateAccountNum(string uInput, List<int> AccountNums)
        {
            bool isUnique = true, checker = true;

            isUnique = AccountNums.Distinct().Count() == AccountNums.Count();

            while ((Regex.IsMatch(uInput, @"^[0-9]+$") == false) || (Convert.ToInt32(uInput) < 1001 || Convert.ToInt32(uInput) > 1020))
            {
                Console.WriteLine("\nYour input was not a unique positive whole number between the ranges of 1001-1020.\n\nPlease re-enter: ");

                uInput = Console.ReadLine();
            }

            while(isUnique == false)
            {
                AccountNums.RemoveAt(AccountNums.Count - 1);

                Console.WriteLine("\nYour input was not a unique account number.\n\nPlease re-enter: ");

                uInput = Console.ReadLine();

                checker = false;

                isUnique = AccountNums.Distinct().Count() == AccountNums.Count();

                ValidateAccountNum(uInput, AccountNums);
            }

            if(checker == false)
            {
                AccountNums.Add(Convert.ToInt32(uInput));
            }

            return Convert.ToInt32(uInput);
        }

        public static void Balance(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter in a valid account number to check the balance of that account: ");

            string uInput = Console.ReadLine();

            int accountNum = ValidateBalanceAccountNum(uInput, AccountNums);

            Console.WriteLine("\nPlease enter the pin assigned to this account: ");

            uInput = Console.ReadLine();

            int accountPin = ValidateManagerPin(uInput);

            bool checker = false;

            for (int i = 0; i < Accounts.Count; i++)
            {
                if ((Accounts[i].AccountNum != accountNum) || (Accounts[i].AccountPin != accountPin))
                {
                    continue;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"The account number: {Accounts[i].AccountNum}.\nThe balance of this account is: {Accounts[i].AccountBalance:c2}.\n");

                    Console.WriteLine("\nPlease press any key to continue...");

                    Console.ReadKey();

                    Console.Clear();

                    checker = true;
                }
            }

            if(checker == false)
            {
                Console.WriteLine("\nThe pin you entered did not match the pin of the account.\n\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }
        }

        public static int ValidateBalanceAccountNum(string uInput, List<int> AccountNums)
        {
            bool Checker = true;
            for (int i = 0; i < AccountNums.Count; i++)
            {
                if (AccountNums[i] != Convert.ToDouble(uInput))
                {
                    Checker = false;
                }
                else
                {
                    Checker = true;
                    break;
                }
            }

            if (Checker == false)
            {
                Console.WriteLine("\nYour input was not a valid bank account number.\n");

                Console.WriteLine("Please press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }

            if (AccountNums.Count == 0)
            {
                Console.WriteLine("\nYou have not opened any bank accounts.\nPlease open one before checking the balance.\n");

                Console.WriteLine("Please press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }

            return Convert.ToInt32(uInput);
        }

        public static void Deposit(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter in a valid account number to deposit to: ");

            string uInput = Console.ReadLine();

            int accountNum = ValidateBalanceAccountNum(uInput, AccountNums);

            Console.WriteLine("\nPlease enter the pin assigned to this account: ");

            uInput = Console.ReadLine();

            int accountPin = ValidateManagerPin(uInput);

            bool checker = false;

            for (int x = 0; x < AccountNums.Count; x++)
            {
                if((AccountNums[x] != accountNum) || (Accounts[x].AccountPin != accountPin))
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("\nPlease enter in the amount you wish to deposit to this account: ");

                    uInput = Console.ReadLine();

                    double deposit = ValidateMoreAccountDeposit(uInput);

                    for (int i = 0; i < Accounts.Count; i++)
                    {
                        if (Accounts[i].AccountNum != accountNum)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Clear();

                            Accounts[i].AccountBalance += deposit;

                            Console.WriteLine($"The account number: {Accounts[i].AccountNum}.\nThe balance of this account is: {Accounts[i].AccountBalance:c2}.\n");

                            Console.WriteLine("Please press any key to continue...");

                            Console.ReadKey();

                            Console.Clear();

                            checker = true;
                        }
                    }  
                }
            }

            if (checker == false)
            {
                Console.WriteLine("\nThe pin you entered did not match the pin of the account.\n\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }

        }

        public static double ValidateMoreAccountDeposit(string uInput)
        {
            while (Regex.IsMatch(uInput, @"^[0-9]*(?:\.[0-9]*)?$") == false)
            {
                Console.WriteLine("Your input was not a positive numeric value. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToDouble(uInput);
        }

        public static void Withdrawl(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter in a valid account number to withdraw from: ");

            string uInput = Console.ReadLine();

            int accountNum = ValidateBalanceAccountNum(uInput, AccountNums);

            Console.WriteLine("\nPlease enter the pin assigned to this account: ");

            uInput = Console.ReadLine();

            int accountPin = ValidateManagerPin(uInput);

            bool checker = false;

            for (int x = 0; x < AccountNums.Count; x++)
            {
                if ((AccountNums[x] != accountNum) || (Accounts[x].AccountPin != accountPin))
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("\nPlease enter in the amount you wish to withdraw from this account: ");

                    uInput = Console.ReadLine();

                    double withdraw = ValidateWithdraw(uInput, accountNum, Accounts);

                    for (int i = 0; i < Accounts.Count; i++)
                    {
                        if (Accounts[i].AccountNum != accountNum)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Clear();

                            Accounts[i].AccountBalance -= withdraw;

                            Console.WriteLine($"The account number: {Accounts[i].AccountNum}.\nThe balance of this account is: {Accounts[i].AccountBalance:c2}.\n");

                            Console.WriteLine("Please press any key to continue...");

                            Console.ReadKey();

                            Console.Clear();

                            checker = true;
                        }
                    }  
                }
            }

            if (checker == false)
            {
                Console.WriteLine("\nThe pin you entered did not match the pin of the account.\n\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }
        }

        public static double ValidateWithdraw(string uInput, int accountNum, List<Bank> Accounts)
        {
            bool Checker = true;

            while (true)
            {
                Checker = true;

                while (Regex.IsMatch(uInput, @"^[0-9]*(?:\.[0-9]*)?$") == false)
                {
                    Console.WriteLine("Your input was not a positive numeric value. Please re-enter: ");

                    uInput = Console.ReadLine();

                    Checker = false;
                }

                for (int i = 0; i < Accounts.Count; i++)
                {
                    if(Accounts[i].AccountNum != accountNum)
                    {
                        continue;
                    }
                    else
                    {
                        while(Convert.ToDouble(uInput) > Accounts[i].AccountBalance)
                        {
                            Console.WriteLine("The value you wish to withdraw is greater than the account balance.\nPlease re-enter: ");

                            uInput = Console.ReadLine();

                            Checker = false;
                        }
                    }
                }

                if(Checker == true)
                {
                    break;
                }
            }

            return Convert.ToDouble(uInput);
        }

        public static void Close(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter a valid account to close.");

            string uInput = Console.ReadLine();

            int accountNum = ValidateBalanceAccountNum(uInput, AccountNums);

            Console.WriteLine("\nPlease enter the pin assigned to this account: ");

            uInput = Console.ReadLine();

            int accountPin = ValidateManagerPin(uInput);

            bool checker = false;

            for (int x = 0; x < AccountNums.Count; x++)
            {
                if((AccountNums[x] != accountNum) || (Accounts[x].AccountPin != accountPin))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"\nYou have closed the account with the account number of {Accounts[x].AccountNum}.\n");

                    Accounts.RemoveAt(x);
                    AccountNums.RemoveAt(x);

                    Console.WriteLine("Please press any key to continue...");

                    Console.ReadKey();

                    Console.Clear();

                    checker = true;
                }
            }

            if (checker == false)
            {
                Console.WriteLine("\nThe pin you entered did not match the pin of the account.\n\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }
        }

        public static void Interest(List<Bank> Accounts, int managersPin)
        {
            Console.WriteLine("Please enter in the manager's pin to set an interest for all accounts: ");

            string uInput = Console.ReadLine();

            int manPin = ValidateManagerPin(uInput);

            if(manPin != managersPin)
            {
                Console.WriteLine("\nThe pin you eneted was incorrect.\nPress any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }

            else
            {
                Console.Clear();

                Console.WriteLine("Please enter in the interest rate as an integer or rational number\n(i.e. 10% --> input should be 10): ");

                uInput = Console.ReadLine();

                double interest = ValidateMoreAccountDeposit(uInput);

                for (int i = 0; i < Accounts.Count; i++)
                {
                    Accounts[i].AccountBalance += (Accounts[i].AccountBalance * (interest / 100));
                }

                Console.WriteLine("\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear(); 
            }
        }

        public static void Print(List<Bank> Accounts, int managersPin)
        {
            Console.WriteLine("Please enter in the manager's pin to view all account information: ");

            string uInput = Console.ReadLine();

            int manPin = ValidateManagerPin(uInput);

            if (manPin != managersPin)
            {
                Console.WriteLine("\nThe pin you eneted was incorrect.\nPress any key to continue...");

                Console.ReadKey();

                Console.Clear();
            }

            else
            {
                Console.Clear();

                for (int i = 0; i < Accounts.Count; i++)
                {
                    Console.WriteLine($"Account name: {Accounts[i].AccountName}\n\tAccount number: {Accounts[i].AccountNum}.\n\tAccount Balance: {Accounts[i].AccountBalance:c2}.\n");
                }

                Console.WriteLine("\nPlease press any key to continue...");

                Console.ReadKey();

                Console.Clear(); 
            }
        }
    }
}
