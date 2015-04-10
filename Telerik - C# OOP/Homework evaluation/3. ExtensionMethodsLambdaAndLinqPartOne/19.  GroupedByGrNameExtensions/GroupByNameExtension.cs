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
            new Students("Ivan", "Ivanov", "001212", "0878121212", "vankata@gmail.com",
            new List<int> { (int)Marks.Good, (int)Marks.Very_good, (int)Marks.Average }, 3));
       
            var groupedStudents2 = StudentsApplication.sampleStudents.GroupBy(x => x.GroupNumber,
            (groupNumber, students) => new { Group = groupNumber, Students = students });
            foreach (var grouped in groupedStudents2)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                string.Join("\r\n\r\n", grouped.Students));
            }
        }
    }

}