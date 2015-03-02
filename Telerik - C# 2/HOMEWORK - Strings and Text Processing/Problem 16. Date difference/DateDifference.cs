using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Date_difference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date in format day.month.year (21.04.2012): ");
            DateTime first = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", null);
            Console.WriteLine("Enter second date in format day.month.year (17.11.2018): ");
            DateTime second = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", null);
            TimeSpan a = first - second;
            Console.WriteLine("Days between first and second date are: {0}", (first-second).TotalDays);
            
        }
    }
}
