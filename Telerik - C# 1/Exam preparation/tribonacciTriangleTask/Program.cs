using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tribonacciTriangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long sum = 0;
            long d = long.Parse(Console.ReadLine());
            int iterator = -1;
            for (int i = 0; i < d; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(a);
                }
                else if(i == 1)
                {
                    Console.WriteLine("{0} {1}", b, c);
                }
                else
                {
                    for (int j = iterator; j < d; j++)
                    {
                        sum += a + b + c;
                        if(j == 0)
                        {
                            a = sum;
                            iterator++;
                        }
                        else if(j == 1)
                        {
                            b = sum;
                        }
                        else if(j == 2)
                        {
                            c = sum;
                        }
                        Console.Write("{0} ", sum);
                        sum = 0;
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
