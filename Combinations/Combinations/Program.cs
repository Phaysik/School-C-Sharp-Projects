/*Programmer: Matthew Moore
  Description: Combinations
  Date: 8-22-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {

            string unique1 = "";
            string unique2 = "";
            string unique3 = "";
            string unique4 = "";
            string unique5 = "";
            string unique6 = "";    //Declare string values for later concatenation of the three use unique numbers

            int checker1 = 0;
            int checker2 = 0;
            int checker3 = 0;
            int checker4 = 0;
            int checker5 = 0;
            int checker6 = 0;   //Declare int values to later prevent the switch from executing the same case statement 
            List<int> checker = new List<int>();    //Create a list to hold the aforementioned integers
            checker.Add(checker1);
            checker.Add(checker2);
            checker.Add(checker3);
            checker.Add(checker4);
            checker.Add(checker5);
            checker.Add(checker6);  //Add the int values to the list so the index is not out of range in the for loop

            int numers1 = 0;
            int numers2 = 0;
            int numers3 = 0;
            int numers4 = 0;
            int numers5 = 0;
            int numers6 = 0;    //Declare more int values for later parsing the unique string values back into integers




            Console.WriteLine("You will need to enter three unique digits between (0-9).");
            Console.WriteLine("Please enter your first unique digit between (0-9): ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second unique digit between (0-9): ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your final unique digit between (0-9): ");

            int num3 = Convert.ToInt32(Console.ReadLine());

            while ((num1 == num2) || (num1 == num3) || (num2 == num3))  //Loop until the user inputs three different numbers
            {
                if (num1 == num2)
                {
                    Console.WriteLine("Please re-enter your first number from (0-9) that doesn't equal: "
                                     + num2 + " or " + num3);

                    num1 = Convert.ToInt32(Console.ReadLine());
                }

                else if (num1 == num3)
                {
                    Console.WriteLine("Please re-enter your first number from (0-9) that doesn't equal: "
                                     + num2 + " or " + num3);

                    num1 = Convert.ToInt32(Console.ReadLine());
                }

                else if (num2 == num3)
                {
                    Console.WriteLine("Please re-enter your second number from (0-9) that doesn't equal: "
                                     + num1 + " or " + num3);

                    num2 = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Your three unique numbers are: " + num1 + ", " + num2 + ", " + num3);

            Random randomNum = new Random();

            for (int i = 1; i < 7; i++) //Create a for loop for getting the six unique possible number combinations
            {
                int num4 = randomNum.Next(1, 7);    //Values between 1 and 6

                if (checker[num4 - 1] != 1)   //Check the created list "checker" with the random number acting as its index against a does not equal '1'
                {

                    switch (num4)   //Create a switch statement to be able to easily see what is executed on each value of the random number
                    {
                        case 1: //The cases will remove the current element at the desired index according to the value at the end of the variable, set the previous int checker[i]s to 1, and proceed to re-insert it back at the desired index
                                //I actually don't quite understand why I had to remove it and then re-add it after changing the vars value. I thought it would update it like it would in Javascript
                            unique1 = num1.ToString() + num2.ToString() + num3.ToString();
                            checker.RemoveAt(0);
                            checker1 = 1;
                            checker.Insert(0, checker1);
                            break;

                        case 2:
                            unique2 = num1.ToString() + num3.ToString() + num2.ToString();
                            checker.RemoveAt(1);
                            checker2 = 1;
                            checker.Insert(1, checker2);
                            break;

                        case 3:
                            unique3 = num2.ToString() + num1.ToString() + num3.ToString();
                            checker.RemoveAt(2);
                            checker3 = 1;
                            checker.Insert(2, checker3);
                            break;

                        case 4:
                            unique4 = num2.ToString() + num3.ToString() + num1.ToString();
                            checker.RemoveAt(3);
                            checker4 = 1;
                            checker.Insert(3, checker4);
                            break;

                        case 5:
                            unique5 = num3.ToString() + num1.ToString() + num2.ToString();
                            checker.RemoveAt(4);
                            checker5 = 1;
                            checker.Insert(4, checker5);
                            break;

                        case 6:
                            unique6 = num3.ToString() + num2.ToString() + num1.ToString();
                            checker.RemoveAt(5);
                            checker6 = 1;
                            checker.Insert(5, checker6);
                            break;

                    }
                }

                else
                {   //If the list "checker" with the random number, 'num4' is 1, then this statement will remove one value from 'i' to keep this loop working without breaking after only getting 1-5 unique strings
                    i--;
                }
            }

            Console.WriteLine("Your six unique combinations of numbers is: \n" + unique1 + "\n" + unique2 + "\n" + unique3 + "\n" + unique4 + "\n" + unique5 + "\n" + unique6);

            numers1 = Int32.Parse(unique1); //Parse all the unique strings to integers to add them in the next WriteLine()
            numers2 = Int32.Parse(unique2);
            numers3 = Int32.Parse(unique3);
            numers4 = Int32.Parse(unique4);
            numers5 = Int32.Parse(unique5);
            numers6 = Int32.Parse(unique6);

            Console.WriteLine("The sum of the six unique combination is: " + (numers1 + numers2 + numers3 + numers4 + numers5 + numers6));

            Console.ReadLine();

            //This took me about two hours to get all of this to work properly due to array being so obnoxious in this language

        }
    }
}
