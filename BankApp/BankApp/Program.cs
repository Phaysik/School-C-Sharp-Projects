using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int accounts = 0;
            string uInput = "";

            List<Bank> Accounts = new List<Bank>(20);
            List<int> AccountNums = new List<int>(20);

            do
            {
                Console.Clear();

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
                        Interest(Accounts, AccountNums);
                        break;
                    case "p":
                        Print(Accounts, AccountNums);
                        break;
                    case "e":
                        Environment.Exit(0);
                        break;
                }

            } while (uInput.ToLower() != "e" && accounts < 20);

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

        public static string ValidateChar(string uInput)
        {
            while ((uInput.All(char.IsLetterOrDigit) == false) || (uInput != "a" && uInput != "b" && uInput != "d" && uInput != "w" && uInput != "c" && uInput != "i" && uInput != "p" && uInput != "e"))
            {
                Console.WriteLine("The transaction type must be one characters. Please re-enter: ");

                uInput = Console.ReadLine();
            }

            return uInput;
        }

        public static void Add(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("What is your name? ");

            string uInput = Console.ReadLine();

            uInput = ValidateString(uInput);

            Console.WriteLine("Please enter in your account num between the ranges of 1001-1020.");

            string newUInput = Console.ReadLine();

            int accountNum = ValidateAccountNum(newUInput, AccountNums);

            AccountNums.Add(accountNum);

            Console.WriteLine($"Opened: {accountNum}.");

            Console.WriteLine("Please enter in the amount you wish to deposit; It must be at least 100: ");

            string newestUInput = Console.ReadLine();

            double deposit = ValidateAccountDeposit(newestUInput);

            Accounts.Add(new Bank { AccountName = uInput, AccountNum = accountNum, AccountBalance = deposit });
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
            bool isUnique = true;

            isUnique = AccountNums.Distinct().Count() == AccountNums.Count();

            while ((Regex.IsMatch(uInput, @"^[0-9]+$") == false) || (Convert.ToInt32(uInput) < 1001 || Convert.ToInt32(uInput) > 1020) || (isUnique == false))
            {
                Console.WriteLine("Your input was not a unique positive whole number between the ranges of 1001-1020.\nPlease re-enter: ");

                uInput = Console.ReadLine();
            }

            return Convert.ToInt32(uInput);
        }

        public static void Balance(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter in a valid account number to check the balance of that account: ");

            string uInput = Console.ReadLine();

            int accountNum = ValidateBalanceAccountNum(uInput, AccountNums);

            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].AccountNum != accountNum)
                {
                    continue;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"The account number: {Accounts[i].AccountNum}.\nThe balance of this account is: {Accounts[i].AccountBalance:c2}.\n");
                }
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
                }
            }

            if (Checker == false)
            {
                Console.WriteLine("\nYour input was not a valid bank account number.\n");
            }

            if (AccountNums.Count == 0)
            {
                Console.WriteLine("\nYou have not opened any bank accounts.\nPlease open one before checking the balance.\n");
            }

            return Convert.ToInt32(uInput);
        }

        public static void Deposit(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter in a valid account number to deposit to: ");

            string uInput = Console.ReadLine();

            int accountNum = ValidateBalanceAccountNum(uInput, AccountNums);

            for (int x = 0; x < AccountNums.Count; x++)
            {
                if(AccountNums[x] != accountNum)
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Please enter in the amount you wish to deposit to this account: ");

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
                        }
                    }  
                }
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

            for (int x = 0; x < AccountNums.Count; x++)
            {
                if(AccountNums[x] != accountNum)
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Please enter in the amount you wish to withdraw from this account: ");

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
                        }
                    }  
                }
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

            for (int x = 0; x < AccountNums.Count; x++)
            {
                if(AccountNums[x] != accountNum)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"\nYou have closed the account with the account number of {Accounts[x].AccountNum}.\n");

                    Accounts.RemoveAt(x);
                    AccountNums.RemoveAt(x);
                }
            }
        }

        public static void Interest(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.WriteLine("Please enter in the interest rate as an integer or rational number (i.e. 10% --> input should be 10): ");

            string uInput = Console.ReadLine();

            double interest = ValidateMoreAccountDeposit(uInput);

            for (int i = 0; i < Accounts.Count; i++)
            {
                Accounts[i].AccountBalance += (Accounts[i].AccountBalance * (interest / 100));
            }
        }

        public static void Print(List<Bank> Accounts, List<int> AccountNums)
        {
            Console.Clear();

            for (int i = 0; i < Accounts.Count; i++)
            {
                Console.WriteLine($"Account name: {Accounts[i].AccountName}\n\tAccount number: {Accounts[i].AccountNum}.\n\tAccount Balance: {Accounts[i].AccountBalance:c2}.\n");
            }
        }
    }
}
