namespace Problem_1.Student_class
{
    public class Course
    {
        private string courseName;

        public Course(string courseName)
        {
            this.courseName = courseName;
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
    }
}
