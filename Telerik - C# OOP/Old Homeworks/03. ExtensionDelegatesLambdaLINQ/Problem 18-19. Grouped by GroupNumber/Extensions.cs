/*
    Problem 18. Grouped by GroupNumber

    Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
    Use LINQ.
    Problem 19. Grouped by GroupName extensions

    Rewrite the previous using extension methods.
 */
namespace Problem_18.Grouped_by_GroupNumber
{
    using System.Collections.Generic;
    using System.Linq;
    public static class Extensions
    {
        public static IEnumerable<Student> OrderByGroupNumber(this List<Student> input)
        {
            var result = input.OrderBy(st => st.GroupNumber);
            return result;
        }
    }
}
