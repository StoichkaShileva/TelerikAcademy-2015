using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Gravitation_on_the_Moon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight:");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine((num * 17) / 100);
        }
    }
}
