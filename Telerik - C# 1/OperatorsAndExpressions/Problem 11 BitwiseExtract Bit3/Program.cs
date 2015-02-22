using System;

namespace Problem11BitwiseExtractBitThree
{
    class BitwiseExtractBitThree
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int data = int.Parse(Console.ReadLine());
            Console.WriteLine("Third bit is {0}", ((data >> 3) & 1));
        }
    }
}