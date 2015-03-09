using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            string redPositions = Console.ReadLine();
            string bluePositions = Console.ReadLine();
            int[,,] surface = new int[dimensions[0],dimensions[1],dimensions[2]];
            //1 - red
            //2 - blue


        }
    }
}
