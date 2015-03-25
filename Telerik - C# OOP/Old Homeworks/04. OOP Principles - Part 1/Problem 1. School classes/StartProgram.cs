/*
 We are given a school. In the school there are classes of students.
 * Each class has a set of teachers. Each teacher teaches a set of disciplines. 
 * Students have name and unique class number. Classes have unique text identifier.
 * Teachers have name. Disciplines have name, number of lectures and number of exercises.
 * Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields,
 * define the class hierarchy and create a class diagram with Visual Studio.
 */
namespace Problem_1.School_classes
{
    using System;
    using System.Collections.Generic;
    class StartProgram
    {
        static void Main()
        {
            List<Discipline> disciplines = new List<Discipline>()
            {
                new Discipline()
                {
                    DisciplineName = "Iconomy",
                    NumberOfLectures = 45,
                    NumberOfExercises = 50
                },
                new Discipline()
                {
                    DisciplineName = "Math",
                    NumberOfLectures = 90,
                    NumberOfExercises = 160
                },
                new Discipline()
                {
                    DisciplineName = "Programming",
                    NumberOfLectures = 160,
                    NumberOfExercises = 330
                }
            };
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher()
                {
                    Age = 23,
                    Firstame = "Ivan",
                    Lastname = "Baroveca",
                    Disciplines = new List<Discipline>()
                    {
                        disciplines[0],
                        disciplines[2]
                    }
                },
                new Teacher()
                {
                    Age = 40,
                    Firstame = "Stefan",
                    Lastname = "Georgiev",
                    Disciplines =  new List<Discipline>()
                    {
                        disciplines[1]
                    }
                }
            };
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Age = 18,
                    Comment = "A good student",
                    Firstame = "Ivo",
                    Lastname = "Grigorov",
                    UniqueId = "I4874V6487O",
                    Disciplines = new List<Discipline>()
                    {
                        disciplines[2]
                    }
                },
                new Student()
                {
                    Age = 22,
                    Comment = "This student has bad marks",
                    Firstame = "Konstatnin",
                    Lastname = "Petrov",
                    UniqueId = "K45O31N889S125T4741A7733N184T881I58N",
                    Disciplines = new List<Discipline>()
                    {
                        disciplines[0]
                    }
                }
            };

            Console.WriteLine("Creating a school: ");
            School school = new School();
            school.Name = "Cambridge";
            Console.WriteLine("School name: {0}", school.Name);

            school.Students = students;
            school.Teachers = teachers;
            Console.WriteLine();
            Console.WriteLine(new string('@', 60));
            Console.WriteLine("School teachers: ");
            Console.WriteLine();
            for (int i = 0; i < school.Teachers.Count; i++)
            {
                Console.WriteLine("Teacher First name: {0}", school.Teachers[i].Firstame);
                Console.WriteLine("Teacher Last name: {0}", school.Teachers[i].Lastname);
                Console.WriteLine("Teacher Age: {0}", school.Teachers[i].Age);
                Console.Write("Teacher disciplines: ");
               foreach(var disc in school.Teachers[i].Disciplines)
                    Console.Write(disc.DisciplineName + ", ");
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
            }
            Console.WriteLine(new string('@', 60));
            Console.WriteLine("School students: ");
            Console.WriteLine();
            for (int i = 0; i < school.Students.Count; i++)
            {
                Console.WriteLine("Student First name: {0}", school.Students[i].Firstame);
                Console.WriteLine("Student Last name: {0}", school.Students[i].Lastname);
                Console.WriteLine("Student Age: {0}", school.Students[i].Age);
                Console.Write("Student disciplines: ");
                foreach (var disc in school.Students[i].Disciplines)
                    Console.Write(disc.DisciplineName + ", ");
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}