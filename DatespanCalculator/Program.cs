using System;
///-----------------------------------------------------------------
///   Namespace:    DatespanCalculator
///   Description:  Input 2 dates to find length of time between
///                 WARNING: CURRENT VERSION IS INACCURATE FOR LONG
///                          TIMESPANS (ADDS DAYS)
///   Author:       Derek Wolters                
///   Date:         3.8.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

namespace DatespanCalculator
{
    class Program
    {
        static void Main()
        {

            //initalize variables 
            double diff = 0;
            double diffMonth = 0;
            double diffDay = 0;
            double diffYear = 0;

            //get user input
            Console.WriteLine("Enter a start date (MM/DD/YYYY):");
            String startIn = Console.ReadLine();

            Console.WriteLine("Enter an end date (MM/DD/YYYY):");
            String endIn = Console.ReadLine();

            //convert to numeric date
            DateTime startDate = Convert.ToDateTime(startIn);
            DateTime endDate = Convert.ToDateTime(endIn);

            //calculate interval
            System.TimeSpan span = endDate.Subtract(startDate);

            //stay positive!
            diff = Math.Abs(span.TotalDays);

            //divide into appropriate time measurements
            diffYear = Math.Floor(diff / 365.2425);
            diffMonth = Math.Floor((diff % 365.2425) / 30.4369);
            diffDay = Math.Floor(((diff % 30.4369) / 30.4369) * 30.4369);

            //display result
            Console.WriteLine("The difference is {0} years, {1} months, " +
                "{2} days.", diffYear, diffMonth, diffDay);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
