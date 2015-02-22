//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Binary_short
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter short number ");
            short num = short.Parse(Console.ReadLine());
            string result = inBinary(num).ToString();
            Console.WriteLine("{0} as binary is {1}", num, result);
        }
        static string inBinary(short s)
        {
            string bin = String.Empty;
            for (int i = 0; i < 16; i++)
            {
                bin = (s >> i & 1) + bin;
            }
            return bin;
        }
    }
}
