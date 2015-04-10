using System;
//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file. 
//Use a file format of your choice.

class Program
{
    static void Main()
    {
        Path path = new Path();
        path.AddPoint(new Point3D(6, 6, 6));
        path.AddPoint(new Point3D(7, 7, 7));
        path.AddPoint(new Point3D(2, 2, 2));

        //path[1] = new Point3D(9, 9, 9);

        PathStorage.Save(path);
        PathStorage.Load(path);
    }
}
