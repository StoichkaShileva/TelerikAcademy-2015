namespace Questions_1and2_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*Problem 2. IEnumerable extensions

    Implement a set of extension methods for IEnumerable<T> that implement 
     * the following group functions: sum, product, min, max, average.*/

    public static class IEnumerableExtensions
    {
        //Extension method for Sum
        public static void Sum<T>(this IEnumerable<T> someEnumerable)
        {
            dynamic sum = 0;
            foreach (var item in someEnumerable)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        //Extension method for Product
        public static void Product<T>(this IEnumerable<T> someEnumerable)
        {
            dynamic sum = 1;
            foreach (var item in someEnumerable)
            {
                sum *= item;
            }
            Console.WriteLine(sum);
        }

        //Extension method for the minimum
        public static void Min<T>(this IEnumerable<T> someEnumerable) where T : IComparable<T>
        {
            var min = someEnumerable.First();

            foreach (var item in someEnumerable)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            Console.WriteLine(min);
        }

        //Extension method for the maximum
        public static void Max<T>(this IEnumerable<T> someEnumerable) where T : IComparable<T>
        {
            var max = someEnumerable.First();

            foreach (var item in someEnumerable)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }

        //Extension method for the average
        public static void Average<T>(this IEnumerable<T> someEnumerable)
        {
            dynamic sum = 0;
            foreach (var item in someEnumerable)
            {
                sum += item;
            }
            Console.WriteLine(sum / someEnumerable.Count());
        }
    }
}
