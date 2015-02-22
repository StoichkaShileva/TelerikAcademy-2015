using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bat_Goiko_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            char empty = '.';
            char leftLine = '/';
            char rightLine = '\\';
            char crossbeam = '-';
            bool theNextTimeShouldBeCrossbeam = false;
            for (int i = 0, second = 2, lineRow = 0; i < height * 2; i++)
            {
                if (height - i * 1 > 0)
                {
                    Console.Write(new string(empty, height - i * 1 - 1));
                    Console.Write(new string(leftLine, 1));
                    if (theNextTimeShouldBeCrossbeam)
                    {
                        Console.Write(new string(crossbeam, i * 2));
                        theNextTimeShouldBeCrossbeam = false;
                    }
                    else
                    {
                        Console.Write(new string(empty, i * 2));
                    }
                    Console.Write(new string(rightLine, 1));
                    Console.WriteLine(new string(empty, height - i * 1 - 1));
                }
                if (lineRow == i)
                {
                    theNextTimeShouldBeCrossbeam = true;
                    lineRow += second;
                    second++;
                }
            }

        }
    }
}
