using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Classes
{
    // Used as a datasource for the chart for entries.
    public class ChartPoint
    {
        public DateTime date; // Will be used to get the day of this chart point
        public double total_hours; // Total hours worked on specific day
        public Dictionary<string, double> total_earnings;// Total earnings by currency1. Will be calculated and summed up for each entry itself because of the differences in currencies and hourly rates.

        public ChartPoint()
        {
            this.total_hours = 0;
            total_earnings = new Dictionary<string, double>();
        }
    }
}
