using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
namespace findBits
{
        
    class Program
    {
        public static BigInteger CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            BigInteger count = 0;
            long i = 0;
            while ((i = text.IndexOf(pattern, (int)i)) != (long)-1)
            {
                i++;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            BigInteger s = BigInteger.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            long[] nums = new long[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }
            string sInBinary = Convert.ToString((int)s, 2).PadLeft(29, '0');
            string searchingNum = sInBinary.Substring(sInBinary.Length - 5, 5);
            //Console.WriteLine(sInBinary);
            BigInteger occurrences = 0;
            List<string> numsAsBinary = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                string currentInBinary = Convert.ToString(nums[i], 2).PadLeft(29, '0');
                //string currentSub = currentInBinary.Substring(currentInBinary.Length - 5, 5);
                numsAsBinary.Add(currentInBinary);
            }
            BigInteger strIndex = 0;
            int strNumber;
            BigInteger fCount = 0;
            for (strNumber = 0; strNumber < numsAsBinary.Count; strNumber++)
            {
                fCount += CountStringOccurrences(numsAsBinary[strNumber], searchingNum);
            }
            Console.WriteLine(fCount);
        }
    }
}
