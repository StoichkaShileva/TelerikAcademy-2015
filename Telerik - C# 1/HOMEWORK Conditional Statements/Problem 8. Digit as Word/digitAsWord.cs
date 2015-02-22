/* 
 Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Digit_as_Word
{
    class digitAsWord
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                Console.WriteLine("two");
                    break;
                case 3:
                Console.WriteLine("three");
                    break;
                case 4:
                Console.WriteLine("four");
                    break;
                case 5:
                Console.WriteLine("five");
                    break;
                case 6:
                Console.WriteLine("six");
                    break;
                case 7:
                Console.WriteLine("eight");
                    break;
                case 8:
                Console.WriteLine("nine");
                    break;
                default:
                Console.WriteLine("not a digit");
                    break;
            }
        }
    }
}
