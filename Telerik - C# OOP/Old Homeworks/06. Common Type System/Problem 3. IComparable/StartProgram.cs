/*
 Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
 */

using System;

namespace Problem_3.IComparable
{
    public class StartProgram
    {
        public static void Main()
        {
            Student st1 = new Student();
            st1.Age = 12;
            
            Student st2 = new Student();
            st2.Age = 25;

            Console.WriteLine(new string('=', 30));
            Console.WriteLine("First student age -> {0}", st1.Age);
            Console.WriteLine("Second student age -> {0}", st2.Age);
            Console.WriteLine("Comparing with (student1.CompareTo(student2)) and result is ->");
            Console.WriteLine(st1.CompareTo(st2));
            Console.WriteLine(new string('=', 30));
        }
    }
}
