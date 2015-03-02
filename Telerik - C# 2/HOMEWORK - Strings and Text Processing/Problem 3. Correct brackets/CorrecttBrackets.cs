/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Correct_brackets
{
    class CorrecttBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression: ");
            string expression = Console.ReadLine();
            bool isExpCorrect = false;
            int val = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(') val++;
                else if (expression[i] == ')') val--;

                if (val < 0)
                {
                    isExpCorrect = false;
                    break;
                }
            }
            if (val == 0) isExpCorrect = true;
            Console.WriteLine("Expression {0} is {1}", expression, isExpCorrect ? "correct" : "incorrect");
        }
    }
}
