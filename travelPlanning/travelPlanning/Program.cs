/*Programmer: Matthew Moore
   Description: Travel Planning
   Date: 11-16-18
*/
using System;
using System.Collections.Generic;
using System.IO;

namespace travelPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            travelClass bestPlan = new travelClass();

            using (StreamReader reader = new StreamReader("travel.txt"))
            {
                string line;
                int counter = 0, planCounter = 0;
                line = reader.ReadLine();
                string totalLinesToRead = line;
                List<travelClass> travelClassCollection = new List<travelClass>();

                StreamWriter writer = new StreamWriter("Error.txt");
                do
                {
                    travelClass travel = new travelClass();

                    int val;

                    if (int.TryParse(totalLinesToRead, out val) == false && counter == 0)
                    {
                        Console.WriteLine("Cannot read in any lines with the given first line of input.");
                        writer.WriteLine($"{totalLinesToRead} is not a whole integer number.");
                        break;
                    }

                    while (counter < Convert.ToInt32(totalLinesToRead))
                    {
                        line = reader.ReadLine();

                        travel = new travelClass();
                        travel.getFileLine = line;

                        if (travel.ValidateLine((travel.getFileLine)) == true)
                        {
                            travel.cities = travel.Cities();
                            travel.destination = travel.Destination();
                            travel.price = travel.Price();
                            travel.planNumber = ++planCounter;
                            travelClassCollection.Add(travel);
                        }
                        else
                        {
                            writer.WriteLine($"{travel.getFileLine}'s line is not entirely numbers.");
                        }

                        counter++;
                    }

                    line = reader.ReadLine();

                    if (counter == Convert.ToInt32(totalLinesToRead) && line != "0")
                    {
                        writer.WriteLine($"{line}. This line exceeds the given amount of lines to read.");
                    }
                    else
                    {

                    }

                } while (line != null);

                writer.Close();
                bestPlan = travelClassCollection[0];
                foreach (travelClass t in travelClassCollection)
                {
                    if (t < bestPlan) { bestPlan = t; }
                }
            }

            Console.WriteLine($"{bestPlan}");

            Console.WriteLine("\nPlease press any key to continue...");

            Console.ReadKey();
        }
    }
}
