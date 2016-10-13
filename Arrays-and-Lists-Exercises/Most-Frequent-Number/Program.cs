using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxNumber = 0;
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumberCount = 1;
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
            Console.WriteLine(maxNumber);
        }

    }
}
