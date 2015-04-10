using System.Collections.Generic;

namespace SoftwareAcademy
{
    public class Course : ICourse
    {
        protected List<string> topics; 
        public string Name { get; set; }

        public Course()
        {
            this.topics = new List<string>();
        }
        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        //public override string ToString()
        //{
        //    return string.Format("{0} Name={1}; Teacher={2}; Topics=[{3}]; Lab=({4}); Town=({5})", this.GetType().Name,
        //        this.Name, this.Teacher.Name == null ? "" : this.Teacher.Name.ToString(), ListTopices(), this.);
        //}
        protected string ListTopices()
        {
            string coursesAsStr = string.Empty;
            var iterator = 0;
            foreach (var listCourse in this.topics)
            {
                if (iterator == this.topics.Count - 1)
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
