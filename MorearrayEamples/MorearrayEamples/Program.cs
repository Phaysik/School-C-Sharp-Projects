/*Programmer: Matthew Moore
  Description: More array examples
  Date: 10-1-18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorearrayEamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Search");

            double[] water = { 2.4, 3.6, 6.8 };

            double x = 6.8;
            int myInd = Array.BinarySearch(water, x);

            Console.WriteLine(myInd);

            //Clone
            double[] w2 = new double[water.Length - 1];

            object o = water.Clone();

            w2 = (double[])o;   // object o is cast as a double array   -   both array now point to same values

            water[0] = 2.2;

            Console.WriteLine(w2[0]);

            //Copy
            double[] w3 = new double[3];

            Array.Copy(water, 0, w3, 0, 3); //Copies 3 elements from water to w3    -   begins copy at index 0 in water -   beings placement at index 0 in w3

            foreach(double sm in w3)
            {
                Console.WriteLine(sm);
            }

            //Copyto copies from 1dimension to anotherm 1 dimension starting at the specified destination array index
            double[] w4 = new double[8];

            water.CopyTo(w4, 2);    //Copy starting at w4[2] so the array should go 0, 0, 2.2., 3.6, 6.8, 0, 0, 0

            Console.WriteLine("CopyTo");

            foreach(double cpyT in w4)
            {
                Console.WriteLine(cpyT);
            }

            //Get value
            Console.WriteLine("GetValue for index=2: " + water.GetValue(2));

            //Indexof
            int i = Array.IndexOf(water, 3.5);

            Console.WriteLine("Indexof 3.5 is: " + i);

            //Lastindexof
            int l = Array.LastIndexOf(water, 2.2);

            Console.WriteLine("LastIndexOf for 2.2: " + l);

            //Reverse
            Array.Reverse(water);

            Console.WriteLine("Reverse");

            foreach(double rv in water)
            {
                Console.WriteLine(rv);
            }

            //SetValue
            water.SetValue(4.9, 1);

            Console.WriteLine("SetValue");

            foreach(double sv in water)
            {
                Console.WriteLine(sv);
            }

            //Array sort
            Array.Sort(water);

            Console.WriteLine("Sort");

            foreach(double sr in water)
            {
                Console.WriteLine(sr);
            }

            //Clear array
            Console.WriteLine("Clear");

            Array.Clear(water, 0, water.Length);   //Begins at 0 index for the length of water

            foreach (double sd in water)
            {
                Console.WriteLine(sd);
            }

            Console.ReadLine();
        }
    }
}
