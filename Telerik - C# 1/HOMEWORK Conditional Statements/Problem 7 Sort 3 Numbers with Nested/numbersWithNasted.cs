/*
 *Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_Sort_3_Numbers_with_Nested
{
    class numbersWithNasted
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string num = "";

            //first digit (higher)

            if(a >= b && a >= c)
            {
                num += a.ToString();
            }
            else if (b >= a && b >= c)
            {
                num += b.ToString();
            }
            else if (c >= a && c >= b)
            {
                num += c.ToString();
            }

            //Second digit check
            if (a >= b && a <= c)
            {
                num += " " + a;
            }
            else if (a <= b && a >= c)
            {
                num += " " + a;
            }
            else if(b <= a && b >= c)
            {
                num += " " + b;
            }
            else if(b >= a && b <= c)
            {
                num += " " + b;
            }
            else if(c <= a && c >= b)
            {
                num += " " + c;
            }
            else if (c >= a && c <= b)
            {
                num += " " + c;
            }

            //third digit
            if(a <= c && a <= b)
            {
                num += " " + a;
            }
            else if(b <= a && b <= c)
            {
                num += " " + b;
            }
            else if(c <= a && c <= b)
            {
                num += " " + c;
            }
            Console.WriteLine(num);
        }
    }
}
