namespace constructors
{
    public class AnotherClass : Car
    {
        private int carAge;

        public int CarAge
        {
            get { return carAge; }
            set
            {
                base.AgeP = value;
                this.carAge = value;
            }
        }
    }
}