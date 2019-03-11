/*Programmer: Matthew Moore
  Description: Test
  Date: 9-14-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string getName = NameInfo();

            List<int> callStart = CallStart();
            List<int> callTime  = CallTime();

            double cost = GetCost(callStart, callTime);

            List<string> zeroInFront = GetZeros(callStart, callTime);

            Console.WriteLine("Callers Name\tTime Call Started\tCall Length\tCost of Call");
            Console.WriteLine($"{getName}\t      {zeroInFront[0]}:{zeroInFront[1]}\t\t   {zeroInFront[2]}:{zeroInFront[3]}\t    {cost:c2}");

            Console.ReadLine();
        }

        public static string NameInfo()
        {
            Console.WriteLine("This program will calculate the cost of your call based on when it was made and how long it was.");
            Console.WriteLine("\n\t\tPlease press any key when you are ready to begin...");

            ConsoleClear();

            Console.WriteLine("Please enter in your name: ");
            
            string uInput = Console.ReadLine();

            return uInput;
        }

        public static List<int> CallStart()
        {
            Console.WriteLine("Please enter in the hour you started the call\n(Enter the time based on military time): ");

            string uInput = Console.ReadLine();

            int callStartH = ValidateStartH(uInput);

            Console.WriteLine("Please enter in the minute you started the call\n(Enter the time based on military time): ");

            uInput = Console.ReadLine();

            int callStartM = ValidateStartM(uInput);

            List<int> startTime = new List<int>();

            startTime.Add(callStartH);
            startTime.Add(callStartM);

            return startTime;
        }

        public static int ValidateStartH(string uInput)
        {
            int val;
            bool value = true;

            while(value == true)
                {
                    if (!(int.TryParse(uInput, out val)))
                    {
                        Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                        uInput = Console.ReadLine();
                    }
                    else if (Convert.ToInt32(uInput) < 0)
                    {
                        Console.WriteLine("Your input was less than 0, please re-enter in your call hours: ");

                        uInput = Console.ReadLine();
                    }
                    else if (Convert.ToInt32(uInput) > 23)
                    {
                        Console.WriteLine("Your input was greater than 23, please re-enter in your call hours: ");

                        uInput = Console.ReadLine();
                    }
                    else
                    {
                        value = false;
                    }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static int ValidateStartM(string uInput)
        {
            int val;
            bool value = true;

            while (value == true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0)
                {
                    Console.WriteLine("Your input was less than 0, please re-enter in your call minutes: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) > 60)
                {
                    Console.WriteLine("Your input was greater than 60, please re-enter in your call minutes: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    value = false;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static List<int> CallTime()
        {
            List<int> callTime = new List<int>();

            Console.WriteLine("Please enter in the length of the call in hours: ");

            string uInputH = Console.ReadLine();

            int callTimeH = ValidateTimeH(uInputH);

            Console.WriteLine("Please enter in the length of the call in minutes: ");

            string uInputM = Console.ReadLine();

            int callTimeM = ValidateTimeM(uInputM);

            callTime.Add(callTimeH);
            callTime.Add(callTimeM);

            return callTime;
        }

        public static int ValidateTimeH(string uInput)
        {
            int val;
            bool value = true;

            while (value == true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToDouble(uInput) < 0)
                {
                    Console.WriteLine("Your input was less than 0, please re-enter in your call time length in hours: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToDouble(uInput) >= 24)
                {
                    Console.WriteLine("Your input was greater than or equal to 24, please re-enter in your call time length in hours: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    value = false;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static int ValidateTimeM(string uInput)
        {
            int val;
            bool value = true;

            while (value == true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("You input was not a whole number, please enter in a whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToDouble(uInput) < 0)
                {
                    Console.WriteLine("Your input was less than 0, please re-enter in your call time length in minutes: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToDouble(uInput) >= 60)
                {
                    Console.WriteLine("Your input was greater than or equal to 60, please re-enter in your call time length in minutes: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    value = false;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static double GetCost(List<int> callStart, List<int> callTime)
        {
            double cost = 0;
            double cost1 = 0;

            double strCall = (60 * callStart[0]) + callStart[1];

            double totalCall = (60 * callTime[0]) + callTime[1];

            if (strCall <= 419)
            {
                if((strCall + totalCall) > 420)
                {
                    if((strCall + totalCall) <= 1140)
                    {
                        cost = .24 * (420 - strCall);
                        cost += .86 * (totalCall - (420 - strCall));
                    }
                    else if((strCall + totalCall) <= 1439)
                    {
                        cost = .24 * (420 - strCall);
                        cost += 619.2 + (.41 * (strCall + totalCall - 1140)); 
                    }
                    else
                    {
                        cost = .24 * (420 - strCall);
                        cost += 742.03 + (.24 * (strCall + totalCall - 1439));
                    }
                }
                else
                {
                    cost = .24 * totalCall;
                }   
            }
            else if (strCall <= 1140)
            {
                if ((strCall + totalCall) > 1141)
                {
                    if ((strCall + totalCall) <= 1440)
                    {
                        cost = .86 * (1141 - strCall);
                        cost += .41 * (totalCall - (1141 - strCall));
                    }
                    else if ((strCall + totalCall) <= 1860)
                    {
                        cost = .86 * (1141 - strCall);
                        cost += 122.59 + (.24 * (strCall + totalCall - 1440));
                    }
                    else
                    {
                        cost = .86 * (1141 - strCall);
                        cost += 223.39 + (.86 * (strCall + totalCall - 1860));
                    }
                }
                else
                {
                    cost = .86 * totalCall;
                }
            }
            else
            {
                if ((strCall + totalCall) > 1440)
                {
                    if ((strCall + totalCall) <= 1859)
                    {
                        cost = .41 * (1440 - strCall);
                        cost += .24 * (totalCall - (1440 - strCall));
                    }

                    else if ((strCall + totalCall) <= 2580)
                    {
                        cost = .41 * (1440 - strCall);
                        cost += 100.56 + (.86 * (strCall + totalCall - 1859));
                    }
                    else
                    {
                        cost = .41 * (1440 - strCall);
                        cost += 720.62 + (.41 * (strCall + totalCall - 2580));
                    }
                    
                }
                else
                {
                    cost = .41 * totalCall;
                }
            }

            Console.WriteLine("\n\t\tPlease press any key to see your information and cost...");

            ConsoleClear();

            return cost;
        }

        public static List<string> GetZeros(List<int> callStart, List<int> callTime)
        {
            List<string> zeros = new List<string>();
            
            string value1 = "";
            string value2 = "";
            string value3 = "";
            string value4 = "";

            if (callStart[0] < 10)
            {
                value1 = "0" + Convert.ToString(callStart[0]);
            }
            else
            {
                value1 = Convert.ToString(callStart[0]);
            }

            if (callStart[1] < 10)
            {
                value2 = "0" + Convert.ToString(callStart[1]);
            }
            else
            {
                value2 = Convert.ToString(callStart[1]);
            }

            if (callTime[0] < 10)
            {
                value3 = "0" + Convert.ToString(callTime[0]);
            }
            else
            {
                value3 = Convert.ToString(callTime[0]);
            }

            if (callTime[1] < 10)
            {
                value4 = "0" + Convert.ToString(callTime[1]);
            }
            else
            {
                value4 = Convert.ToString(callTime[1]);
            }

            zeros.Add(value1);
            zeros.Add(value2);
            zeros.Add(value3);
            zeros.Add(value4);

            return zeros;
        }

        public static void ConsoleClear()
        {
            ConsoleKeyInfo uInput = Console.ReadKey();

            if (!Console.KeyAvailable)
            {
                Console.Clear();
            }
        }
    }
}
