/*Programmer: Matthew Moore
  Description: Longest Sequence
  Date: 9-28-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomVals = Rrandom();

            string output = "";
            string output1 = "";

            List<int> consecSequence = longestConsecutive(randomVals);
            List<int> longestSequence = Sequence(randomVals);

            Console.WriteLine("The longest consecutive sequence of numbers was: ");

            for(int l = 0; l < consecSequence.Count(); l++)
            {
                output += $"{consecSequence[l]},";
            }

            if(output.Length > 0)
            {
                output = output.Substring(0, (output.Length - 1));
            }
            else
            {
                output = "No consecutive values.";
            }
            

            Console.Write(output);

            Console.WriteLine("\n\nThe longest sequence of numbers increasing in value is: ");

            for(int k = 0; k < longestSequence.Count(); k++)
            {
                output1 += $"{longestSequence[k]},";
            }

            output1 = output1.Substring(0, (output1.Length - 1));

            Console.Write(output1);

            Console.ReadLine();
        }
        /// <summary>
        /// Will get the longest consecutive length of values and assign them to a list and return them
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>List of values that are incremented by one</returns>
        public static List<int> longestConsecutive(List<int> nums)
        {
            List<int> buffer = new List<int>();
            List<int> largest = new List<int>();
            List<int> nonDupeSequence = new List<int>();

            int nextVal = 0;
            int current = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                current = nums[i];
                nextVal = i == nums.Count() - 1 ? current : nums[i + 1];

                if (nextVal >= current)
                {
                    if(i < nums.Count() - 1)
                    {
                        if (nums[i] + 1 == nums[i + 1])
                        {
                            buffer.Add(nums[i]);
                            buffer.Add(nums[i + 1]);
                        }

                        if (buffer.Count() >= largest.Count())
                        {
                            for (int l = 0; l < largest.Count(); l++)
                            {
                                largest.RemoveAt(l);
                                l = -1;
                            }

                            for (int z = 0; z < buffer.Count(); z++)
                            {
                                largest.Add(buffer[z]);
                            }
                        }
                    }
                }

                else
                {
                    buffer.Clear();
                }

                largest = Duplicate(largest);
            }
            return largest;
        }
        /// <summary>
        /// Will remove duplicate entries
        /// </summary>
        /// <param name="largest"></param>
        /// <returns>Returns a list without duplicates</returns>
        public static List<int> Duplicate(List<int> largest)
        {
            List<int> nonDupeSequence = new List<int>();

            for (int i = 0; i < largest.Count; i++)
            {
                if (!nonDupeSequence.Contains(largest[i]))
                {
                    nonDupeSequence.Add(largest[i]);
                }
            }

            return nonDupeSequence;
        }
        /// <summary>
        /// Gets a random value between 0 and 10000
        /// </summary>
        /// <returns>A random list of 10000 random values</returns>
        public static List<int> Rrandom()
        {
            Random randomval = new Random();

            int val = 0;

            List<int> vals = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                val = randomval.Next(0, 10001);

                vals.Add(val);
            }

            return vals;
        }
        /// <summary>
        /// Will get the longest sequence of positively increasing values and assign it to a list
        /// </summary>
        /// <param name="randomVals"></param>
        /// <returns>List of longest sequence of positively increasing values</returns>
        public static List<int> Sequence(List<int> randomVals)
        {
            List<int> sequence = new List<int>();
            List<int> newBuffSequence = new List<int>();

            int current = 0;
            int nextVal = 0;

            for (int i = 0; i < randomVals.Count; i++)
            {
                current = randomVals[i];
                nextVal = i == randomVals.Count - 1 ? current : randomVals[i + 1];

                if (nextVal > current)
                {
                    newBuffSequence.Add(current);

                    if (newBuffSequence.Count() > sequence.Count())
                    {
                        for (int l = 0; l < sequence.Count(); l++)
                        {
                            sequence.RemoveAt(l);
                            l = -1;
                        }

                        for (int z = 0; z < newBuffSequence.Count(); z++)
                        {
                            sequence.Add(newBuffSequence[z]);
                        }
                    }
                }

                else
                {
                    newBuffSequence.Clear();
                }
            }

            return sequence;
            }
        }
    }

