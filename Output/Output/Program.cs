/*Programmer: Matthew Moore
   Description: Files - Output
   Date: 11-6-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomVal = new Random();

            StreamWriter writer = new StreamWriter("Randomvals.txt");

            bool isTrue = true;

            for (int x = 0; x < 10; x++)
            {
                int i = 0;
                string line = "";

                try
                {
                    while (i < 5)
                    {
                        line += ($"{randomVal.Next(1, 1001)}|");
                        i++;
                    }

                    i = 0;

                    writer.WriteLine(line.Substring(0, line.Length - 1));
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error: " + e.Message);

                    isTrue = false;

                    break;
                }
                
            }

            writer.Close();

            if(isTrue == true)
            {
                Console.WriteLine("The program has successfully written 50 random numbers to a file.\n\nPress any key to close...");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The program did not successfully write 50 random numbers to a file.\n\nPress any key to close...");

                Console.ReadKey();
            }
            
        }
    }
}
