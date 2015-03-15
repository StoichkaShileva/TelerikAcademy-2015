/*
 Problem 3. First before last
 Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
 Use LINQ query operators.
 */
namespace Problem_3.First_before_last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartProgram
    {
        private static List<Student> FirstBeforeLast(List<Student> students)
        {
            var listStudents = students.FindAll(delegate(Student student)
            {
                string currentname = student.Name.ToLower();
                string currentLastName = student.LastName.ToLower();
                if (currentLastName.CompareTo(currentname) < 1)
                {
                    return false;
                }
                return true;
            }).ToList();
            return listStudents;
        }
        static void Main()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student()
            {
                Name = "Ivan",
                LastName = "sexy"
            });
            list.Add(new Student()
            {
                Name = "pich",
                LastName = "drug"
            });
            list.Add(new Student()
            {
                Name = "nov",
                LastName = "az"
            });
            //Only people that firstnames are before lastnames (alphabetically)
            var result = FirstBeforeLast(list);
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}
