namespace constructors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartProgram
    {
        static void Main()
        {
            AnotherClass an = new AnotherClass();
            an.CarAge = 100;
            Console.WriteLine(an.AgeP);
            Console.WriteLine(an.CarAge);
            NoPainNoGain a = new NoPainNoGain();
            a.GainPercentage = 99;
        }
    }
}
