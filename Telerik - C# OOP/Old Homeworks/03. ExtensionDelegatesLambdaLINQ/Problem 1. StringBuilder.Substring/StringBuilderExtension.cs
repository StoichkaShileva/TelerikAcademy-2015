/*
   Problem 1. StringBuilder.Substring
   Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */
namespace Problem_1.StringBuilder.Substring
{
    using System.Text;
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder final = new StringBuilder();
            for (int i = index; z < length; i++)
            {
                final.Append(input[i]);
            }
            return final;
        }
    }
}
