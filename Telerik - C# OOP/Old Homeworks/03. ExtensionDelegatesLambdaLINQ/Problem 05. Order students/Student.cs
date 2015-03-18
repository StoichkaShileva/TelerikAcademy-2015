/*
  <<<<<>>>>> CONDITION <<<<<>>>>>
  @ Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
  @ Rewrite the same with LINQ.
*/
namespace Problem_5.Order_students
{
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