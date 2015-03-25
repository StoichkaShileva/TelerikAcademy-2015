/*
 * Define abstract class Human with first name and last name.
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
 * Initialize a list of 10 workers and sort them by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.
*/

namespace Problem_2.Students_and_workers
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    class StartProgram
    {
        static void Main()
        {
            Random rand = new Random(); //Random used for generating grades, money and etc..

            //Initialize 10 students
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Kirov", rand.Next(1, 12)));
            students.Add(new Student("Peter", "Ivanov", rand.Next(1, 12)));
            students.Add(new Student("Gerov", "Georiev", rand.Next(1, 12)));
            students.Add(new Student("Georgi", "Peshov", rand.Next(1, 12)));
            students.Add(new Student("Sasho", "Iliev", rand.Next(1, 12)));
            students.Add(new Student("Asen", "Grigorov", rand.Next(1, 12)));
            students.Add(new Student("Koceto", "Milev", rand.Next(1, 12)));
            students.Add(new Student("Galin", "Mitkov", rand.Next(1, 12)));
            students.Add(new Student("Hristo", "Yovkov", rand.Next(1, 12)));
            students.Add(new Student("Nikolay", "Mirchev", rand.Next(1, 12)));

            Console.WriteLine("*********Test for students (Sorted by grades ascending)**********");

            //Test for students (Sort by grades ascending)
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));
            var result = from student in students
                         orderby student.Grade
                         select student;
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine();
            Console.WriteLine("*********Test for workers (Sorted money per hour - descending)**********");
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));
            //Test for workers (Sort by grades descending)
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Grisha", "Kirov", rand.Next(100, 400), rand.Next(2,8)));
            workers.Add(new Worker("MAM", "Ivanov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Yok", "Georiev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Grigo", "Peshov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Vasko", "Iliev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Blizank", "ivnkov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Stanio", "stankov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Evlogi", "Hristov", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Alexander", "Bonev", rand.Next(100, 400), rand.Next(2, 8)));
            workers.Add(new Worker("Uspokoitelno", "Zaduljitelno", rand.Next(100, 400), rand.Next(2, 8)));
            var resultWorkers = from worker in workers 
                                orderby worker.MoneyPerHour() descending
                                select worker;
            foreach (var worker in resultWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine();
            Console.WriteLine("*********Merged test (Sorted by First and Last name)**********");
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            List<Human> mergedList = new List<Human>();
            for (int i = 0; i < students.Count; i++)
            {
                mergedList.Add(students[i]);
            }
            for (int i = 0; i < workers.Count; i++)
            {
                mergedList.Add(workers[i]);
            }
            //Printing students and workers sorted by first name and lastname
            var finalResult = mergedList.OrderBy(human => human.Firstname).ThenBy(human => human.Lastname);
            foreach (var human in finalResult)
            {
                Console.WriteLine(human);
            }
        }
    }
}
