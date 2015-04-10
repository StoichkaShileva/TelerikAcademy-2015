namespace Problem_5._64_Bit_array
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class BitArray64 : IEnumerable
    {
        public ulong Value { get; set; }

        public BitArray64(ulong value)
        {
            this.Value = value;
        }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException();
                }

                return (byte)((this.Value >> index) & 1);
            }

            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value > 1 || value < 0)
                {
                    throw new ArgumentException();
                }

                if (value == 0)
                {
                    this.Value = this.Value & (ulong)(~(1 << index));
                }
                else
                {
                    this.Value = this.Value | (ulong)(1 << index);
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;
            if (temp.Value == this.Value)
                return true;
            return false;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode()*7;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return (int)this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}