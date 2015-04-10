namespace Exercises
{
    using System.Collections.Generic;
    using Exercises.Interfaces;
    public class Class : School, IClass
    {
        private List<IStudent> students;
        private List<ITeacher> teachers;

        public List<IStudent> Students
        {
            get { return this.students; }
        }

        public List<ITeacher> Teachers
        {
            get { return this.teachers; }
        }

        public string UniqueTextID { get; set; }
    }
}
