using System;
//Write a static class with a static method to calculate the distance between two points in the 3D space.

class Program
{
    static void Main()
    {
        Point3D point1 = new Point3D(3.5, 6, 7.7);
        Point3D point2 = new Point3D(7, 10, 17.3);

        Console.WriteLine(CalculateDistance.FindDistance(point1, point2));//Between two points
        Console.WriteLine(CalculateDistance.FindDistance(Point3D.StartPoint, point2));//Between the startPoint(0,0,0) and point2
    }
}
