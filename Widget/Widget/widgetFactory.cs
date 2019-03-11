using System;

namespace Widget
{
    class widgetFactory
    {
        private double widgetsPerHour = 10;
        private double totalHours;
        private double totalDays;

        public widgetFactory(int widgetsOrdered)
        {
            totalHours = widgetsOrdered / widgetsPerHour;
            totalDays = totalHours / 16;
        }

        public double TotalDays()
        {
            return totalDays;
        }
    }
}
