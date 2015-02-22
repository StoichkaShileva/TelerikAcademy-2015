/*Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Leap_year
{
    class LeapYear
    {
        static bool CheckIfYearIsleap(int year)
        {
            bool isLeapYear = false;
            if (DateTime.IsLeapYear(year) == true)
            {
                isLeapYear = true;
            }
            return isLeapYear;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = CheckIfYearIsleap(year);
            Console.WriteLine(isLeap);
        }
    }
}
