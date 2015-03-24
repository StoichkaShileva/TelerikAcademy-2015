using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTest
{
    public interface Draw<T>
    {
        void Draw();
        List<T> Sort(List<T> collection);
    }

    public class Diff<T>: Draw<T>
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public List<T> Sort(List<T> collection)
        {
            List<T> l = new List<T>();
            collection.ForEach(el => l.Add(el));
            l.Sort();
            return l;
        }
    }
    class StartProgram
    {
        static void Main()
        {
            Diff<int> nums = new Diff<int>();
            var result = nums.Sort(new List<int>()
            {
                4,
                2,
                67,
                12,
                3,
                655,
                3,
                3,
                5,
                6,
                3,
                11,
                3,
                2
            });
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
