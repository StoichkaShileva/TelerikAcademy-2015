using System;

struct Point3D
{
    //Propeties
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    //Constructor
    public Point3D(double x, double y, double z):this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    //Override ToString()
    public override string ToString()
    {
        string result = string.Format("{0}; {1}; {2}", this.X, this.Y, this.Z);
        result = result + "}";
        result = "{" + result;
        return result;
    }
}
