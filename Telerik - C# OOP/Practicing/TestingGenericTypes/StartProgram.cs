using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TestingGenericTypes
{
    class SortedNums<T>
    {
        private int DequeCapacity;
        private int[] sortedNumsArr;
        public SortedNums(int capacity)
        {
            CapacitySet = capacity;
        }
        private int CapacitySet
        {
            set
            {
                if (value > 0 && value < int.MaxValue)
                    this.DequeCapacity = value;
            }
        }

    }
    class StartProgram
    {
        static void Main(string[] args)
        {
            SortedNums<int> numsSorted = new SortedNums<int>(30);

        }
    }
}
