using System;
using System.Numerics;

class task
{
    static void Main(string[] args)
    {
        BigInteger v = 123123123123312;
        Console.WriteLine(v * 9999913212312331232 * v);
       long a = long.Parse(Console.ReadLine());
       long b = long.Parse(Console.ReadLine());
       long c = long.Parse(Console.ReadLine());
       long r = 0;
        if (b == 3)
        {
            r += (a + c);
        }
        else if (b == 6)
        {
            r += (a * c);
        }
        else if (b == 9)
        {
            r += (a % c);
        }

        if (r % 3 == 0)
        {
            Console.WriteLine(r / 3);
            Console.WriteLine(r);
        }
        else
        {
            long rTwo = r % 3;
            Console.WriteLine(rTwo);
            Console.WriteLine(r);
        }
    }
}