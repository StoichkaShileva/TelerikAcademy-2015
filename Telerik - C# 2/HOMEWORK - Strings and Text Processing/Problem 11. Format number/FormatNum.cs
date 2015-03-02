/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Format_number
{
    class FormatNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "In decimal -> {0:D} | In HEX -> {0:X} | In percentage -> {0:P} | Scientific notation -> {0:C}", num);
        }
    }
}
