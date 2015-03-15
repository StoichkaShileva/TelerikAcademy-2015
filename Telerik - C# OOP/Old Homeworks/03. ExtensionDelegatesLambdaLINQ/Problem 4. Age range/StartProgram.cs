/*Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/
namespace Problem_4.Age_range
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StartProgram
    {
        private static IEnumerable<Student> AgeRange(List<Student> inputList)
        {
            var result = from value in inputList
                where value.Age < 24 && value.Age > 18
                select value;
            return result;
        }
        public static void Main()
        {
            List<Student> list = new List<Student>();
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
                Age =  22
            });
            list.Add(new Student()
            {
                Name = "Mariq",
                LastName = "Petrova",
                Age = 14
            });
            var resultFinal = AgeRange(list);
            foreach (var student in resultFinal)
            {
                Console.WriteLine(student);
            }

        }
    }
}
