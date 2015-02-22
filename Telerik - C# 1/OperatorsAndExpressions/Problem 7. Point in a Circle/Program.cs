using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter coordinate X: ");
            double coorX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter coordinate Y: ");
            double coorY = Convert.ToDouble(Console.ReadLine());
            int r = 2;
            bool checkK = (Math.Pow(coorX, 2) + Math.Pow(coorY, 2)) <= Math.Pow(r, 2);
            Console.WriteLine("The point (x,y) with coordinates (" + coorX + "," + coorY + ") is within circle K({0,0}, 2) --> " + checkK);
        }
    }
}
