namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        public string Town { get; set; }
        public override string ToString()
        {
            return string.Format("{0} Name={1}; {2}; {3}; Town={4}", "OffsiteCourse:",
                this.Name, this.Teacher == null ? "" : "Teacher="+this.Teacher.Name.ToString() +";", this.topics == null || this.topics.Count == 0 ? "" : "Topics=[" + ListTopices() + "];", this.Town);
        }
    }
}
