/*Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/
namespace Problem_4.Age_range
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
        public int Age { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.LastName + " " + this.Age;
        }
    }
}
