namespace InheritancePart2
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher() : base(null,null)
        {
            
        }

        public Teacher(string subject)
            : base(null, null)
        {
            this.Subject = subject;
        }

        public Teacher(string name, string subject)
            : base(name)
        {
            this.Subject = subject;
        }
    }
}