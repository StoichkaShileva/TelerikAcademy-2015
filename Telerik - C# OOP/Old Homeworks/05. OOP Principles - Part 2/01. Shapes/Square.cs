using System;

namespace _01.Shapes
{
    public class Square : Shape
    {

        public Square(double inputWidth, double inputHeight)
        {
            if (inputHeight != inputWidth)
            {
                throw new ArgumentOutOfRangeException("Width must be equal to height!");
            }
            else
            {
                base.Name = "Square";
                base.Width = inputWidth;
                base.Height = inputHeight;
            }
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }
    }
}