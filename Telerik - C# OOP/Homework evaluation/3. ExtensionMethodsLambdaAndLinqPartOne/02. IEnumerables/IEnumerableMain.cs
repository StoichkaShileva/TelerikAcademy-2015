/*
Problem 2. IEnumerable extensions
Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/
namespace IEnumerables
{
    using System;
    using System.Collections.Generic;

    public class IEnumerableExtensionsMain
    {
        public static void Main()
        {
            IEnumerable<int> input = new List<int>() { 12, 42, 2, 17, 36, 55, 1, 0 };
            Console.WriteLine(input.SumOfCollection());
            Console.WriteLine();

            IEnumerable<double> antoherImput = new[] { 1.1, 12.5, 3.1, 4.9, 7.5, 5.5 };

            Console.WriteLine(antoherImput.SumOfCollection());
            Console.WriteLine();

            Console.WriteLine(antoherImput.ProductOfCollection());
            Console.WriteLine();

            Console.WriteLine(antoherImput.MinValueInCollection());
            Console.WriteLine();

            Console.WriteLine(antoherImput.MaxValueInCollection());
            Console.WriteLine();

            Console.WriteLine(antoherImput.CollectionAverage());
            Console.WriteLine();

            Console.WriteLine(IEnumerableExtensions.CollectionAverage(input));
            Console.WriteLine();

            Console.WriteLine(IEnumerableExtensions.ProductOfCollection(antoherImput));
            Console.WriteLine();

        }
    }
}
