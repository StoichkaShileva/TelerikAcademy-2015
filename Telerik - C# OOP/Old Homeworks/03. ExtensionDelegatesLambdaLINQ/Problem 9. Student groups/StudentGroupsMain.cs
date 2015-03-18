/*
   Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
   Create a List<Student> with sample students. Select only the students that are from group number 2.
   Use LINQ query. Order the students by FirstName.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;

namespace Problem_9.Student_groups
{
    class StudentGroupsMain
    {
        private static IOrderedEnumerable<Student> OrderedAndFiltred(List<Student> students)
        {
            var filteredStudents = from student in students
                                  where student.GroupNumber == 2
                                  orderby student.FirstName
                                  select student;
            return filteredStudents;
        }

        private static IEnumerable<Student> ExtractStudentsEmail(List<Student> students)
        {
            var filtered = from student in students
                where student.Email.Substring(student.Email.IndexOf("@") + 1).Equals("abv.bg")
                select student;
            return filtered;
        }

        private static IEnumerable<Student> ExtractByPhone(List<Student> students)
        {
            var result = from student in students
                where student.Tel != null
                select student;
            return result;
        }

        private static IEnumerable<Student> ExtractByMarks(List<Student> students)
        {
            var filtered = from student in students
                from mark in student.Marks
                where mark == 6
                select student;
            return filtered;
        }

        private static IEnumerable<List<double>> ReturnAllMarksIn2006(List<Student> students)
        {
            var result = from student in students
                where student.FN[5] == '0' && student.FN[6] == '6'
                select student.Marks;
            return result;
        }
        static void Main()
        {
            //Creating some test students
            List<Student> students = new List<Student>();
            List<double>marksA = new List<double>();
            marksA.Add(4);
            marksA.Add(5);
            marksA.Add(2);
            marksA.Add(2);
            List<double> marksB = new List<double>();
            marksB.Add(4);
            marksB.Add(3);
            marksB.Add(6);
            marksB.Add(4);
            List<double> marksC = new List<double>();
            marksC.Add(2);
            marksC.Add(3);
            marksC.Add(2);
            marksC.Add(6);
            students.Add(new Student()
            {
                Email = "tosho@abv.bg",
                FirstName = "Tosho",
                FN = "8361706384",
                GroupNumber = 2,
                Tel = "0878775391",
                LastName = "Ivanov",
                Marks = marksA
            });
            students.Add(new Student()
            {
                Email = "vanka@mail.bg",
                FirstName = "Vanio",
                FN = "1537264938",
                GroupNumber = 3,
                LastName = "Petrov",
                Marks = marksB
            });
            students.Add(new Student()
            {
                Email = "joro@moro.bg",
                FirstName = "Jorka",
                FN = "8374629381",
                GroupNumber = 2,
                LastName = "Borka",
                Marks = marksC
            });
            Console.WriteLine("<<<<<Problem 9>>>>>");
            Console.WriteLine();
            // <<<<<Problem 9>>>>>
            //Querying using LINQ
            var filteredStudents = OrderedAndFiltred(students);
            //Printing
            foreach (var filteredStudent in filteredStudents)
            {
                Console.WriteLine(filteredStudent);
            }
            Console.WriteLine();
            Console.WriteLine("<<<<<Problem 10>>>>>");
            Console.WriteLine();
            // <<<<<Problem 10>>>>>
            //Printing using extension methods
            var resultUsingExtension = students.GroupAndOrder();
            foreach (var filtredStudent in resultUsingExtension)
            {
                Console.WriteLine(filtredStudent);
            }
            Console.WriteLine();
            Console.WriteLine("<<<<<Problem 11>>>>>");
            Console.WriteLine();
            // <<<<<Problem 11>>>>>
            var resultAfterSearchingEmail = ExtractStudentsEmail(students);
            foreach (var student in resultAfterSearchingEmail)
            {
                Console.WriteLine(student);
            } 
            Console.WriteLine();
            Console.WriteLine("<<<<<Problem 12>>>>>");
            Console.WriteLine();
            // <<<<<Problem 12>>>>>
            var peopleWithPhones = ExtractByPhone(students);
            foreach (var student in peopleWithPhones)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine("<<<<<Problem 13>>>>>");
            Console.WriteLine();
             //<<<<<Problem 13>>>>>
            var peopleWithHighMarks = ExtractByMarks(students);
            ExtractByMarks(students);
            int iteratorOverStudentsMarks = 0;
            foreach (var student in peopleWithHighMarks)
            {
                var anonymous = new
                {
                    FirstName = student.FirstName,
                    Marks = student.Marks
                };
                Console.Write(anonymous.FirstName + " has { ");
                for (int i = 0; i < anonymous.Marks.Count; i++)
                {
                        Console.Write("{0} ", anonymous.Marks[i]);
                }
                iteratorOverStudentsMarks++;
                Console.WriteLine("}");
            }
            Console.WriteLine();
            Console.WriteLine("<<<<<Problem 14>>>>>");
            Console.WriteLine();
            //<<<<<Problem 14>>>>>
            var peopleWithLowMarks = students.ExtractTwoMarks();
            foreach (var personWithLowMark in peopleWithLowMarks)
            {
                Console.WriteLine(personWithLowMark);
            }
            Console.WriteLine();
            Console.WriteLine("<<<<<Problem 15>>>>>");
            Console.WriteLine();
            //<<<<<Problem 15>>>>>
            var marksIn2006 = ReturnAllMarksIn2006(students);
            foreach (var marks in marksIn2006)
            {
                for (int i = 0; i < marks.Count; i++)
                {
                    Console.Write(marks[i] + " ");
                }
            }

        }

        
    }
}
