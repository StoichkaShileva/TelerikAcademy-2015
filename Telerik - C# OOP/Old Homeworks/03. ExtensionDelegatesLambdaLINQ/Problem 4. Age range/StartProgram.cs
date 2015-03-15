namespace Problem_4.Age_range
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StartProgram
    {
        private static List<Student> AgeRange(List<Student> inputList)
        {
            return inputList.Where(student => student.Age < 24 && student.Age > 18).ToList();
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
            List<Student> result = AgeRange(list);
            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

        }
    }
}
