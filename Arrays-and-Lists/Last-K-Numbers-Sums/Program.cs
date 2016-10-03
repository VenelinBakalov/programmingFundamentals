using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int i = 1;  i < sequence.Length; i++)
            {
                long startPos = 0;
                if (startPos < i - k)
                {
                    startPos = i - k;
                }
                for (long j = startPos; j < i; j++)
                {
                    sequence[i] += sequence[j];
                }
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
