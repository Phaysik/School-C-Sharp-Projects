/*Programmer: Matthew Moore
   Description: Flash Drive Files
   Date: 11-13-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlashDriveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("flashfile.txt");

            int lines = 0;
            int filesToRead = 0;

            List<int> blockNum = new List<int>();
            List<string> charValues = new List<string>();
            List<int> lengthOfWords = new List<int>();
            List<int> startOfLine = new List<int>();

            string line;
            string spaceLines = "";

            line = reader.ReadLine();

            string[] words = line.Split(null);

            lines = Convert.ToInt32(words[0]);
            filesToRead = Convert.ToInt32(words[1]);

            line = reader.ReadLine();

            int counter = 0;
            
            while (line != null)
            {
                words = line.Split(null);

                if (counter < lines)
                {
                    blockNum.Add(Convert.ToInt32(words[0]));

                    if(words.Length > 2)
                    {
                        for (int i = 1; i < words.Length; i++)
                        {
                            spaceLines += words[i].ToString() + " ";
                        }

                        charValues.Add(spaceLines.Substring(0, spaceLines.Length - 1));

                        spaceLines = "";
                    }
                    else
                    {
                        charValues.Add(words[1]);
                    }

                    counter++;
                }
                else
                {
                    startOfLine.Add(Convert.ToInt32(words[0]));
                    lengthOfWords.Add(Convert.ToInt32(words[1]));
                }
                //Read the next record
                line = reader.ReadLine();
            }
            //Close the file
            reader.Close();

            int printLine = 0;

            List<string> valuesToPrint = new List<string>();

            for (int i = 0; i < startOfLine.Count; i++)
            {
                int j = startOfLine[i];

                line = charValues[j];

                while (blockNum[j] != -1)
                {
                    line += charValues[blockNum[j]];
                    j = blockNum[j];
                }

                valuesToPrint.Add(line);

                printLine++;

                if (printLine == filesToRead)
                {
                    break;
                }
            }

            Console.WriteLine("These lines are what the system reconstructed together from the given file:\n");

            for (int i = 0; i < printLine; i++)
            {
                Console.WriteLine(valuesToPrint[i].Substring(0, lengthOfWords[i]));
            }

            Console.WriteLine("\nPlease press any key to close...");
            Console.ReadKey();
        }
    }
}
