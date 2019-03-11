/*Programmer: Matthew Moore
   Description: Try Catch
   Date: 10-29-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Filepath and filename to the StreamWriter Constructor
                //StreamWriter sw = new StreamWriter("c:\\Test.txt");

                StreamWriter sw = new StreamWriter("Test.txt");

                sw.WriteLine("From the StreamWriter class.");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.    Record written successfully.");
            }

            Console.ReadLine();
        }
    }
}
