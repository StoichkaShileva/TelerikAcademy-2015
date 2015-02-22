//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Hexadecimal_to_binary
{
    class HexdecimalToBin
    {
        static string Table(char n)
        {
            string curr = string.Empty;
            char num = char.ToUpper(n);
            if (num == '0')
            {
                curr += "0000";
            }
            else if (num == '1')
            {
                curr += "0001";
            }
            else if (num == '2')
            {
                curr += "0010";
            }
            else if (num == '3')
            {
                curr += "0011";
            }
            else if (num == '4')
            {
                curr += "0100";
            }
            else if (num == '5')
            {
                curr += "0101";
            }
            else if (num == '6')
            {
                curr += "0110";
            }
            else if (num == '7')
            {
                curr += "0111";
            }
            else if (num == '8')
            {
                curr += "1000";
            }
            else if (num == '9')
            {
                curr += "1001";
            }
            else if (num == 'A')
            {
                curr += "1010";
            }
            else if (num == 'B')
            {
                curr += "1011";
            }
            else if (num == 'C')
            {
                curr += "1100";
            }
            else if (num == 'D')
            {
                curr += "1101";
            }
            else if (num == 'E')
            {
                curr += "1110";
            }
            else if (num == 'F')
            {
                curr += "1111";
            }
            return curr;
        }
        static string ReturnHexAsBin(string hex)
        {
            string result = string.Empty;
            for (int i = 0; i < hex.Length; i++)
            {
                result += Table(hex[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexdecimal value: ");
            string hexdecimal = Console.ReadLine();
            string binResult = ReturnHexAsBin(hexdecimal);
            Console.WriteLine(binResult);
        }   
    }
}
