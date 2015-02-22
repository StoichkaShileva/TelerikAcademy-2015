using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Comparing_Floats
{
    class CompareFloats
    {
        static void Main(string[] args)
        {
            float numA = 5.3F;
            float numB = 6.01F;
            bool compare = (numA == numB);
            Console.WriteLine(compare);

            float numC = 5.00000001F;
            float numD = 5.00000003F;
            bool compareB = (numC == numD);
            Console.WriteLine(compareB);

            float numE = 5.00000005F;
            float numF = 5.00000001F;
            bool compareC = (numE == numF);
            Console.WriteLine(compareC);

            float numG = -4.999999F;
            float numH =  -4.999998F;
            bool compareD = (numG == numH);
            Console.WriteLine(compareD);

            float numI = 4.999999F;
            float numJ = 4.999998F;
            bool compareE = (numI == numJ);
            Console.WriteLine(compareE);
        }
    }
}
