using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            int perimeter = (width + height) * 2;
            int area = width * height;

            Console.WriteLine("The perimeter is: {0} and the area is {1}", perimeter, area);
        }
    }
}
