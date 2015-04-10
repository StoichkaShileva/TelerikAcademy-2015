using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Empty
{
    using System;
    public class StartProgram
    {
        public static void Main()
        {
            Test aTest = new Test("HeeO", 11121);
            Test bTest = new Test("HOHO", 1112211321);
            AnotherClass cTest = new AnotherClass("a", 22, "looo@@@LLLLLLL");
            var resultFromComparison = aTest.CompareTo(bTest);
            Console.WriteLine(resultFromComparison);
        }
    }
}