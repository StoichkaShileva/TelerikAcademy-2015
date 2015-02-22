//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ system).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.One_system_to_any_other
{
    class OneSystemToAnyOther
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
        static string ToAnyOther(int num, int system)
        {
            string final = string.Empty;
            bool isHaveToBreak = false;
            while (!isHaveToBreak)
            {
                if (num / system > 0 || num / system == 1)
                {
                    if (num % system > 9 && num % system < system)
                    {
                        final += ReturnSpecialNums(num % system);
                    }
                    else
                    {
                        final += num % system;
                    }
                    num /= system;
                }
                else if (num < system && num > 0)
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
        static int ToDecimal(string input, int system)
        {
            int result = 0;
            for (int i = input.Length - 1, z = 0; i >= 0; i--, z++)
            {
                int currentValue = 0;
                char currentChar = ' ';
                if (!(char.IsDigit(input[i])))
                {
                    currentChar = Char.ToUpper(input[i]);
                }
                else
                {
                    currentChar = input[i];
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
                        currentValue = int.Parse(input[i].ToString());
                        break;
                }
                result += (currentValue * (int)Math.Pow(system, z));
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeral system for your number (2 < system < system");
            int firstNumNumeral = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number in above written system:");
            string num = Console.ReadLine();
            Console.WriteLine("Enter numeral system in which you want to convert your number (2 < system < system");
            int secondNumNumeral = int.Parse(Console.ReadLine());
            int resultAsDecimal = ToDecimal(num, firstNumNumeral);
            string result = ToAnyOther(resultAsDecimal, secondNumNumeral);
            Console.WriteLine(result);

        }
    }
}
