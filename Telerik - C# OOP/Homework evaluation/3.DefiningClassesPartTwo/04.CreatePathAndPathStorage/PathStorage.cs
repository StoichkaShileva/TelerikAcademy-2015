using System;
using System.Collections.Generic;
using System.IO;

static class PathStorage
{
    private const string Filepath = "path.txt";

    public static void Save(Path path)
    {
        using (StreamWriter savePath = new StreamWriter(Filepath))
        {
            for (int i = 0; i < path.Count; i++)
            {
                savePath.WriteLine("{{{0}; {1}; {2}}}", path[i].X, path[i].Y, path[i].Z);
            }
        }
    }
    public static void Load(Path path)
    {
        using (StreamReader loadPath = new StreamReader(Filepath))
        {
            Console.WriteLine(loadPath.ReadToEnd());
        }
    }
}
