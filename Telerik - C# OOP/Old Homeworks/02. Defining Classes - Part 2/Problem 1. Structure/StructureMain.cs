/*
Problem 1. Structure

Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
Problem 2. Static read-only field

Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.
Problem 3. Static class

Write a static class with a static method to calculate the distance between two points in the 3D space.
Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.
 */

namespace Structure
{
    using System;
    class StructureTask
    {
        static void Main()
        {
            Point3D point = new Point3D(20, 30, 1);
            int xPoint = point.X;
            int yPoint = point.Y;
            Console.WriteLine(point);
            int[] oPoints = Point3D.ReturnO;
            Console.WriteLine(string.Join(", ", oPoints));
            int distance = CalculateDistance.Distance(xPoint, yPoint);
            Console.WriteLine(distance);
            Path valsPath = new Path();
            valsPath.AddPoint(5);
            valsPath.AddPoint(12);
            valsPath.AddPoint(444);
            PathStorage.SavePath(valsPath.GetPoints());
        }
    }
}
