using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int rotations = int.Parse(Console.ReadLine());

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int[] rotatedArray = new int[numbers.Length];
                rotatedArray[0] = numbers[numbers.Length - 1];

                for (int j = 1; j < numbers.Length; j++)
                {
                    rotatedArray[j] = numbers[j - 1];
                }

                for (int k = 0; k < numbers.Length; k++)
                {
                    sum[k] += rotatedArray[k];
                }

                numbers = rotatedArray;
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
