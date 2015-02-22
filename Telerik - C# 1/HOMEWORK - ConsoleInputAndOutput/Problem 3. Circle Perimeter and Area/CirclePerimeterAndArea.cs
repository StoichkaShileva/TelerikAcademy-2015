//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Circle_Perimeter_and_Area
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double rSquare = Math.Pow(r, 2);
            double perimeter = 2 * pi * r;
            double area = rSquare * pi;
            Console.WriteLine("Perimeter -> {0:f2}", perimeter);
            Console.WriteLine("Area -> {0:f2}", area);
        }
    }
}
