/*
   Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
   Create a List<Student> with sample students. Select only the students that are from group number 2.
   Use LINQ query. Order the students by FirstName.
 */

using System.Collections.Generic;

namespace Problem_9.Student_groups
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", this.FirstName, this.LastName, this.FN, this.Tel, this.Email,
                this.GroupNumber);
        }
    }
}
