/*Programmer: Matthew Moore
  Description: Jurassic Park Adventure
  Date: 9-20-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adventure = {"Jurassic Park", "Main Building", "Plaza", "Gift Shop", "Food Court", "Dinosaur Hallway", "T-Rex", "Raptors", "Pterodactyl"};

            Console.WriteLine("\t\t\tMatt's Tiny Adventure!");

            Console.WriteLine($"\nYou are at {adventure[0]} in the {adventure[1]}. Would you like to go the\n'Plaza', look at the 'Front Desk', look at the 'Directory', or look at the\n'Tickets Stand'?");

            string uInput = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
