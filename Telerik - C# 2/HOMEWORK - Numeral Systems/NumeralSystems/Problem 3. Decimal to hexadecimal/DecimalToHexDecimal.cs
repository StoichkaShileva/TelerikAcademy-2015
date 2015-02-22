/*Write a program to convert decimal numbers to their hexadecimal representation.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Decimal_to_hexadecimal
{
    class DecimalToHexDecimal
    {
        static string ReturnSpecialNums(int num)
        {
            string final = String.Empty;
            switch (num)
            {
                case 10:
                    final += "A";
                    break;
                case 11:
                    final += "B";
                    break;
                case 12:
                    final += "C";
                    break;
                case 13:
                    final += "D";
                    break;
                case 14:
                    final += "E";
                    break;
                case 15:
                    final += "F";
                    break;
            }
            return final;
        }
        static string ToHexDecimal(int num)
        {
            string final = string.Empty;
            bool isHaveToBreak = false;
            while (!isHaveToBreak)
            {
                if (num / 16 > 0 || num / 16 == 1)
                {
                    if (num % 16 > 9 && num % 16 < 16)
                    {
                        final += ReturnSpecialNums(num % 16);
                    }
                    else
                    {
                        final += num % 16;
                    }
                    num /= 16;
                }
                else if (num < 16 && num > 0)
                {
                    if (num > 9)
                    {
                        final += ReturnSpecialNums(num);
                    }
                    else
                    {
                        final += num;
                    }
                    isHaveToBreak = true;
                }
                else
                {
                    isHaveToBreak = true;
                }
            }
            char[] arr = final.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} az hexdecimal is {1}", num, ToHexDecimal(num));
        }
    }
}
