using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Age_after_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ten = 10;
            Console.Write("Enter your birthday year: ");
            int year = int.Parse(Console.ReadLine());
            if(year < 0 || year > 120)
            {
                Console.WriteLine("Age error! You have to write a realistic age!");
            }
            else
            {
                Console.WriteLine("After 10 years you'll be {0} years old! Wohooo, still young!", (year+ten));
            }
            
        }
    }
}
