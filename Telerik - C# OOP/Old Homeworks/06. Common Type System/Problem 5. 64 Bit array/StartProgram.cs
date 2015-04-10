/*
 Define a class BitArray64 to hold 64 bit values inside an ulong value.
 Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */

using System;

namespace Problem_5._64_Bit_array
{
    public class StartProgram
    {
        public static void Main()
        {
            ulong num = 1112;
            BitArray64 bits = new BitArray64(num);
            BitArray64 bits2 = new BitArray64(222222);
            Console.WriteLine("Printing bits for number [{0}]", num);
            foreach (var bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Hashcode: {0}", bits.GetHashCode());
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("First obj equals second (result) -->");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine(bits.Equals(bits2));
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("BitArray ToString() ->");
            Console.WriteLine(bits.ToString());

        }
    }
}
