using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Kaspichania_Boats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            char star = '*';
            char dot = '.';

            //Roof
            Console.Write(new string(dot, width / 2));
            Console.Write(star);
            Console.WriteLine(new string(dot, width / 2));
            //Top
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(dot, width / 2 - 1 - i));
                Console.Write(star);
                Console.Write(new string(dot, i));
                Console.Write(star);
                Console.Write(new string(dot, i));
                Console.Write(star);
                Console.WriteLine(new string(dot, width / 2 - 1 - i));
            }

            //Middle
            Console.WriteLine(new string(star, width));

            //Bottom
            int bottom = n / 2;
            for (int i = 0; i < bottom; i++)
            {
                Console.Write(new string(dot, i + 1));
                Console.Write(star);
                Console.Write(new string(dot, n - 2 - i));
                Console.Write(star);
                Console.Write(new string(dot, n - 2 - i));
                Console.Write(star);
                Console.WriteLine(new string(dot, i + 1));
            }
            //Unique bottom
            Console.Write(new string(dot, (width - n) / 2));
            Console.Write(new string(star, n));
            Console.Write(new string(dot, (width - n) / 2));
        }
    }
}
