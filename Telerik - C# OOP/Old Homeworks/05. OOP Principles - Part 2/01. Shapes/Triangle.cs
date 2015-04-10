namespace _01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle()
        {
            base.Name = "Triangle";
        }

        public override double CalculateSurface()
        {
            return (base.Height * base.Width) / 2;
        }
    }
}