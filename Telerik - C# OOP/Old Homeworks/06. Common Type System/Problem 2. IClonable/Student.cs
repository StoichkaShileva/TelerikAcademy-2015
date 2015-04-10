using System;

namespace Problem_2.IClonable
{
    public class Student : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private string gender;

        public Student()
        {
            this.Name = string.Empty;
            this.Age = 0;
            this.Gender = "male";
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                    throw new ArgumentException("Gender must be 'female' or 'male'!");
                else
                    this.gender = value;
            }
        }

        public object Clone()
        {
            Student copiedStudent = new Student()
            {
                Name =  this.Name,
                Age = this.Age,
                Gender = this.Gender
            };
            return copiedStudent;
        }
    }
}
