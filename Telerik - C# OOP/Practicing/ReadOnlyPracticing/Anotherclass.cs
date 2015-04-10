namespace ReadOnlyPracticing
{
    public class Anotherclass
    {
        public readonly string name;

        protected internal string Smth { get; set; }

        public Anotherclass()
        {
            this.Smth = "SSSS";
        }
        public Anotherclass(string inputName)
        {
            this.name = inputName;
            this.Smth = "SSSS";
        }

        public string Name
        {
            get { return this.name; }
        }

        public static int SpecialNum
        {
            get { return 5; }
        }
    }
}
