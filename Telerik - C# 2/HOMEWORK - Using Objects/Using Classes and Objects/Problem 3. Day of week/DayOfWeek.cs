/*Write a program that prints to the console which day of the week is today.
Use System.DateTime.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Day_of_week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            Console.WriteLine(a.DayOfWeek);
        }
    }
}
