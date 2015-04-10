
namespace Questions_3to5_StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /* Problem 3. First before last

      Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
      Use LINQ query operators.*/


    public class Student
    {
        public Student()
        {

        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Problem 3
        public List<Student> FirstBeforeLast(List<Student> students)
        {
            var sortedStudents = students
                .Where(x => x.FirstName.CompareTo(x.LastName) < 0)
                .ToList();
            return sortedStudents;
        }

        //Problem 4
        public List<Student> AgeRange(List<Student> students)
        {
            var sortedStudents = students
                .Where(x => (x.Age >= 18) && (x.Age <= 24))
                .ToList();
            return sortedStudents;
        }
        //Problem 5
        public List<Student> SortByDescending(List<Student> students)
        {
            var sortedStudents = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).ToList();
            return sortedStudents;
        }
    }
}
