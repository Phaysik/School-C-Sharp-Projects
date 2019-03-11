/*Programmer: Matthew Moore
   Description: String Reader
   Date: 10-29-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            try
            {
                StreamReader sr = new StreamReader("Sample.txt");

                line = sr.ReadLine();

                while(line != null)
                {
                    //Write the line to console windo
                    Console.WriteLine(line);
                    //Read the next record
                    line = sr.ReadLine();
                }
                //Close the file
                sr.Close();
            }

            catch(Exception e)
            {
                Console.WriteLine($"Exception {e.Message}.");
            }

            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            Console.ReadLine();
        }
    }
}
