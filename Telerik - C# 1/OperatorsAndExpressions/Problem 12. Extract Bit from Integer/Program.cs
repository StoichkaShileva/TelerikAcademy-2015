using System;

namespace Problem12ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int data = int.Parse(Console.ReadLine());
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            if (index > 31)
            {
                Console.WriteLine("Index is not correct");
            }
            else
            {
                Console.WriteLine("Bit number {0} is {1}", index, ((data >> index) & 1));
            }
        }
    }
}