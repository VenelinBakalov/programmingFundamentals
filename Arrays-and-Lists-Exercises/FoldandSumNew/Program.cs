using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldandSumNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            int k = input.Length / 4;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            
            int[] firstKElements = new int[k];
            int[] lastKElements = new int[k];

            for (int i = 0; i < k; i++)
            {
                firstKElements[i] = numbers[i];
                lastKElements[i] = numbers[3 * k + i];

            }

            Array.Reverse(firstKElements);
            Array.Reverse(lastKElements);

            int[] finalArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                finalArray[i] = firstKElements[i] + numbers[k + i];
                finalArray[k + i] = lastKElements[i] + numbers[2 * k + i];
            }

            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
