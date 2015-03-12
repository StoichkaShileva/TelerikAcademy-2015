namespace Structure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(List<int> path)
        {
            StreamWriter write = new StreamWriter("../../savedPaths.txt", true);
            using (write)
            {
                foreach (var i in path)
                {
                    write.Write(i + " ");
                }
                write.WriteLine();
            }
        }
        public static List<int> LoadPath()
        {
            StreamReader read = new StreamReader("../../savedPaths.txt");
            List<int> paths = new List<int>();
            using (read)
            {
                string current = read.ReadLine();
                while (current != null)
                {
                    int[] currentVals = current.Split(' ').Select(int.Parse).ToArray();
                    foreach (var currentVal in currentVals)
                    {
                        paths.Add(currentVal);
                    }
                }
            }
            return paths;
        }
    }
}
