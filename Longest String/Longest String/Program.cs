/*Programmer: Matthew Moore
  Description: Longest and Shortest String
  Date: 10-10-18
*/
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            string uInput = "";

            while (true)
            {
                Console.WriteLine("To stop adding in values, please enter in 'stop'");

                uInput = Console.ReadLine();

                if (uInput.ToLower() == "stop")
                {
                    Console.Clear();

                    break;
                }

                array.Add(uInput);

            }

            string longest = "";
            string shortest = array[0].ToString();

            for (int i = 0; i < array.Count; i++)
            {
                string buffer = array[i].ToString();

                if(buffer.Length > longest.Length)
                {
                    longest = buffer;
                }

                if(buffer.Length <= shortest.Length)
                {
                    shortest = buffer;
                }
            }

            Console.WriteLine($"The longest string you entered was: {longest}.\nThe shortest string you entered was: {shortest}.");

            Console.ReadLine();
        }
    }
}
