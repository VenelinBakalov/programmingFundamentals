using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            int length = input.Length / 4;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int[] firstRow = new int[2 * length];
            int[] secondRow = new int[2 * length];

            for (int i = 0; i < length; i++)
            {
                firstRow[i] = numbers[length - 1 - i];
            }

            for (int i = 0; i < length; i++)
            {
                firstRow[length + i] = numbers[4 * length - 1 - i];
            }

            for (int i = 0; i < 2 * length; i++)
            {
                secondRow[i] = numbers[length + i];
            }
            /*
            int[] result = new int[firstRow.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }
            */
            for (int i = 0; i < 2 * length; i++)
            {
                Console.Write(firstRow[i] + secondRow[i] + " ");
            }
           // Console.WriteLine(string.Join(" ", result));
        }
    }
}
