/*
 *ite a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Numbers_Not_Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                if (i % 3 == 0 || i % 7 == 0) continue;
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
