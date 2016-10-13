using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();

            File.WriteAllText("Output.txt", "");

            int maxNumber = 0;
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumberCount = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentNumberCount++;
                    }
                }
                if (currentNumberCount > maxCount)
                {
                    maxCount = currentNumberCount;
                    maxNumber = numbers[i];
                }
            }

            File.AppendAllText("Output.txt", maxNumber.ToString());
        }
    }
}
