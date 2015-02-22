//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Binary_to_decimal
{
    class BinaryToDecimal
    {
        static int ReturnAsDecimal(string bin)
        {
            int result = 0;
            for (int i = bin.Length - 1, z = 0; i >= 0; i--, z++)
            {
                int binAsInt = int.Parse(bin[i].ToString());
                if (binAsInt != 1 && binAsInt != 0)
                {
                    return -1;
                }
                result += binAsInt * (int)Math.Pow(2, z);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary num: ");
            string bin = Console.ReadLine();
            int result = ReturnAsDecimal(bin);
            if (result == -1)
            {
                Console.WriteLine("WRONG INPUT, binary numbers are only 1 OR 0!");
            }
            else
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
