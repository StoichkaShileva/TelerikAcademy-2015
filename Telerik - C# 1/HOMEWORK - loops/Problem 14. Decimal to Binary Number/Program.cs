/* 
 Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Decimal_to_Binary_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string result = "";
            List<char> binaryNum = new List<char>();
            bool canBeDevide = true;
            while(canBeDevide)
            {
                if(num % 2 == 0 && num != 1)
                {
                    num /= 2;
                    binaryNum.Add('0');
                }
                else if(num % 2 == 1 && num != 1)
                {
                    num /= 2;
                    binaryNum.Add('1');
                }
                else
                {
                    binaryNum.Add('1');
                    canBeDevide = false;
                }
            }
            binaryNum.Reverse();
            foreach (var item in binaryNum)
            {
                Console.Write(item);
            }

        }
    }
}
