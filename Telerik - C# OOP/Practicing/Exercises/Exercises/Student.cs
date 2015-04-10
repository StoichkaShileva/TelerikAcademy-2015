namespace Exercises
{
    public class Student : Class, IStudent
    {
        private string name;
        private string uniqueID;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string UniqueID
        {
            get { return this.uniqueID; }
            set { this.uniqueID = value; }
        }
    }
}
