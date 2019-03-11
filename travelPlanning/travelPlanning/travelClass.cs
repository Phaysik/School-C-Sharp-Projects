using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;

namespace travelPlanning
{
    class travelClass
    {

        public string getFileLine { get; set; }
        public int cities { get; set; }
        public double destination { get; set; }
        public double price { get; set; }
        public int planNumber{ get; set; }

        public bool ValidateLine(string fileLine)
        {
            if (Regex.IsMatch(fileLine, @"(^[0-9]+)\ (\d+(\.\d+)?)\ (\d+(\.\d+)?)") == false)
            {
                return false;
            }
            return true;
        }

        public double GetCostPerCityPerMile(){ return (price / destination) / cities; }

        public static bool operator >(travelClass tC1, travelClass tC2)
        {
            return tC1.GetCostPerCityPerMile() > tC2.GetCostPerCityPerMile();
        }
        public static bool operator <(travelClass tC1, travelClass tC2)
        {
            return tC1.GetCostPerCityPerMile() < tC2.GetCostPerCityPerMile();
        }

        public int Cities() { return Convert.ToInt32(getFileLine.Split(null)[0]); }
        public double Destination() { return Convert.ToDouble(getFileLine.Split(null)[1]); }
        public double Price() { return Convert.ToDouble(getFileLine.Split(null)[2]); }

        public override string ToString()
        {
            return $"The best plan from the given input lines is: Plan {planNumber}: {cities}";
        }
    }
}
