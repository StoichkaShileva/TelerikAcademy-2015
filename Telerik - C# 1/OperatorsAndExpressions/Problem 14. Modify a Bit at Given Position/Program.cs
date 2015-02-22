/* 
    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Modify_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter integer for a bit value (1 or 0): ");
            int bitValue = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            bool isValidBitValue = false;
            while(!isValidBitValue)
            {
                if(bitValue == 1 || bitValue == 0)
                {
                    isValidBitValue = true;
                }
                else
                {
                    Console.Write("WRONG BIT VALUE! Please enter a valid bit value (1 or 0): ");
                    bitValue = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
