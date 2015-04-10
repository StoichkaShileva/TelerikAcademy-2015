using System.Collections;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        public string Name { get; set; }
        private ICollection<ICourse> courses;

        public Teacher()
        {
            this.courses = new List<ICourse>();
        }
        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }

        public override string ToString()
        {
            return string.Format("Teacher: Name={0} {1}", this.Name, this.courses == null || this.courses.Count == 0 ? "" : "Courses=["+ListCourses()+"]");
        }

        private string ListCourses()
        {
            string coursesAsStr = string.Empty;
            var iterator = 0;
            foreach (var listCourse in this.courses)
            {
                if (iterator == this.courses.Count - 1)
                {
                    coursesAsStr += listCourse;
                }
                else
                {
                    coursesAsStr += listCourse + ", ";
                }
                iterator += 1;
            }
            return coursesAsStr;
        }
    }
}
