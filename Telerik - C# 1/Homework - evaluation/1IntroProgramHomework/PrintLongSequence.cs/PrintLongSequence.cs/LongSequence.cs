using System;

namespace PrintLongSequence.cs
{
    class LongSequence
    {
        static void Main()
        {
            for (int i = 2; i < 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + ",");
                }
                else
                {
                    Console.WriteLine(-i+",");
                }
                if (i < 1001)
                {
                    Console.WriteLine(",");
                }
            }
        }
    }
}
