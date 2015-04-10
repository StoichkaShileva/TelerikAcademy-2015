/*
Problem 1. StringBuilder.Substring
    Implement an extension method Substring(int index, int length) for the class StringBuilder
    that returns new StringBuilder and has the same functionality as Substring in the class String.
 */
namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    public class StringBuilderMain
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(@"Implement an extension method Substring");

            StringBuilder strBuilderTest = sb.SubString(30);
            StringBuilder anotherStrBuilderTest = SubstringExtensions.Substring(sb, 6, 3);

            Console.WriteLine("Result from the stringBuilderTest - {0}", strBuilderTest);
            Console.WriteLine("Result from the anotherStrBuilderTest - {0}", anotherStrBuilderTest);
                
        }
    }
}
