namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ListOverride : List<Student>
    {
        public ListOverride(List<Student> students) : base(students)
        {
            
        }
        public override string ToString()
        {
            StringBuilder names = new StringBuilder();
            foreach (var name in this)
            {
                names.AppendLine(name.Name);
            }
            return names.ToString();
        }
    }
    public delegate void Delegate(int method);

    public delegate List<Student> DelegateStudent(int number);
    class DelegatesPractice
    {
        static void PrintNumber(int num)
        {
            Console.WriteLine(num);
        }

        static void Num2(int num)
        {
            Console.WriteLine(num+= 20202);
        }

        static List<Student> ReturnManyStudents(int num)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                students.Add(new Student());
            }
            return students;
        }
        static void Main()
        {
            Delegate groupInt = new Delegate(PrintNumber);
            groupInt += Num2;
            groupInt(5);
            Console.Clear();

            DelegateStudent dStudent = new DelegateStudent(ReturnManyStudents);
        }
    }
}
