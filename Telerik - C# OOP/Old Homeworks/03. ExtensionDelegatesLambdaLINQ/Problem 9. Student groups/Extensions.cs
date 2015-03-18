/*Implement the previous using the same query expressed with extension methods.*/
namespace Problem_9.Student_groups
{
    using System.Collections.Generic;
    using System.Linq;
    public static class Extensions
    {
        public static IOrderedEnumerable<Student> GroupAndOrder(this List<Student> input)
        {
            var queryResult = from student in input
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            return queryResult;
        }

        public static List<Student> ExtractTwoMarks(this List<Student> input)
        {
            List<Student> result = new List<Student>();
            for (int i = 0; i < input.Count; i++)
            {
                int current2 = 0;                
                for (int j = 0; j < input[i].Marks.Count; j++)
                {
                    if (input[i].Marks[j] == 2)
                        current2++;
                }
                if (current2 >= 2)
                {
                    result.Add(input[i]);
                }
            }
            return result;
        }
    }
}
