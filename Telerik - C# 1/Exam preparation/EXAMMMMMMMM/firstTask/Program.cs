using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal biggestNum = 0;
            decimal smallestNum = 0;
            if(a >= b && a >= c)
            {
                biggestNum = a;
            }
            else if(b >= a && b >= c)
            {
                biggestNum = b;
            }
            else if(c >= a && c >= b)
            {
                biggestNum = c;
            }

            if(a <= b && a <= c)
            {
                smallestNum = a;
            }
            else if(b <= c && b <= a)
            {
                smallestNum = b;
            }
            else if(c <= a && c <= b)
            {
                smallestNum = c;
            }

            decimal arithmetic = (a + b + c) / 3;
            Console.WriteLine(biggestNum);
            Console.WriteLine(smallestNum);
            Console.WriteLine("{0:f3}", arithmetic);

        }
    }
}
