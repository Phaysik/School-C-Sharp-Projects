/*Programmer: Matthew Moore
  Desciption: Validate input to be positive less than 100
  DatE: 9-18-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopValidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in postive values for any number of test scores: ");

            string uInput = "";

            List<int> val = new List<int>();

            while(true)
            {
                Console.WriteLine("To stop adding in values to average, please enter in '-1'");

                uInput = Console.ReadLine();

                if(uInput == "-1")
                {
                    break;
                }

                int value = Validate(uInput);

                val.Add(value);

            }

            DisplayInformation(val);

            Console.ReadLine();
        }

        public static int Validate(string uInput)
        {
            int val;

            while (true)
            {
                if (!(int.TryParse(uInput, out val)))
                {
                    Console.WriteLine("Your input was not a numeric value; please re-enter in a positive whole number less than 100: ");

                    uInput = Console.ReadLine();
                }
                else if (Convert.ToInt32(uInput) < 0 || Convert.ToInt32(uInput) > 100)
                {
                    Console.WriteLine("Your input was greater than 100 or less than 0\nPlease re-enter your value: ");

                    uInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            val = Convert.ToInt32(uInput);

            return val;
        }

        public static void DisplayInformation(List<int> val)
        {
            double value = 0;
            char grade = 'l';

            for(int i = 0; i < val.Count; i++)
            {
                value += val[i];
            }

            value = value / val.Count;

            if(value >= 90)
            {
                grade = 'A';
            }
            else if(value >= 80)
            {
                grade = 'B';
            }
            else if(value >= 70)
            {
                grade = 'C';
            }
            else if(value >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"The average of your tests is {value:n2}. Your grade from the averages is {grade}.");
        }
    }
}
