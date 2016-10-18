using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder sb = new StringBuilder();

            while (!number.Equals(0))
            {
                BigInteger remainder = number % baseN;
                number = number / baseN;

                sb.Insert(0, remainder);
            }

            string result = sb.ToString();

            Console.WriteLine(result);
        }
    }
}
