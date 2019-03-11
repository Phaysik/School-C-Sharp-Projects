/*Programmer: Matthew Moore
  Description: Order Status
  Date: 8-29-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spools
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SPOOLS = 100;
            const int SHIPPING = 10;

            List<double> spools = new List<double>();
            List<double> spoolCost= new List<double>();

            spools = GetInputs();
            spoolCost = Calculations(SPOOLS, SHIPPING, spools);

            DisplayInformation(spools, spoolCost);

            Console.ReadLine();
        }

        public static List<double> GetInputs()
        {
            List<double> spoolInformation = new List<double>();

            Console.WriteLine("Please enter in your spools ordered: ");

            string uInput = Console.ReadLine();

            double spoolsOrdered = Validate(uInput);

            Console.WriteLine("Please enter in your amount of spools stocked: ");

            uInput = Console.ReadLine();

            double spoolsStocked = Validate(uInput);

            if(spoolsStocked < spoolsOrdered)
            {
                Console.WriteLine("Your spools stocked is less than the spools ordered.\nPlease fix your mistake.");

                GetInputs();
            }

            spoolInformation.Add(spoolsOrdered);
            spoolInformation.Add(spoolsStocked);

            return spoolInformation;

        }

        public static double Validate(string input)
        {
            double value;

            while (!(double.TryParse(input, out value)))
            {
                Console.WriteLine("Please re-enter your amount of spools: ");

                input = Console.ReadLine();
            }

            double uInput = Convert.ToDouble(input);

            while((uInput % 1) > 0)
            {
                Console.WriteLine("Please enter in a whole number: ");

                input = Console.ReadLine();

                Validate(input);
            }

            int spools = Convert.ToInt32(uInput);

            return spools;
        }

        public static List<double> Calculations(int SPOOLS, int SHIPPING, List<double> spools)
        {
            List<double> spoolInformation = new List<double>();

            int spoolCost = (int)spools[1] * SPOOLS;
            int shipping = SHIPPING * (int)spools[1];
            int total = spoolCost + shipping;

            spoolInformation.Add(spoolCost);
            spoolInformation.Add(shipping);
            spoolInformation.Add(total);

            return spoolInformation;
        }

        public static void DisplayInformation(List<double> spools, List<double> spoolCost)
        {
            Console.WriteLine("\n\tOrder Status\n");
            Console.WriteLine("Your stock of spools is: {0:n0}", spools[1]);
            Console.WriteLine("The number of spools being orderd is: {0:n0}", spools[0]);
            Console.WriteLine("The subtotal of your transaction is: {0:c2}", spoolCost[0]);
            Console.WriteLine("The subtotal plus shipping and handling is: {0:c2}", spoolCost[1]);
            Console.WriteLine("The total cost of your order is: {0:c2}", spoolCost[2]);
        }
    }
}
