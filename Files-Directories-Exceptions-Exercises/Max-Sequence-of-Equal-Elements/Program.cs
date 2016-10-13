using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFilePath = @"..\..\input.txt";
            const string outputFilePath = @"..\..\output.txt";

            int[] input = File.ReadAllText(inputFilePath).Split().Select(int.Parse).ToArray();

            int maxSequence = 0;
            int bestStart = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentSequence = 1;
                int pos = i + 1;
                while (pos <= input.Length - 1 && input[i].Equals(input[pos]))
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

            File.WriteAllText(outputFilePath, "");

            for (int i = 1; i <= maxSequence; i++)
            {
                File.AppendAllText(outputFilePath, $"{bestStart} ");
            }
        }
    }
}
