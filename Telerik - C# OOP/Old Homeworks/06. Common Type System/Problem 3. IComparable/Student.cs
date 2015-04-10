
namespace Problem_3.IComparable
{
    using System;
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public int CompareTo(Student other)
        {
            if (other.Age > this.Age)
                return -1;
            else if (other.Age < this.Age)
                return 1;
            else
                return 0;
        }
    }
}
