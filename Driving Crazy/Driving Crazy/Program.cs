/*Programmer: Matthew Moore
  Description: Driving Crazy
  Date: 10-10-18
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Driving_Crazy
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList days = new ArrayList();
            ArrayList hours = new ArrayList();
            ArrayList minutes = new ArrayList();
            ArrayList times = new ArrayList();

            string uInput = "";

            int day = 0;

            string hour = "";
            string minute = "";

            while (true)
            {
                Console.WriteLine("Please enter in a day, 1-7 (1 = Sunday), you need mom to drive you somewhere.\nTo stop entering in times, please enter in 'stop': ");

                uInput = Console.ReadLine();

                if (uInput == "stop")
                {
                    Console.Clear();

                    break;
                }

                day = ValidateDay(uInput);

                days.Add(day);

                Console.WriteLine("Please enter in an hour, 1-23, that represents your hour needed.\nYou must enter double digits for all inputs, including those below 10. '01' for example: ");

                uInput = Console.ReadLine();

                hour = ValidateHour(uInput);

                hours.Add(hour);

                Console.WriteLine("Please enter your minute(s), 00-59. You must enter double digits for all inputs, including those below 10.\n'00' for example: ");

                uInput = Console.ReadLine();

                minute = ValidateMinutes(uInput);

                minutes.Add(minute);
            }

            CalculateAndDisplay(days, hours, minutes, times);

            Console.ReadLine();

        }
        /// <summary>
        /// Will add all the times to an ArrayList, then sort the array list by the first value, which happens to be the day. It will then change the first value to be the appropriate day, and print it out in a nice way
        /// </summary>
        /// <param name="days"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="times"></param>
        public static void CalculateAndDisplay(ArrayList days, ArrayList hours, ArrayList minutes, ArrayList times)
        {
            ArrayList allTimes = new ArrayList();

            var list = new List<DateTime>();

            string output = "";

            for (int i = 0; i < days.Count; i++)
            {
                allTimes.Add($"{days[i]}{hours[i]}{minutes[i]}");
            }

            for (int f = 0; f < allTimes.Count; f++)
            {
                output = allTimes[f].ToString();

                DateTime dateVal = new DateTime(2018, Convert.ToInt32(output.Substring(0, 1)), 22, Convert.ToInt32(output.Substring(1, 2)), Convert.ToInt32(output.Substring(3, 2)), 0);

                list.Add(dateVal);
            }

            string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            List<String> displayValues = new List<String>();

            SortAscending(list);

            for (int i = 0; i < list.Count; i++)
            {
                output = list[i].ToString();
                
                for (int x = 0; x < 7; x++)
                {
                    if(output.Length == 20)
                    {
                        if (Convert.ToInt32(output.Substring(0, 1)) == (x + 1))
                        {
                            output = weekDays[x].ToString() + " " + output.Substring(10, 1) + ":" + output.Substring(12, 2) + " " + output.Substring(18, 2);

                            displayValues.Add(output);

                            break;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(output.Substring(0, 1)) == (x + 1))
                        {
                            output = weekDays[x].ToString() + " " + output.Substring(10, 2) + ":" + output.Substring(13, 2) + " " + output.Substring(19, 2);

                            displayValues.Add(output);

                            break;
                        }
                    }
                } 
            }

            Display(displayValues);
        }
        /// <summary>
        /// Will get a list of DateTimes and sort them
        /// </summary>
        /// <param name="list"></param>
        /// <returns>DateTime List of sorted values</returns>
        static List<DateTime> SortAscending(List<DateTime> list)
        {
            list.Sort((a, b) => a.CompareTo(b));

            return list;
        }

        static void Display(List<String> list)
        {
            foreach (var datetime in list)
            {
                Console.WriteLine(datetime);
                Console.Write("\n");
            }
        }

        /* Validation of all inputs below */
        public static int ValidateDay(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a positive whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 1 || Convert.ToInt32(uInput) > 7)
                {
                    Console.WriteLine("Your input was greater than 7 or less than 1.\nPlease re-enter your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }

        public static string ValidateHour(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a positive whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (uInput.Length < 2)
                {
                    Console.WriteLine("Your input was not two digits;\nplease re-enter in two positive numbers: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 1 || Convert.ToInt32(uInput) > 23)
                {
                    Console.WriteLine("Your input was greater than 23 or less than 1.\nPlease re-enter your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return uInput;
        }

        public static string ValidateMinutes(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a positive whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (uInput.Length < 2)
                {
                    Console.WriteLine("Your input was not two digits;\nplease re-enter in two positive numbers: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0 || Convert.ToInt32(uInput) > 59)
                {
                    Console.WriteLine("Your input was greater than 59 or less than 0.\nPlease re-enter your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return uInput;
        }
    }
}
