using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class carpet
    {
        //Data members, data fields or characteristics of the student

        private int noOfSqYards;
        private double pricePerSqYard;

        public carpet()
        {

        }

        //Constructor

        public carpet(double priceOfYrds)
        {
            pricePerSqYard = priceOfYrds;
        }

        //Properties

        public int totSqYards
        {
            get { return noOfSqYards; }
            set { noOfSqYards = value; }
        }

        public double Price
        {
            get { return (noOfSqYards * pricePerSqYard); }
        }

        public override string ToString()
        {
            return $"The number of square yards is {noOfSqYards} yards.\nThe price per square yards is ${pricePerSqYard}.\nThe total cost of your carpet is ${Price}.";
        }
    }
}
