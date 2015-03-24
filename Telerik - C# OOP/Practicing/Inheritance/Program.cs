using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Egn { get; set; }
        public override string ToString()
        {
            return this.Name + " " + this.Age;
        }
    }

    public class Student : Person
    {
        public List<int> Marks { get; set; }
        public int NumberOfAbsences { get; set; }
        public override string ToString()
        {
            return this.NumberOfAbsences.ToString();
        }
    }
    class StartProgram
    {
        static void Main()
        {
            Student st = new Student();
            st.Age = 5;
            st.Marks = new List<int>(){4,5,2,5,3};
            st.Name = "Pesho!";
            st.NumberOfAbsences++;
            Console.WriteLine(st);
        }
    }
}
