/* 
 Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Hexadecimal_to_Decimal_Number
{
    class Program
    {
        static long Pow(int num, int i)
        {
            long result = 1;
            for (int a = 0; a < i; a++)
            {
                result *= num;
            }
            return result;
        }
        static int ReturnValueOfChar(char a)
        {
            int result = 0;
            switch (a)
            {
                case 'A':
                    result = 10;
                    break;
                case 'B':
                    result = 11;
                    break;
                case 'C':
                    result = 12;
                    break;
                case 'D':
                    result = 13;
                    break;
                case 'E':
                    result = 14;
                    break;
                case 'F':
                    result = 15;
                    break;

            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long result = 0;
            for (int i = input.Length - 1, r = 0; i >= 0; i--, r++)
            {
                int currentValue = 0;
                if (Char.IsDigit(input[i]))
                {
                    currentValue = int.Parse(input[i].ToString());
                }
                else
                {
                    currentValue = ReturnValueOfChar(input[i]);
                }
                result += currentValue * Pow(16, r);
            }
            Console.WriteLine(result);
        }
    }
}
