using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleWebsiteTests
{
    public class DataGenerator
    {
        static DateTime desiredDate;

        public static String getDate_NextMonday()
        {
            DateTime today = DateTime.Today;
            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                desiredDate = today.AddDays(7.0);
            }
            else if (today.DayOfWeek == DayOfWeek.Tuesday)
            {
                desiredDate = today.AddDays(6.0);
            }
            else if (today.DayOfWeek == DayOfWeek.Wednesday)
            {
                desiredDate = today.AddDays(5.0);
            }
            else if (today.DayOfWeek == DayOfWeek.Thursday)
            {
                desiredDate = today.AddDays(4.0);
            }
            else if (today.DayOfWeek == DayOfWeek.Friday)
            {
                desiredDate = today.AddDays(3.0);
            }
            else if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                desiredDate = today.AddDays(2.0);
            }
            if (today.DayOfWeek == DayOfWeek.Sunday)
            {
                desiredDate = today.AddDays(1.0);
            }
            return desiredDate.Date.ToString();
        }
    }
}
