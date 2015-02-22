namespace StringTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StringsTest
    {
        static void Main(string[] args)
        {
            string a = "pesho";
            string replacedString = a.Replace("e", "x");
            Console.WriteLine(replacedString);
        }
    }
}
