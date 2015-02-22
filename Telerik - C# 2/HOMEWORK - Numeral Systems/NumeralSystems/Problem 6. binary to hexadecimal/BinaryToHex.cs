//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.binary_to_hexadecimal
{
    class BinaryToHex
    {
        static string Table(string n)
        {
            string curr = string.Empty;
            string num = n;
            //bool isSuccess = false;
            //while (!isSuccess)
            //{
                if (num == "0000")
                {
                    curr += "0";
                }
                else if (num == "0001")
                {
                    curr += "1";
                }
                else if (num == "0010")
                {
                    curr += "2";
                }
                else if (num == "0011")
                {
                    curr += "3";
                }
                else if (num == "0100")
                {
                    curr += "4";
                }
                else if (num == "0101")
                {
                    curr += "5";
                }
                else if (num == "0110")
                {
                    curr += "6";
                }
                else if (num == "0111")
                {
                    curr += "7";
                }
                else if (num == "1000")
                {
                    curr += "8";
                }
                else if (num == "1001")
                {
                    curr += "9";
                }
                else if (num == "1010")
                {
                    curr += "A";
                }
                else if (num == "1011")
                {
                    curr += "B";
                }
                else if (num == "1100")
                {
                    curr += "C";
                }
                else if (num == "1101")
                {
                    curr += "D";
                }
                else if (num == "1110")
                {
                    curr += "E";
                }
                else if (num == "1111")
                {
                    curr += "F";
                }
            return curr;
        }
        static string ReturnBinAsHex(string sBin)
        {
            string result = string.Empty;
            bool isHaveToBreak = false;
            string bin = sBin;
            int startingLength = sBin.Length;
            int i = 0;
            if (bin.Length % 4 != 0)
            {
                while (bin.Length % 4 != 0)
                {
                    bin.PadLeft(1, '0');
                }
            }
            while (!isHaveToBreak)
            {
                string curr = string.Empty;
                for (int j = 0; j < 4; j++)
                {
                    curr += bin[j];
                }
                result += Table(curr);
                string special = bin.Remove(0, 4);
                bin = special;
                if (bin.Length <= 0)
                {
                    isHaveToBreak = true;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary value: ");
            string binaryValue = Console.ReadLine();
            string hexresult = ReturnBinAsHex(binaryValue);
            Console.WriteLine(hexresult);
        }
    }
}
