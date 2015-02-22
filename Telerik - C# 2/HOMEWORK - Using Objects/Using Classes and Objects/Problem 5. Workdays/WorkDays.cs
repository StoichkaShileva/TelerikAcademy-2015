/*
 Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.             
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Workdays
{
    class WorkDays
    {
        static int ReturnWorkdays(DateTime date)
        {
            int calcBusinessDays =
            (int)
            (1 + ((date - DateTime.Now).TotalDays * 5 -
            (date.DayOfWeek - DateTime.Now.DayOfWeek) * 2) / 7);
            return calcBusinessDays;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date as format -> M/D/YY (example: 4/28/2013): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            int workdays = ReturnWorkdays(date);
            Console.WriteLine("From today to {0} have {1} workdays, loool too many workdays!", date, workdays);
        }
    }
}
