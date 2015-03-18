/*
   Problem 1. StringBuilder.Substring
   Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */
namespace Problem_1.StringBuilder.Substring
{
    using System;
    using System.Text;
    class StartMainMethod
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Yeeeah man!"); //Example string
            StringBuilder result = str.Substring(1, 5); //Getting only from index 1 - 5 chars
            Console.WriteLine(result.ToString()); //Printing the obtained result after substring
        }
    }
}
