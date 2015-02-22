/* 
 Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Get_largest_number
{
    class GetMaxVal
    {
        static int GetMax(int firstNum, int secondNum)
        {
            int maxVal;

            if (firstNum > secondNum)
            {
                maxVal = firstNum;
            }
            else if (secondNum == firstNum)
            {
                maxVal = secondNum;
            }
            else
            {
                maxVal = secondNum;
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int second = int.Parse(Console.ReadLine());

            int maxVal = GetMax(first, second);
            Console.WriteLine("Max value is {0}", maxVal);
        }
    }
}
