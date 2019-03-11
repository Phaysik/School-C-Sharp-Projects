/*Programmer: Matthew Moore
   Description: Pigeon Hole
   Date: 10-15-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pigeons = new List<int>();
            List<int> pigeonHoles = new List<int>();
            List<int> missingVals = new List<int>();

            bool isUnique = true;

            string uInput = "";

            int uVal = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please input a unique pigeon number between 1-100");

                uInput = Console.ReadLine();

                uVal = ValidatePigeonStuff(uInput);

                pigeons.Add(uVal);

                isUnique = pigeons.Distinct().Count() == pigeons.Count();   //Checks if the user input is distinct

                while (isUnique == false)
                {
                    pigeons.Remove(i);

                    Console.WriteLine("The value you just entered was already entered.\nPlease re-enter in another number: ");

                    uInput = Console.ReadLine();

                    uVal = ValidatePigeonStuff(uInput);

                    pigeons.Add(uVal);

                    isUnique = pigeons.Distinct().Count() == pigeons.Count();
                }

            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please input a unique pigeon hole number between 1-100");

                uInput = Console.ReadLine();

                uVal = ValidatePigeonStuff(uInput);

                pigeonHoles.Add(uVal);

                isUnique = pigeonHoles.Distinct().Count() == pigeonHoles.Count();

                while (isUnique == false)
                {
                    pigeonHoles.Remove(i);

                    Console.WriteLine("The value you just entered was already entered.\nPlease re-enter in another number: ");

                    uInput = Console.ReadLine();

                    uVal = ValidatePigeonStuff(uInput);

                    pigeonHoles.Add(uVal);

                    isUnique = pigeonHoles.Distinct().Count() == pigeonHoles.Count();
                }
            }

            bool isSubset = !pigeons.Except(pigeonHoles).Any(); //Checks to see if the pigeonHoles List contains all the values of the pigeons List

            if (isSubset == true)
            {
                Console.WriteLine("INPUT\t\t\t      OUTPUT\n");

                foreach (var item in pigeons)
                {
                    Console.Write($"{item,2} ");
                }

                Console.WriteLine();

                foreach (var val in pigeonHoles)
                {
                    Console.Write($"{val,2} ");
                }

                Console.Write("Fit");
            }
            else
            {
                for (int i = 0; i < pigeons.Count; i++)
                {
                    for (int x = 0; x < pigeonHoles.Count; x++)
                    {
                        if ((pigeons[i] != pigeonHoles[x]) && (x == pigeonHoles.Count - 1))
                        {
                            missingVals.Add(pigeons[i]);
                        }
                        else if (pigeons[i] == pigeonHoles[x])
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine("INPUT\t\t\t      OUTPUT\n");

                foreach (var item in pigeons)
                {
                    Console.Write($"{item,2} ");
                }

                Console.WriteLine();

                foreach (var val in pigeonHoles)
                {
                    Console.Write($"{val,2} ");
                }

                Console.Write("Not Fit: ");

                foreach (var item2 in missingVals)
                {
                    Console.Write($"{item2}");

                    if (item2 != missingVals[missingVals.Count - 1])
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(" is(are) missing.");

            }

            Console.ReadLine();
        }
        /// <summary>
        /// Validation of user inputes
        /// </summary>
        /// <param name="uInput"></param>
        /// <returns>Validated int value</returns>
        public static int ValidatePigeonStuff(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a numeric value;\nplease re-enter in a positive whole number: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 1 || Convert.ToInt32(uInput) > 100)
                {
                    Console.WriteLine("Your input was greater than 100 or less than 1.\nPlease re-enter your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return val;
        }
    }
}
