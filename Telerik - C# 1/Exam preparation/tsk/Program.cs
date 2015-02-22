using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}", new string(' ', n - 1), new string(':', n));
        for (int i = n - 3; i >= 0; i--) Console.WriteLine("{0}:{1}:{2}:", new string(' ', i + 1), new string('/', n - 2), new string('X', n - 3 - i));
        Console.WriteLine("{0}{1}:", new string(':', n), new string('X', n - 2));
        for (int i = n - 3; i >= 0; i--) Console.WriteLine(":{0}:{1}:", new string(' ', n - 2), new string('X', i));
        Console.WriteLine(new string(':', n));
    }
}
