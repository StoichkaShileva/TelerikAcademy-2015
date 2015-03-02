/*Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Enter_numbers
{
    class EnterNumbers
    {
        
        static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter number - N in format 1 < N < 100 ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num > start && num < end)
                    Console.WriteLine("IN RANGE! {0} - {1}", start, end);
                else
                    throw new ArgumentOutOfRangeException("Number is not in a specified range!");

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void LoopTenTimes()
        {
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(0, 100);
            }
        }
        static void Main(string[] args)
        {
            LoopTenTimes();
        }
    }
}
