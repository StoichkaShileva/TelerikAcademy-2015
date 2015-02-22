using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextDateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime b = new DateTime(year, month, day);
            DateTime a = b.AddDays(1);
            int sDay = a.Day;
            int sMonth = a.Month;
            int sYear = a.Year;
            Console.WriteLine("{0}.{1}.{2}", sDay, sMonth, sYear);
        }
    }
}
