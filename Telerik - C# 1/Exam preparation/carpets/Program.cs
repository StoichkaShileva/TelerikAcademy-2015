using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char leftSlash = '\\';
            char rightSlash = '/';
            //ROOF
            Console.Write(new string(dot, n / 2 - 1));
            Console.Write(rightSlash);
            Console.Write(leftSlash);
            Console.WriteLine(new string(dot, n / 2 - 1));
            int specialIterator = 0;
            //TOP
            for (int i = 0; i < n / 2 - 1; i++)
            {
                if (n / 2 - 2 - i > 0)
                {
                    Console.Write(new string(dot, n / 2 - 2 - i));
                }
                Console.Write(rightSlash);
                Console.Write(' ');
                
                if(i % 2 != 0)
                {
                    Console.Write(rightSlash);
                    Console.Write(new string(' ', specialIterator));
                    if(specialIterator >= 4)
                    {
                        Console.Write(rightSlash);
                        Console.Write(new string(' ', specialIterator - 4));
                        Console.WriteLine(leftSlash);
                    }
                    Console.WriteLine(leftSlash);
                    specialIterator += 4;
                }
                else
                {
                    Console.WriteLine(' ');
                }




            }
        }
    }
}
