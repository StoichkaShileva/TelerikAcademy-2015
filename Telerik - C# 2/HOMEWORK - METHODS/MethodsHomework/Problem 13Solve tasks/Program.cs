/* 
 
 Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13Solve_tasks
{
    class Program
    {
        static int ReverseNum(int num)
        {
            int finalResult = 0;
            string finalStr = string.Empty;
            string numAsString = num.ToString();
            for (int i =  numAsString.Length - 1; i >= 0; i--)
            {
                finalStr += numAsString[i];
            }

            finalResult = int.Parse(finalStr);
            return finalResult;
        }
        static int SolveEquation(int a, int b, int x)
        {
            int result = 0;
            result += (a * x);
            result += b;
            return result;

        }

        static int CalculateAverage(int[] arr)
        {
            var num = arr.Average();
            return (int)num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 (reverse) 2 (average num) 3 (linear equation) : ");
            int r = int.Parse(Console.ReadLine());
            if (r == 1)
            {
                Console.WriteLine("Enter num to reverse: ");
                int num = int.Parse(Console.ReadLine());
                int reversed = ReverseNum(num);
                Console.WriteLine(reversed);

            }
            else if (r == 2)
            {
                Console.WriteLine("Enter array from integers each digit have to be seperated with single space:  ");
                int[] arr =
                    Console.ReadLine()
                        .Split(new string[] {", ", " ", " "}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();
                int averageNum = CalculateAverage(arr);
                Console.WriteLine(averageNum);
            }
            else if (r == 3)
            {
                Console.WriteLine("Enter A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter X: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter B: ");
                int b = int.Parse(Console.ReadLine());
                int result = SolveEquation(a, b, x);
                Console.WriteLine(result);
            }
        }

        
    }
}
