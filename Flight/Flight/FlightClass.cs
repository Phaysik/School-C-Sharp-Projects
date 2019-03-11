namespace Flight
{
    class FlightClass
    {
        private int flightNumber;
        private string destination;
        private float distance;
        private float fuel;

        //Properties

        public int FlightNumber { get { return flightNumber; } set { flightNumber = value; } }
        public string Destination { get { return destination; } set { destination = value; } }
        public float Distance { get { return distance; } set { distance = value; } }
        public float Fuel { get { return fuel; } set { fuel = value; } }

        //Methods

        public static float GetFuel(float distance)
        {
            float fuel = 0;

            if(distance <= 1000)
            {
                fuel = 500;
            }
            else if(distance <= 2000)
            {
                fuel = 1100;
            }
            else
            {
                fuel = 2200;
            }

            return fuel;
        }
    }
}
