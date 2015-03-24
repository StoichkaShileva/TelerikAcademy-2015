namespace constructors
{
    public class Car
    {
        private const string brandName = "Mercedes";
        private string engine;
        private int? hoursePower;
        private int? weight;

        private int ageP;
        public Car()
        {
            
        }

        public Car(string inputEngine, int? inputHP = null, int? inputWeight = null)
        {
            this.Engine = inputEngine;
            this.HoursePower = inputHP;
            this.Weight = inputWeight;
        }

        public Car(string inputEngine, int? inputHP = null)
            : this(inputEngine, inputHP, null)
        {   
        }

        public Car(string inputEngine)
            : this(inputEngine, null)
        {
            
        }
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int? HoursePower
        {
            get { return this.hoursePower; }
            set { this.hoursePower = value; }
        }

        public int? Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public static string BrandName
        {
            get { return brandName; }
        }

        public int AgeP
        {
            get { return this.ageP; }
            set { this.ageP = value; }
        }
    }
}