

using System.Xml.Schema;

namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extensions
    {
        public static int WordCount(this string inputStr)
        {
            int count = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (Char.IsWhiteSpace(inputStr[i]))
                {
                    count++;
                }
            }
            ++count;
            return count;
        }

        public static int CountLetters(this string inputStr)
        {
            int count = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (Char.IsLetter(inputStr[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }

    public static class ExtensionMethods
    {
        public static int CountWhitespaces(this string value)
        {
            int whitespaces = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsWhiteSpace(value[i]))
                    whitespaces++;
            }
            return whitespaces;
        }
    }

    class StartProgram
    {
        static void Main(string[] args)
        {
            string spec = @"New, breakthrough mini architectural structures are on their way to revolutionizing the future of how dikes, levees, airplanes and rockets are built. Researchers from the Massachusetts Institute of Technology have designed simple additive manufacturing lattice structures similar to K'nex construction";
            int count = spec.WordCount();
            int letterCount = spec.CountLetters();
            Console.WriteLine(count);
            Console.WriteLine(letterCount);
            Console.WriteLine(spec.CountWhitespaces());
            var annonymousType = new {X = 5, Y = 10};
            Console.WriteLine(annonymousType.X);
            Console.BufferWidth = 500;
            Console.BufferHeight = 500;
            Console.Clear();
        }
    }
}
