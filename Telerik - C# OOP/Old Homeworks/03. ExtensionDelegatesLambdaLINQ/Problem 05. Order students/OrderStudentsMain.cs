/*
  <<<<<>>>>> CONDITION <<<<<>>>>>
  @ Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
  @ Rewrite the same with LINQ.
*/
namespace Problem_5.Order_students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class OrderStudents
    {
        //Solving the problem using Linq
        private static IEnumerable<Student> Sort(List<Student> input)
        {
            //LINQ query
            var result = from value in input
                orderby value.Name descending
                orderby value.LastName descending
                select value;
            //Returning result
            return result;
        }
        public static void Main()
        {
            //Initialization of a list for some test students
            List<Student> list = new List<Student>();
            //Adding test students in the list
            list.Add(new Student()
            {
                Name = "Georgi",
                LastName = "Grigorov",
                Age = 52
            });
            list.Add(new Student()
            {
                Name = "Ivan",
                LastName = "Ivanov",
                Age = 22
            });
            list.Add(new Student()
            {
                Name = "Mariq",
                LastName = "Petrova",
                Age = 14
            });

            //Solving the problem using lambda
            List<Student> result = list.OrderByDescending(student => student.Name)
                .ThenByDescending(student => student.LastName).ToList();
            //Printing the result with lambda ->>
            Console.WriteLine("With lambda -> ");
            Console.WriteLine();
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.Write(new string('<',20));
            Console.WriteLine(new string('>',20));
            Console.WriteLine();
            //Printing the result with linq ->>

            Console.WriteLine("With linq -> ");
            Console.WriteLine();
            var resultWithLinq = Sort(list);
            foreach (var student in resultWithLinq)
            {
                Console.WriteLine(student);
            }

        }
    }
}
