//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hexadecimal_to_decimal
{
    class HexdecimalToDecimal
    {
        static int ReturnDecimal(string hex)
        {
            int result = 0;
            for (int i = hex.Length - 1, z = 0; i >= 0; i--, z++)
            {
                int currentValue = 0;
                char currentChar = ' ';
                if (!(char.IsDigit(hex[i])))
                {
                    currentChar = Char.ToUpper(hex[i]);
                }
                else
                {
                    currentChar = hex[i];
                }
                switch (currentChar)
                {
                    case 'A':
                        currentValue = 10;
                        break;
                    case 'B':
                        currentValue = 11;
                        break;
                    case 'C':
                        currentValue = 12;
                        break;
                    case 'D':
                        currentValue = 13;
                        break;
                    case 'E':
                        currentValue = 14;
                        break;
                    case 'F':
                        currentValue = 15;
                        break;
                    default:
                        currentValue = int.Parse(hex[i].ToString());
                        break;
                }
                result += (currentValue*(int) Math.Pow(16, z));
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HEXDECIMAL number:");
            string hexdecimal = Console.ReadLine();
            Console.WriteLine("{0} as decimal is {1}", hexdecimal, ReturnDecimal(hexdecimal));
        }
    }
}
