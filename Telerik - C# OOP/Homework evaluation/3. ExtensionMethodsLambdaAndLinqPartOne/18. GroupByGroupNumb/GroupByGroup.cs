// Problem 18 - Create a program that extracts all students grouped by GroupNumber and then prints

namespace GroupByGroupNumb
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using StudentsGroup;

    class GroupByGroup
    {

        static void Main()
        {
            StudentsApplication.sampleStudents.Add(
            new Students("Asan", "Asanov", "02446443", "08888888888", "asanchy72@shemail.com",
            new List<int> { (int)Marks.Good, (int)Marks.Very_good, (int)Marks.Average }, 3));

            var groupedStudents =
            from student in StudentsApplication.sampleStudents
            group student by student.GroupNumber
                into groups
                select new
                {
                    Group = groups.Key,
                    Students = groups.ToList()
                };

            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                string.Join("\r\n\r\n", grouped.Students));
            }
        }
    }
}