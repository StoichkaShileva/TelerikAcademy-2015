/*Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.Date_in_Bulgarian
{
    class DateInBG
    {
        static void Main(string[] args)
        {
            CultureInfo.CreateSpecificCulture("bg-BG");
            Console.WriteLine("FORMAT: day.month.year hour:minute:second (EXAMPLE: 28.02.15 02:11:21): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yy h:mm:ss", null);
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            Console.WriteLine(date);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
