
using System.Collections.Generic;

namespace Problem_18.Grouped_by_GroupNumber
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
