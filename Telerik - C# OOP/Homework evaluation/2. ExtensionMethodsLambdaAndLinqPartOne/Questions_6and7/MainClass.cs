namespace Questions_6and7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    class MainClass
    {
        /*Problem 6. Divisible by 7 and 3

        Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
        Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

        /*Problem 7. Timer

        Using delegates write a class Timer that can execute certain method at each t seconds.*/

        public delegate void RepeatDelegate(int t);
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = new int[]
            {
                28,21,5,653263,2221,55234,44,42,34,32,78,6324,45687,432,
                11112,11,756,32,654,35,54,23,123,232,113,7,210,12,2143
            };

            //DivisibleBy3And7 with Lambda
            Console.WriteLine("Numbers divisible by 3 and 7 with Lambda: ");
            var divisibleByLambda = arrayOfIntegers
                .Where(x => x % 21 == 0);
            foreach (var item in divisibleByLambda)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //DivisibleBy3And7 with Linq
            Console.WriteLine("Numbers divisible by 3 and 7 with Linq: ");
            var divisibleByLinq =
                from n in arrayOfIntegers
                where n % 3 == 0 && n % 7 == 0
                select n;

            foreach (var item in divisibleByLinq)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Delegate for problem 7
            RepeatDelegate timer = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0}", DateTime.Now);
                }
            };

            timer(1000);
        }

    }
}

