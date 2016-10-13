using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFilePath = @"input.txt";
            const string outputFilePath = @"output.txt";

            int[] numbers = File.ReadAllText(inputFilePath).Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];
                }
                for (int right = i + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                if (leftSum.Equals(rightSum))
                {
                    File.WriteAllText(outputFilePath, i.ToString());
                    return;
                }
            }
            File.WriteAllText(outputFilePath, "no");
        }
    }
}
