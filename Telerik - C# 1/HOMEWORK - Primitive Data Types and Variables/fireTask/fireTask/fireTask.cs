using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireTask
{
    class fireTask
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == (width / 2 + count) && (width / 2 + count) < width)
                    {
                        Console.Write("#");

                    }
                    else if (j == (width / 2 + count) && (width / 2 + count) == width)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                count++;
                Console.WriteLine();
            }
        }
    }
}
