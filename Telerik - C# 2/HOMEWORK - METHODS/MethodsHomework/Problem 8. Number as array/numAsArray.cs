/* 
 Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Number_as_array
{
    class numAsArray
    {
        static char[] NumAsArray(int firstNum, int secondNum)
        {
            string firstNumAsStirng = firstNum.ToString();
            string secondNumAsString = secondNum.ToString();
            char[] finalArr = new char[firstNumAsStirng.Length + secondNumAsString.Length];
            int j = 0;
            for (int i = 0; i < firstNumAsStirng.Length; i++)
            {
                j++;
                finalArr[i] = firstNumAsStirng[i];
            }
            for (int i = 0; i < secondNumAsString.Length; i++, j++)
            {
                finalArr[j] = secondNumAsString[i];
            }

            return finalArr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first digit: ");
            int firstDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second digit: ");
            int secondDigit = int.Parse(Console.ReadLine());

            if (!(firstDigit < 10000 && secondDigit < 10000))
            {
                Console.WriteLine("ERROR, nums have to be under 10 000! :)");
            }
            else
            {
                char[] digitsAsChars = NumAsArray(firstDigit, secondDigit);
                //For Printing
                for (int i = 0; i < digitsAsChars.Length; i++)
                {
                    Console.WriteLine(" - {0} ", digitsAsChars[i]);
                }

            }
        }
    }
}
