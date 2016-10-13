using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequence = 0;
            int bestStart = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentSequence = 1;
                int pos = i + 1;
                while (input[i].Equals(input[pos]) && pos < input.Length - 1)
                {
                    currentSequence++;
                    pos++;
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    bestStart = input[i];
                }
            }
            for (int i = 1; i <= maxSequence; i++)
            {
                Console.Write($"{bestStart} ");
            }
            Console.WriteLine();
        }
    }
}
