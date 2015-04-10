using System;

namespace ReadOnlyPracticing
{
    public class StartProgram
    {
        public static void Main()
        {
            Anotherclass cl = new Anotherclass("EE");
            cl.Smth = 2.ToString();
            Console.WriteLine(cl.Smth);

            Console.WriteLine(Anotherclass.SpecialNum);
            Console.WriteLine("");

        }
    }
}
