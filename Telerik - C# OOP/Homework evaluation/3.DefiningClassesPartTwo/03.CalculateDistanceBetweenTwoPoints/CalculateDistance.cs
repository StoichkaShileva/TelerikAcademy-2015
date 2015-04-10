using System;

static class CalculateDistance
{
    public static double FindDistance(Point3D firstPoint, Point3D secondPoint)
    {
        double x1 = firstPoint.X;
        double y1 = firstPoint.Y;
        double z1 = firstPoint.Z;

        double x2 = secondPoint.X;
        double y2 = secondPoint.Y;
        double z2 = secondPoint.Z;

        double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));//Euclidean distance
        return result; 
    }
}
