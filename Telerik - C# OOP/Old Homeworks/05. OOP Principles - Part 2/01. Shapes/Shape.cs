namespace _01.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;
        private string name;


        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public abstract double CalculateSurface();
    }
}
