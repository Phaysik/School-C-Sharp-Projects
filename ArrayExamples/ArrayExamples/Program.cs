/*Programmer: Matthew Moore
  Description: Array Examples
  Date: 9-26-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];

            Instructions();
            PrimeArray(entries);

            int cntInval = GetValues(entries);

            DResults(entries, cntInval);

            Console.ReadLine();
        }

        public static void Instructions()
        {
            Console.WriteLine("This application will allow you to enter any number of entries between 0 and 10.\nWhen you stop entering values, a message will display the values you entered\n\nalong with the number of times it was entered." +
                              "\n\nTo stop entering values type '-1'.\n\n\t\tPress any key when you are ready to begin....");

            ConsoleClear();
        }

        public static void DResults(int[] entries, int cntInVal)
        {
            Console.WriteLine("\t\tInput Data App\n\n");

            int cntVal = 0;
            for(int x = 0; x< 11; x++)
            {
                if(entries[x] != 0)
                {
                    cntVal += entries[x];

                    Console.WriteLine($"{x} was entered {entries[x]} times.");
                }
            }

            Console.WriteLine($"\nTotal number of inputs {cntVal + cntInVal}");

            Console.WriteLine($"\nNumber of invalid Entries: {cntInVal}");

            Console.WriteLine($"\nNumber of valid Entries: {cntVal}");
        }

        public static void PrimeArray(int[] entries)
        {
            for(int i = 0; i < entries.Length; i++)
            {
                entries[i] = 0;
            }
        }

        public static int GetValues(int[] entries)
        {
            int inVal;
            int cntInVal = 0;

            while(true)
            {
                Console.WriteLine("Input any number between 0 and 10 (-1 to stop): ");

                string uInput = Console.ReadLine();

                while(!(int.TryParse(uInput, out inVal)))
                {
                    Console.WriteLine("Invalid data type - value must be numeric between 0 and 10 (-1 to stop)");

                    cntInVal++;

                    uInput = Console.ReadLine();
                }

                if (inVal == -1)
                {
                    break;
                }

                else if((inVal < -1) || (inVal > 10))
                {
                    Console.WriteLine("Invalid data type - value must be numeric between 0 and 10 (-1 to stop)");
                }
                else
                {
                    entries[inVal]++;   //uses array as an accumulator - adds one at the input value's location
                }
            }

            Console.WriteLine("\n\n\t\tPlease press any key to continue....");

            ConsoleClear();

            return cntInVal;
            
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
