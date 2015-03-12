namespace Structure
{
    using System;
    using System.Collections.Generic;
    public class Path
    {
        private List<int> sequenceOfPoints;

        public Path()
        {
            this.sequenceOfPoints = new List<int>();
        }
        public void AddPoint(int value)
        {
            this.sequenceOfPoints.Add(value);
        }

        public List<int> GetPoints()
        {
            return this.sequenceOfPoints;
        }

    }
}
