namespace _03.Range_Exceptions
{
    using System;
    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string msg, T startRange, T endRange)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Start range: {0}", startRange);
            Console.WriteLine("End range: {0}", endRange);
        }
    }
}