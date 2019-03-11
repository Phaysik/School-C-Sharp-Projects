/*Programmer: Matthew Moore
   Description: File - Read and Write
   Date: 11-6-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ReadandWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValues();

            Console.WriteLine("The program has written all valid lines and the average\nof the scores to a new file.\n\nIt has also written all invalid lines to a different file.\n\nPress any key to close...");

            Console.ReadKey();
        }

        public static void GetValues()
        {
            StreamReader sr = new StreamReader("NamesandScores.txt");
            StreamWriter writerError = new StreamWriter("Error.txt");
            StreamWriter writeAverageAndName = new StreamWriter("AverageAndNames.txt");

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            List<string> namesAndScores = new List<string>();

            string line = "";
            
            bool isTrue = true;

            line = sr.ReadLine();

            while (line != null)
            {
                isTrue = true;

                if (Regex.IsMatch(line, @"(^[A-z ]+)\|(-?\d+)\|(-?\d+)\|(-?\d+)") == false)
                {
                    writerError.WriteLine($"{line} had the wrong syntax or is missing part of the data.");

                    isTrue = false;
                }
                else if (line.Contains("-"))
                {
                    writerError.WriteLine($"{line} had a negative or decimal score values.");

                    isTrue = false;
                }

                if(isTrue == true)
                {
                    string[] words = line.Split('|');

                    if(words.Length > 5)
                    {
                        namesAndScores = words.ToList();

                        namesAndScores.RemoveAt(namesAndScores.Count - 1);

                        words = namesAndScores.ToArray();

                        AverageandNames(words, writeAverageAndName, textInfo);
                    }
                    else
                    {
                        AverageandNames(words, writeAverageAndName, textInfo);
                    }
                }

                //Read the next record
                line = sr.ReadLine();
            }

            writerError.Close();
            writeAverageAndName.Close();
        }

        //Will print out the names and averages of all the valid lines read
        public static void AverageandNames(string[] words, StreamWriter writeAverageAndName, TextInfo textInfo)
        {
            for (int i = 0; i < words.Length; i += 3)
            {
                try
                {
                    double average = 0;

                    average = (Convert.ToInt32(words[i + 1]) + Convert.ToInt32(words[i + 2]) + Convert.ToInt32(words[i + 3])) / 3.0;

                    writeAverageAndName.WriteLine($"{textInfo.ToTitleCase(words[i])}'s average is {average:n2}");
                }

                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}
