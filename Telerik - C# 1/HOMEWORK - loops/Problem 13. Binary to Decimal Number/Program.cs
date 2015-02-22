/* 
 Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Binary_to_Decimal_Number
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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number: ");
            string binary = Console.ReadLine();
            long result = 0;
            for (int i = binary.Length - 1, z = 0; i >= 0; i--, z++)
            {
                result += long.Parse(binary[i].ToString()) * Pow(2, z);
            }
            Console.WriteLine(result);
        }
    }
}
