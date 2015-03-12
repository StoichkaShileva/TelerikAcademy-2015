

namespace Structure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;
        private static readonly int[] O = { 0, 0, 0 };

        public Point3D(int xCoordinage, int yCoordinate, int zCoordinate)
            : this()
        {
            this.X = xCoordinage;
            this.Y = yCoordinate;
            this.Z = zCoordinate;

        }

        public int X
        {
            get { return this.x; }
            set
            {
                if (IsValidData(value, int.MinValue, int.MaxValue))
                {
                    this.x = value;
                }
            }
        }

        public int Y
        {
            get { return this.y; }
            set
            {
                if (IsValidData(value, int.MinValue, int.MaxValue))
                {
                    this.y = value;
                }
            }
        }
        public int Z
        {
            get { return this.z; }
            set
            {
                if (IsValidData(value, int.MinValue, int.MaxValue))
                {
                    this.z = value;
                }
            }
        }

        public static int[] ReturnO
        {
            get { return O; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.x, this.y, this.z);
        }

        private bool IsValidData(int val, int min, int max)
        {
            if (val > min && val < max)
                return true;
            else
                return false;
        }
    }
}
