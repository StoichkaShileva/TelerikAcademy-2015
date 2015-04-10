using System;
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.

class StructurePoint3D
{
    static void Main()
    {
        Point3D point = new Point3D(3.5, 6, 7.7);
        Console.WriteLine(point);
    }
}
