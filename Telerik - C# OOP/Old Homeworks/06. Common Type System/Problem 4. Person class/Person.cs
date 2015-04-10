namespace Problem_4.Person_class
{
    public class Person
    {
        private string name;
        private int? age;

        public Person()
        {
            this.Age = null;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return this.Name + " is " + ((this.Age == null) ? "no" : this.Age.ToString());
        }
    }
}
