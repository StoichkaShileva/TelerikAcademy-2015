namespace Problem_3.First_before_last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int age { get; private set; }

        public override string ToString()
        {
            return this.Name + " " + this.LastName;
        }
    }
}
