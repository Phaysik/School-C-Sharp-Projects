/*Programmer: Matthew Moore
 * Description: To calculate the area of certain objects
 * Date: 9-10-18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string uInput = DisplayandGetInfo();

            double calculation = Calculate(uInput);

            Console.WriteLine("The area of your {0:n2} is {1:n2}.", uInput, calculation);

            Console.ReadLine();
        }

        public static string DisplayandGetInfo()
        {
            Console.WriteLine("Please enter in whether you would like to calculate the area of a circle,\nrectangle, or cylinder, by entering 'Circle', 'Rectangle', or 'Cylinder'.");

            string uInput = Console.ReadLine();

            uInput = Validate(uInput);

            return uInput;
        }

        public static string Validate(string uInput)
        {
            while((uInput.ToLower() != "circle") && (uInput.ToLower() != "rectangle") && (uInput.ToLower() != "cylinder"))
            {
                Console.WriteLine("You input did not match 'Circle', 'Rectangle', or 'Cylinder'.\nPlease re-enter in what you would like to calculate the area of: ");

                uInput = Console.ReadLine();
            }
            return uInput;
        }

        public static double Calculate(string uInput)
        {
            string val = "";
            double value = 0;
            double value2 = 0;
            if(uInput.ToLower() == "circle")
            {
                Console.WriteLine("Please enter in what the radius of your circle is: ");

                val = Console.ReadLine();

                value = ValidateValue(val);

                value = (Math.PI * (value * value));
            }

            else if(uInput.ToLower() == "rectangle")
            {
                Console.WriteLine("Please enter in the length of your rectangle: ");

                val = Console.ReadLine();

                value = ValidateValue(val);

                Console.WriteLine("Please enter in the width of your rectangle: ");

                val = Console.ReadLine();

                value2 = ValidateValue(val);

                value = (value * value2);
            }
            else
            {
                Console.WriteLine("Please enter in the radius of your cylinder: ");

                val = Console.ReadLine();

                value = ValidateValue(val);

                Console.WriteLine("Please enter in the height of your cylinder: ");

                val = Console.ReadLine();

                value2 = ValidateValue(val);

                value = ((2 * Math.PI * value * value2) + (2 * Math.PI * (value * value)));
            }

            return value;
        }

        public static double ValidateValue(string uInput)
        {
            double val;

            while(!(double.TryParse(uInput, out val)))
            {
                Console.WriteLine("Please enter in a numeric value: ");

                uInput = Console.ReadLine();

                if(Convert.ToDouble(uInput) < 0)
                {
                    Console.WriteLine("Please enter in a value that is greater than 0: ");

                    uInput = Console.ReadLine();
                }
            }

            val = Convert.ToDouble(uInput);

            return val;
        }
    }
}
