/*Programmer: Matthew Moore
  Description: Help landowners determine property tax 
  Date: 9-5-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double assessValue = 0;

            const double MILEAGE = 10.03;
            const double EXEMPTION = 25000;
            const double VALUE = .027;

            DisplayStart();

            ConsoleClear();

            string streetAdd = NextInstructions(ref assessValue);

            ConsoleClear();

            List<double> propThings = QuickMath(MILEAGE, EXEMPTION, VALUE, assessValue);

            DisplayInformation(streetAdd, propThings);

            Console.ReadLine();
        }

        //Display Program Information
        public static void DisplayStart()
        {
            Console.WriteLine("This application determines taxes due for this calendar year." 
                + " You will be asked\nto enter the propery address and your assessed value for last year.\n");
            Console.WriteLine("Taxes are based on the following:");
            Console.WriteLine("Mileage Rate: $10.03 (per $1,000 of taxable value).");
            Console.WriteLine("$25,000.00 (exemption): subtracted from taxable values for homeowners.");
            Console.WriteLine("\n\t\tPress any key when you are ready to begin....");
        }

        //Will clear the console screen on user Input
        public static void ConsoleClear()
        {
            ConsoleKeyInfo uInput = Console.ReadKey();

            if (!Console.KeyAvailable)
            {
                Console.Clear();
            }
        }

        //Displays the next screen with instructions
        public static string NextInstructions(ref double assessValue)
        {
            Console.WriteLine("Please enter the property's Street Address: ");

            string uInput1 = Console.ReadLine();

            Console.WriteLine("Please enter the assessed value for last year: ");

            string strValue = Console.ReadLine();

            assessValue = CheckValidity(strValue); //Go to a function to check if it's a number

            Console.WriteLine("\n\tPress any key when you are ready to see your results....");

            return uInput1;
        }

        //Check if value is a number
        public static double CheckValidity(string val)
        {
            double value;

            while(!(double.TryParse(val, out value)))
            {
                Console.WriteLine("Please re-enter the assessed value for last year: ");

                val = Console.ReadLine();
            }

            double assessedVal = Convert.ToDouble(val);

            return assessedVal;
        }

        //Will do all the math calculations
        public static List<double> QuickMath(double mileage, double exemption, double value, double assessedVal)
        {
            List<double> propThings = new List<double>();

            propThings.Add(assessedVal);

            double currAssessedVal = (assessedVal * value) + assessedVal;

            propThings.Add(currAssessedVal);
            propThings.Add(exemption);

            double taxableValue = currAssessedVal - exemption;

            propThings.Add(taxableValue);
            propThings.Add(mileage);

            double taxesDue = (taxableValue / 1000) * mileage;

            propThings.Add(taxesDue);

            return propThings;
        }

        //Display All the Information Required
        public static void DisplayInformation(string address, List<double> propThings)
        {
            Console.WriteLine("\t\tProperty Assessment App\n");
            Console.WriteLine("Street Address: {0}", address);
            Console.WriteLine("\nLast Year Assessed Value:\t{0:c2}", propThings[0]);
            Console.WriteLine("\nCurrent Assessed Value:   \t{0:c2}",propThings[1]);
            Console.WriteLine("Exemption:\t\t\t{0:c2}", propThings[2]);
            Console.WriteLine("Taxable Value:\t\t\t{0:c2}", propThings[3]);
            Console.WriteLine("\nMileage Rate (per $1,000):\t    {0:c2}", propThings[4]);
            Console.WriteLine("\nTaxes Due:\t\t\t   {0:c2}", propThings[5]);
        }
    }
}
