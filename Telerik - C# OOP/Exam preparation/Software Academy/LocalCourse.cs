namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        public string Lab { get; set; }
        public override string ToString()
        {
            return string.Format("{0} Name={1}; {2} {3} Lab={4}", 
                "LocalCourse:",
                this.Name, this.Teacher == null ? "" : "Teacher="+this.Teacher.Name.ToString()+";", this.topics == null || this.topics.Count == 0 ? "" : "Topics=[" + ListTopices() + "];", this.Lab);
        }
    }
}
