using System;

namespace delegates
{
    public delegate int JustADelegate();

    public delegate void Print<T>(T param);
    class StartProgram
    {
        static int DoSomething()
        {
            return 1050;
        }

        static void D(decimal s)
        {
            Console.WriteLine(s);
        }
        static void Main()
        {
            JustADelegate d1 = new JustADelegate(DoSomething);
            Console.WriteLine(d1());

            Print<string> d = new Print<string>(Console.WriteLine);

            Action<decimal> deleg = new Action<decimal>(D);

            deleg(3m);
        }
    }
}
