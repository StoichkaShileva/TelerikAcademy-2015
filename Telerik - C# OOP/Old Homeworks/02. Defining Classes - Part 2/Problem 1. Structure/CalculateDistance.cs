namespace Structure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class CalculateDistance
    {
        public static int Distance(int firstPoint, int secondPoint)
        {
            if (firstPoint >= secondPoint)
            {
                return firstPoint - secondPoint;
            }
            else
            {
                return secondPoint - firstPoint;
            }
        }
    }
}
