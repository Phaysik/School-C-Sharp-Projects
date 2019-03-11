using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripClass
{
    class Trip
    {
        //Properties

        public string Destination { get; set; }
        
        public double DistanceTraveled { get; set; }

        public double TotalCostOfGasoline { get; set; }

        public int NumberOfGallonsConsumed { get; set; }

        public double milesPerGallon()
        {
            return (DistanceTraveled / NumberOfGallonsConsumed);
        }

        public double costPerMile()
        {
            return (DistanceTraveled / TotalCostOfGasoline);
        }

        public override string ToString()
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            return $"Your trip information:\nDestination: {textInfo.ToTitleCase(Destination)}.\nDistance Traveled: {DistanceTraveled} mile(s).\nTotal Cost of Gasoline: {TotalCostOfGasoline:c2}.\nNumber of Gallons Consumed: {NumberOfGallonsConsumed}.\n" +
                    $"Miles per Gallon: {milesPerGallon()}.\nCost per Mile: {costPerMile():c2}.";
        }
    }
}
