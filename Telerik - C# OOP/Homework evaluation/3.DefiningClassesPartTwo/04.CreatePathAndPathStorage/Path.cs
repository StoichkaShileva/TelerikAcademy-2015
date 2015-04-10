using System;
using System.Collections.Generic;
using System.Text;

class Path
{
    private List<Point3D> list = new List<Point3D>();

    public Point3D this[int index]
    {
        get
        {
            if (index >= 0 && index < list.Count)
            {
                return list[index];
            }
            else throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < list.Count)
            {
                list[index] = value;
            }
            else throw new IndexOutOfRangeException();
        }
    }
    public int Count
    {
        get
        {
            return this.list.Count;
        }
    }

    public Path()
    {
        
    }

    public void AddPoint(Point3D point)
    {
        list.Add(point);
    }

    public string ShowPoints()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in list)
        {
            sb.AppendLine(item.ToString());
        }
        return sb.ToString();
    }
}
