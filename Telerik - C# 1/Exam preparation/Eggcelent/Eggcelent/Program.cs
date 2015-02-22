using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            int height = n * 2;
            int reservedRows = ((height - 4 - (n / 2)) / 2) - 1;
            //if (reservedRows < 0)
            //{
            //    reservedRows = 0;
            //}
            if(n == 2)
            {
                reservedRows = 0;
            }
            char dots = '.';
            char star = '*';
            char moneyA = '@';
            //TOP
            Console.Write(new string(dots, n + 1));
            Console.Write(new string(star, n - 1));
            Console.WriteLine(new string(dots, n + 1));

            for (int i = 0; i < n / 2; i++)
            {
                if (n - 1 - i - i > 0)
                {
                    Console.Write(new string(dots, n - 1 - i - i));
                }
                Console.Write(star);
                Console.Write(new string(dots, n + i + i + i + i + 1));
                Console.Write(star);
                if (n - 1 - i - i > 0)
                {
                    Console.WriteLine(new string(dots, n - 1 - i - i));
                }
                else
                {
                    Console.WriteLine();
                }

            }

            for (int i = 0; i < reservedRows; i++)
            {
                Console.Write(dots);
                Console.Write(star);
                Console.Write(new string(dots, width - 4));
                Console.Write(star);
                Console.WriteLine(dots);
            }

            //MIDDLE
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string(dots, 1));
                    Console.Write(new string(star, 1));
                    for (int j = 0; j < width - 4; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(moneyA);
                        }
                        else
                        {
                            Console.Write(dots);
                        }
                    }
                    Console.Write(new string(star, 1));
                    Console.WriteLine(new string(dots, 1));
                }
                else
                {
                    Console.Write(new string(dots, 1));
                    Console.Write(new string(star, 1));
                    for (int j = 0; j < width - 4; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(dots);
                        }
                        else
                        {
                            Console.Write(moneyA);
                        }
                    }
                    Console.Write(new string(star, 1));
                    Console.WriteLine(new string(dots, 1));
                }
            }
            //BOTTOM
            for (int i = 0; i < reservedRows; i++)
            {
                Console.Write(dots);
                Console.Write(star);
                Console.Write(new string(dots, width - 4));
                Console.Write(star);
                Console.WriteLine(dots);
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(dots, 1 + i + i));
                Console.Write(star);
                if(width - 4 - (4 * i) > 0)
                {
                    Console.Write(new string(dots, width - 4 - (4 * i)));
                }
                Console.Write(star);
                Console.WriteLine(new string(dots, 1 + i + i));
                
            }
            Console.Write(new string(dots, n + 1));
            Console.Write(new string(star, n - 1));
            Console.WriteLine(new string(dots, n + 1));
        }
    }
}
