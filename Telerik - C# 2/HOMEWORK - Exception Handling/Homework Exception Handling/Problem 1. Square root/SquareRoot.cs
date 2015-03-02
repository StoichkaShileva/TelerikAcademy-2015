/*Write a program that reads an integer number and calculates and prints its square root.
    If the number is invalid or negative, print Invalid number.
    In all cases finally print Good bye.
Use try-catch-finally block.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Square_root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to calculate square root: ");
            int val;
            double sqrt;
            try
            {
                val = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(val));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!"); 
            }
        }
    }
}
