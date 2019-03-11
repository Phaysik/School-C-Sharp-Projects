/*Programmer: Matthew Moore
  Description: Info about school
  Date: 8-27-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string numberOfStudents;
            string schoolColors;
            string mascot;

            name = GetInfo("school name");
            numberOfStudents = GetInfo("amount of students currently enrolled");
            schoolColors = GetInfo("school's colors");
            mascot = GetInfo("school's mascot");

            string label = GetAsterisk();

            Console.WriteLine("\n" + label + "\nYour school name is: " + name + "\nThe amount of students enrolled is: " + numberOfStudents + "\nYour school colors are: " + schoolColors + "\nYour mascot is: " + mascot + "\n" + label);

            Console.ReadLine();
        }

        public static string GetInfo(string info)
        {
            Console.WriteLine("What is the {0}?", info);

            string inputValue = Console.ReadLine();

            return inputValue;
        }

        public static string GetAsterisk()
        {
            return "******************************************";
        }
    }
}
