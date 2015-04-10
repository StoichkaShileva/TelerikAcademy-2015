namespace _01.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            base.Name = "Rectangle";
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }
    }
}