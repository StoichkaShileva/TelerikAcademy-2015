using System;
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

class AddStaticReadonlyPoint0
{
    static void Main()
    {
        Point3D point = new Point3D(3.5, 6, 7.7);
        Console.WriteLine("{0}\n",point);

        Console.WriteLine(Point3D.StartPoint);
    }
}
