/* Programmer: Matthew Moore
    Description: This program displays a message to the user
    Date: 8-14-18
    */
//This is a block comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csconsolefirst
{
    class Program
    {
        static void Main(string[] args) //program starts with Main module
        {
            Console.WriteLine("Today is Tuesday, the second day of class.\nThis is the next line.");    //write text to console
            //  \n advances to the next line - carriage return
            //  \t horizontal tab
            //  \' prints the quote mark
            //  \" prints the double quote mark
            //  \\ prints the \ mark
            //  \r cursor advances to the beginning of the current line
            //  \a alert sound

            int t = Console.Read(); //Reads only one character      returns a char
            string i = Console.ReadLine();  //ReadLine reads an entire line         returns a string
                                            // string k = Console.ReadKey();   //Reads only one single character from the standard input stream.   IE - when giving user input options ilke a, b, or c - returns an interger
            Console.WriteLine(i);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());     //reads input in as a string but the Convert changes it into an interger and then puts it into the varable num1
            Console.WriteLine(num1 * 2);
            Console.WriteLine("The number entered is {0}", num1);
            Console.WriteLine("{0} + {1} = {2}", num1, num1, num1 + num1);
        

            Console.ReadLine(); //last statement to show what is happening on console
        }
    }
}
