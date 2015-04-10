namespace Questions_3to5_StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClass
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() 
             {
                 new Student("Ali", "Raza",20),
                 new Student("Boiko", "Borisov",30),
                 new Student("Gosho", "Selskiq",25),
                 new Student("Pesho", "Ahmaka",18),
                 new Student("Gencho", "Abdala",24)
            };

            Student reference = new Student();

            List<Student> sortedNamesList = reference.FirstBeforeLast(students);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Question 3 Answer: Sorting students by First and Last Name");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in sortedNamesList)
            {
                Console.WriteLine("{0} {1}, {2}", item.FirstName, item.LastName, item.Age);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Question 4 Answer: Sorting students by Age between 18 and 24");
            Console.ForegroundColor = ConsoleColor.White;
            List<Student> sortedAgeList = reference.AgeRange(students);

            foreach (var item in sortedAgeList)
            {
                Console.WriteLine("{0} {1}, {2}", item.FirstName, item.LastName, item.Age);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Question 5 Answer: Sorting students by first and last name in descending order.");
            Console.ForegroundColor = ConsoleColor.White;
            List<Student> sortedByDescendingList = reference.SortByDescending(students);
            foreach (var item in sortedByDescendingList)
            {
                Console.WriteLine("{0} {1}, {2}", item.FirstName, item.LastName, item.Age);
            }
        }
    }
}
