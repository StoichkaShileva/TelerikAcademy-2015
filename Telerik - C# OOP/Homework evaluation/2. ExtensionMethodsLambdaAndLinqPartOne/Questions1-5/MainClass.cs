namespace Questions_1and2_
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Question 1 Answers: ");
            Console.ForegroundColor = ConsoleColor.White;
            string initialString = "Pesho";
            StringBuilder someBuilders = new StringBuilder(initialString);
            Console.WriteLine("The string is {0}, inputs for the Substring are: position 1 and length 3", initialString);
            Console.WriteLine("The expected result is: esh");
            Console.WriteLine("Result of Question 1 is: {0}", someBuilders.Substring(1, 3));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Question 2 Answers: ");
            Console.ForegroundColor = ConsoleColor.White;
            IEnumerable<double> data = new List<double>() { 1, 2, 3, 4, 8, 6 };

            Console.Write("The list of ints is: ");
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("The sum is: ");
            data.Sum();
            Console.Write("The min is: ");
            data.Min();
            Console.Write("The max is: ");
            data.Max();
            Console.Write("The average is: ");
            data.Average();
        }
    }
}
