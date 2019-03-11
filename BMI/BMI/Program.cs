/*Programmer: Matthew Moore
  Decsription: Calculate BMI
  Date: 9-10-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = GetWeight();
            double height = GetHeight();

            const int VALUE = 703;

            string BMI = Calculate(weight, height, VALUE);

            DisplayInformation(BMI);

            Console.ReadLine();
        }

        public static double GetWeight()
        {
            double weight = 0;

            Console.WriteLine("Please enter in your weight in lbs: ");

            string uInput = Console.ReadLine();

            weight = Validate1(uInput);

            return weight;
        }

        public static double Validate1(string uInput)
        {
            double val;

            while (!(double.TryParse(uInput, out val)))
            {
                Console.WriteLine("Please re-enter in your weight in lbs: ");

                uInput = Console.ReadLine();

                if (Convert.ToDouble(uInput) <= 0)
                {
                    Console.WriteLine("Please enter in a value that is greater than 0.");

                    uInput = Console.ReadLine();
                }
            }

            double value = Convert.ToDouble(uInput);

            return value;
        }

        public static double GetHeight()
        {
            double height = 0;

            Console.WriteLine("Please enter in your height in inches: ");

            string uInput = Console.ReadLine();

            height = Validate2(uInput);

            return height;
        }

        public static double Validate2(string uInput)
        {
            double val;

            while (!(double.TryParse(uInput, out val)))
            {
                Console.WriteLine("Please re-enter in your height in lbs: ");

                uInput = Console.ReadLine();

                if (Convert.ToDouble(uInput) <= 0)
                {
                    Console.WriteLine("Please enter in a value that is greater than 0.");

                    uInput = Console.ReadLine();
                }
            }

            double value = Convert.ToDouble(uInput);

            return value;
        }

        public static string Calculate(double weight, double height, int BMI)
        {
            string bmi = "";

            double BMICalc = ((weight) / ((height * height)) * BMI);

            if(BMICalc < 18.5)
            {
                bmi = "Underweight";
            }
            else if(BMICalc <= 24.9){
                bmi = "Normal";
            }
            else if(BMICalc <= 29.9)
            {
                bmi = "Overweight";
            }
            else
            {
                bmi = "Obese";
            }

            return bmi;
        }

        public static void DisplayInformation(string BMI)
        {
            Console.WriteLine("You are: " + BMI + ".");
        }
    }
}
