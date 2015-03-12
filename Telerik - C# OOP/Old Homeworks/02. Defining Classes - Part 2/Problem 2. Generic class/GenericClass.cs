namespace Generic_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GenericClass<T> where T : IComparable
    {
        private int capacity;
        private T[] elements;
        private int index;
        public GenericClass(int capacityInput)
        {
            this.elements = new T[Capacity = capacityInput];
            this.Capacity = this.elements.Length;
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Capacity must be more than 0 and less than {0}", int.MaxValue));
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public void AddElement(T element)
        {
            if (!elements[Capacity - 1].Equals(default(T)))
            {
                ResizeArray();
            }
            this.elements[index] = element;
            this.index++;
        }

        public void RemoveElementAt(int index)
        {
            if (index > this.elements.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("Index must be between 1 and {0} !", this.capacity));
            }
            T[] current = new T[capacity - 1];
            for (int i = 0; i < index; i++)
            {
                current[i] = this.elements[i];
            }
            for (int i = index; i < this.elements.Length - 1; i++)
            {
                current[i] = this.elements[i + 1];
            }
            this.index--;
            this.Capacity = this.elements.Length;
            this.elements = current;
        }

        public void InsertElementAt(int index, T value)
        {
            if (index > this.elements.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("Index must be between 1 and {0} !", this.capacity));
            }
            if (!elements[Capacity - 1].Equals(default(T)))
            {
                ResizeArray();
            }
            this.Capacity += 1;
            T[] current = new T[capacity];
            for (int i = 0; i < capacity; i++)
            {
                if (i != index && i < capacity - 1)
                {
                    current[i] = this.elements[i];
                }
                else if (i == index)
                {
                    current[i] = value;
                }
            }
            this.index = index + 1;
            this.Capacity = this.elements.Length;
            this.elements = current;
        }

        public int FindElement(T val)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(val))
                {
                    return i;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }

        public void ClearList()
        {
            while (this.Capacity != 0)
            {
                this.RemoveElementAt(0);
            }
            this.Capacity = 0;
        }
        public T this[int index]
        {
            get
            {
                if (index < this.elements.Length && index > 0)
                {
                    return elements[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Format("Index must be between 1 and {0} !", this.capacity));
                }
            }
        }

        private void ResizeArray()
        {
            int newCapacity = Capacity * 2;
            T[] current = new T[newCapacity];
            for (int i = 0; i < this.elements.Length; i++)
            {
                current[i] = this.elements[i];
            }
            this.elements = current;
            this.Capacity *= 2;
        }

        public T Min()
        {
            T minVal = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements.Length.CompareTo(minVal) < 0)
                    minVal = this.elements[i];
            }
            return minVal;
        }

        public T Max()
        {
            T maxVal = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements.Length.CompareTo(maxVal) > 0)
                    maxVal = this.elements[i];
            }
            return maxVal;
        }

        public override string ToString()
        {
            string current = string.Empty;
            for (int i = 0; i < this.elements.Length; i++)
            {
                current += elements[i] + " ";
            }
            return current;

        }

    }
}
