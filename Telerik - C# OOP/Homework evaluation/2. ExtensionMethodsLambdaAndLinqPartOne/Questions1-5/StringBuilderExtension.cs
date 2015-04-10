namespace Questions_1and2_
{
    using System;
    using System.Text;

    //Problem 1.
    /*Implement an extension method Substring(int index, int length) for the class StringBuilder 
     * that returns new StringBuilder and has the same functionality as Substring in the class String.*/

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder newBuilder = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                newBuilder.Append(str[i]);
            }
            return newBuilder;
        }
    }
}
