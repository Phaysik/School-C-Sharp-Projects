/*Programmer: Matthew Moore
  Description: Calculate change from user input
  Date: 8-23-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> monType = new List<string>();
            monType.Add("hundred bill(s)");
            monType.Add("fifty(fifties)");
            monType.Add("twenty(twenties)");
            monType.Add("ten(s)");
            monType.Add("five(s)");
            monType.Add("two(s)");
            monType.Add("dollar(s)");
            monType.Add("quarter(s)");
            monType.Add("dime(s)");
            monType.Add("nickle(s)");
            monType.Add("penny(pennies)");

            List<decimal> dolType = new List<decimal>();

            List<decimal> monCurr = new List<decimal>();
            monCurr.Add(100m);
            monCurr.Add(50m);
            monCurr.Add(20m);
            monCurr.Add(10m);
            monCurr.Add(5m);
            monCurr.Add(2m);
            monCurr.Add(1m);
            monCurr.Add(.25m);
            monCurr.Add(.10m);
            monCurr.Add(.05m);
            monCurr.Add(.01m);

            List<decimal> monCompare = new List<decimal>();
            monCompare.Add(100m);
            monCompare.Add(50m);
            monCompare.Add(20m);
            monCompare.Add(10m);
            monCompare.Add(5m);
            monCompare.Add(2m);
            monCompare.Add(1m);
            monCompare.Add(.25m);
            monCompare.Add(.10m);
            monCompare.Add(.05m);
            monCompare.Add(.01m);

            Console.WriteLine("Please enter the total cost of your sale: ");

            decimal totSale = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter how much you are paying with: ");

            decimal userPay = Convert.ToDecimal(Console.ReadLine());

            while (userPay < totSale) //Prevent the user from paying will less money than what is required
            {
                Console.WriteLine("Please enter a value more than what your total sale cost: ");

                userPay = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("Please enter a valid currency type from $100-$.01");

            string validCurr = Console.ReadLine();
            string currStop = "";
            int totCurr = 0;

            decimal valCurr;

            while ((currStop != "end") && (totCurr != 11))
            {
                if (!(decimal.TryParse(validCurr, out valCurr)))
                {
                    Console.WriteLine("Please re-enter a valid currency type from $100-$.01.");
                    validCurr = Console.ReadLine();
                }
                for (int k = 0; k < monType.Count; k++)
                {
                    if ((currStop == "end") || (monCurr.Count == 0))
                    {
                        break;
                    }

                    for (int j = 0; j < monCurr.Count; j++)
                    {
                        if (monCurr.Count != 0)
                        {
                            if (monCurr[j] == Convert.ToDecimal(validCurr))
                            {
                                monCurr.RemoveAt(j);

                                dolType.Add(Convert.ToDecimal(validCurr));

                                Console.WriteLine("If you would like to get more exact with you change, then please enter a lower\nvalue than what you previously entered, but still a valid currency type.\nIf you are happy with the amount of precision you currently have, please type\n'end'.");

                                totCurr++;
                                validCurr = Console.ReadLine();
                                currStop = validCurr.ToLower().ToString();

                                /*if (decimal.TryParse(validCurr, out valCurr))
                                {
                                    k = ;
                                }*/
                                
                            }

                            if ((currStop == "end") || (monCurr.Count == 0))
                            {
                                break;
                            }
                        }

                    }
                    /*else if ((monCurr[k] != Convert.ToDecimal(validCurr)))
                    {
                        Console.WriteLine("Please re-enter a valid currency type from $100-$.01..");

                        validCurr = Console.ReadLine();
                    }*/    
                }
            }
            decimal changeNeeded = userPay - totSale;

            decimal placeHolder = 0;

            for (int l = 0; l < dolType.Count; l++)
            {
                for (int f = 0; f < monCompare.Count; f++)
                    if (f < dolType.Count)
                    {

                        if (monCompare[l] < dolType[f])
                        {
                            placeHolder = dolType[f-1];
                            dolType[0] = dolType[f];
                            dolType[0 + f] = placeHolder;
                        }
                    }
                    else
                    {
                        break;
                    }
            }

            for (int i = 0; i < dolType.Count; i++)
            {
                changeNeeded = Change(changeNeeded, dolType[i], monType[i]);
            }

            Console.ReadLine();
        }

        public static decimal Change(decimal origAmt, decimal change, string type)
        {
            int modulo = Convert.ToInt32(Math.Floor((100 * origAmt) / (100 * change))); // convert the value to an integer and round down after dividing to get a whole number and decimal
            Console.WriteLine("You should recieve: " + modulo + " " + type);
            return origAmt % change;
        }
    }
}