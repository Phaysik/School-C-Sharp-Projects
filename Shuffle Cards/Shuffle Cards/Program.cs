/*Programmer: Matthew Moore
  Description: Deck of Cards
  Date: 9-26-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display an unshuffled deck of cards, and a randomly shuffled deck of cards.\n\n\t\tPlease press any key to continue....");

            ConsoleClear();

            List<string> unshuffled = Unshuffled();

            List<string> shuffled = Shuffled(unshuffled);

            for(int i = 0; i < shuffled.Count; i++)
            {
                Console.WriteLine($"{unshuffled[i]}\t|\t{shuffled[i]}");
            }
            
            Console.ReadLine();
        }
        /// <summary>
        /// Will create a list and assign all 52 cards to the list
        /// </summary>
        /// <returns>List of unshuffled deck</returns>
        public static List<string> Unshuffled()
        {
            List<string> unshuffled = new List<string>();

            foreach (char unshuffle in new char[] { 'H', 'C', 'D', 'S' })
            {
                for (int i = 1; i < 14; i++)
                {
                    switch (i)
                    {
                        case 1:
                            unshuffled.Add("A" + unshuffle);
                            break;
                        case 11:
                            unshuffled.Add("J" + unshuffle);
                            break;
                        case 12:
                            unshuffled.Add("Q" + unshuffle);
                            break;
                        case 13:
                            unshuffled.Add("K" + unshuffle);
                            break;
                        default:
                            unshuffled.Add(i.ToString() + unshuffle);
                            break;
                    }
                }
            }

            return unshuffled;
        }
        /// <summary>
        /// Will randomize the deck and return a shuffled deck of cards
        /// </summary>
        /// <param name="unshuffled"></param>
        /// <returns>List of shuffled cards</returns>
        public static List<string> Shuffled(List<string> unshuffled)
        {
            List<string> shuffled = new List<string>();
            List<string> newunshuffled = new List<string>();

            for(int z = 0; z < unshuffled.Count; z++)
            {
                newunshuffled.Add(unshuffled[z]);
            }

            Random randomNum = new Random();

            int val = 0;

            for(int i = 0; i < 52; i++)
            {
                val = randomNum.Next(0, (newunshuffled.Count));

                shuffled.Add(newunshuffled[val]);

                newunshuffled.RemoveAt(val);
            }

            return shuffled;
        }

        public static void ConsoleClear()
        {
            ConsoleKeyInfo uInput = Console.ReadKey();

            if (!Console.KeyAvailable)
            {
                Console.Clear();
            }
        }
    }
}
