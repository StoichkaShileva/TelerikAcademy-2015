/*
    Problem 18. Grouped by GroupNumber

    Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
    Use LINQ.
    Problem 19. Grouped by GroupName extensions

    Rewrite the previous using extension methods.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18.Grouped_by_GroupNumber
{
    class StartMain
    {
        static void Main()
        {
            //Creating some test students
            List<Student> students = new List<Student>();
            List<double> marksA = new List<double>();
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
            //Using Linq
            Console.WriteLine("<<<<< With Linq>>>>>>");
            Console.WriteLine();
            var result = students.OrderBy(st => st.GroupNumber);
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine("<<<<< With extension >>>>>>");
            Console.WriteLine();
            //Using Extensions
            var resultWithExtensions = students.OrderByGroupNumber();
            foreach (var resultWithExtension in resultWithExtensions)
            {
                Console.WriteLine(resultWithExtension);
            }
        }
    }
}
