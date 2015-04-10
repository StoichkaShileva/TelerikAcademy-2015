namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    class TestBehavior
    {
        static void Main()
        {
            List<Shape> arrayFromShapes = new List<Shape>();
            arrayFromShapes.Add(new Rectangle()
            {
                Height = 10,
                Width = 20
            });
            arrayFromShapes.Add(new Square(10, 10));
            arrayFromShapes.Add(new Triangle()
            {
                Height = 13,
                Width = 42
            });
            foreach (var arrayFromShape in arrayFromShapes)
            {
                Console.WriteLine("Surface of a {0} with width {1} and height {2} is {3}", arrayFromShape.Name, arrayFromShape.Width, arrayFromShape.Height, arrayFromShape.CalculateSurface());
            }
        }
    }
}