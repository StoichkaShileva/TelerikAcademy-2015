using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xexpression
{
    class ExpressionSolving
    {
        static decimal Brackets(string exp)
        {
            decimal result = 0;
            for (int i = 0; i < exp.Length; i++)
            {
                if(i == 0)
                {
                    result += decimal.Parse(exp[0].ToString());
                }
                else if(exp[i] == '+')
                {
                    result += decimal.Parse(exp[i + 1].ToString());
                }
                else if(exp[i] == '-')
                {
                    result -= decimal.Parse(exp[i + 1].ToString());
                }
                else if (exp[i] == '*')
                {
                    result *= decimal.Parse(exp[i + 1].ToString());
                }
                else if (exp[i] == '%')
                {
                    result %= decimal.Parse(exp[i + 1].ToString());
                }
            }
            return result;
        }
        static decimal CallBracketsMethod(ref int i, string exp)
        {
            string currentExp = "";
            int inc = i + 2;
            i += 2;
            while (exp[inc] != ')')
            {
                currentExp += exp[inc];
                inc++;
                i++;
            }
            decimal brResult = Brackets(currentExp);
            int length = currentExp.Length + 2;
            return brResult;
        }
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            decimal result = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if(i == 0)
                {
                    result += decimal.Parse(expression[0].ToString());
                }
                else if(expression[i] == '+')
                {
                    if(expression[i+1] != '(')
                    {
                        result += decimal.Parse(expression[i + 1].ToString());
                    }
                    else
                    {
                        decimal r = CallBracketsMethod(ref i, expression);
                        result += r;
                    }
                    
                }
                else if(expression[i] == '-')
                {
                    if (expression[i + 1] != '(')
                    {
                        result -= decimal.Parse(expression[i + 1].ToString());
                    }
                    else
                    {
                        decimal r = CallBracketsMethod(ref i, expression);
                        result -= r;
                    }
                    
                }
                else if (expression[i] == '*')
                {
                    if (expression[i + 1] != '(')
                    {
                        result *= decimal.Parse(expression[i + 1].ToString());
                    }
                    else
                    {
                        decimal r = CallBracketsMethod(ref i, expression);
                        result *= r;
                    }
                    
                }
                else if (expression[i] == '%')
                {
                    if (expression[i + 1] != '(')
                    {
                        result %= decimal.Parse(expression[i + 1].ToString());
                    }
                    else
                    {
                        decimal r = CallBracketsMethod(ref i, expression);
                        result %= r;
                    }
                    
                }
            }
            Console.WriteLine("{0:f3}",result);
        }
    }
}
