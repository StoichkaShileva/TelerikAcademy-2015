//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Decimal_to_binary
{
    class DecimalToBinary
    {
        static string DecimalToBin(int num)
        {
            string result = string.Empty;
            bool isHaveToBreak = false;
            while (!isHaveToBreak)
            {
                if (num/2 > 0 || num == 1)
                {
                    result += num%2;
                    num /= 2;
                }
                else if (num/2 <= 0)
                {
                    isHaveToBreak = true;
                }
            }
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal number: ");
            int decimalNum = int.Parse(Console.ReadLine());
            string binaryRepresentation = DecimalToBin(decimalNum);
            Console.WriteLine("{0} as binary is {1}", decimalNum, binaryRepresentation);
        }
    }
}
