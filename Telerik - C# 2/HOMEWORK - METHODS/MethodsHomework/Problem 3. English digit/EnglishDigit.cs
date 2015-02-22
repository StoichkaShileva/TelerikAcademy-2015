//Write a method that returns the last digit of given integer as an English word.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.English_digit
{
    class EnglishDigit
    {
        static string ReturnLastDigitAsString(int num)
        {
            string digit = string.Empty;

            string[] nums = new string[]
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };
            digit = nums[num];
            return digit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num:");
            string num = Console.ReadLine();
            string lastDig = num[num.Length-1].ToString();
            int numAsNum = int.Parse(lastDig);
            string lastDigitString = ReturnLastDigitAsString(numAsNum);
            Console.WriteLine(lastDigitString);
        }
    }
}
