/* 
 Write a program that gets two numbers from the console and prints the greater of them.
 Try to implement this without if statements.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Number_Comparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            string str = "";
            str = firstNum > secondNum ? str = "First num is greater than the second one" : str = "Second num is greater than the first one";
            Console.WriteLine(str);
        }
    }
}
