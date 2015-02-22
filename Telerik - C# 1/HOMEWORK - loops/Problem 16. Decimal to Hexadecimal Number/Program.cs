/* 
 Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Decimal_to_Hexadecimal_Number
{
    class Program
    {
        //TODO METHOD FOR DIGITS GREATER THAN 9 !!!
        static string ReturnIntAsChar(long num)
        {
            string result = "";
            switch(num)
            {
                case 10:
                    result += "A";
                    break; 
                case 11:
                    result += "B";
                    break; 
                case 12:
                    result += "C";
                    break; 
                case 13:
                    result += "D";
                    break; 
                case 14:
                    result += "E";
                    break;
                case 15:
                    result += "F";
                    break;

            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal num: ");
            long num = long.Parse(Console.ReadLine());
            string result = "";
            List<string> reminder = new List<string>();
            bool canBeDevide = true;
            long currentNum = num;
            while (canBeDevide)
            {
                if(currentNum / 16 > 0)
                {
                    if(currentNum % 16 > 9)
                    {
                        string resultB = ReturnIntAsChar(currentNum % 16);
                        reminder.Add(resultB);
                    }
                    else
                    {
                        reminder.Add((currentNum % 16).ToString());
                    }
                    
                    currentNum /= 16;
                }
                else if(currentNum < 16 && currentNum > 9)
                {
                    string resultB = ReturnIntAsChar(currentNum);
                    reminder.Add(resultB);
                    canBeDevide = false;
                }
                else if(currentNum <= 9)
                {
                    reminder.Add(currentNum.ToString());
                    canBeDevide = false;
                }
                else
                {
                    canBeDevide = false;
                }
            }
            reminder.Reverse();
            foreach (var item in reminder)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}