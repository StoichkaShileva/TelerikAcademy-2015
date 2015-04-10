using System;
using System.Reflection;
//Create a [Version] attribute that can be applied to structures, classes, interfaces, 
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
//Apply the version attribute to a sample class and display its version at runtime.

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D();
            Type type = typeof(Point3D);

            object[] attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attributes)
            {
                Console.WriteLine("{0}: {1}", item, item.Version);
            }
        }
    }
}