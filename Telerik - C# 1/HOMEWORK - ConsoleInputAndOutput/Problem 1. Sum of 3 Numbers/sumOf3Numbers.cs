//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sum_of_3_Numbers
{
    class sumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second num: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third num: ");
            int value3 = int.Parse(Console.ReadLine());

            Console.Write("The sum is: ");
            int finalValue = value1 + value2 + value3;
            Console.WriteLine(finalValue);
        }
    }
}
