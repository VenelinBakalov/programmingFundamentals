using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = GetArray(input);

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]} }}");
            }
        }

        static int[] GetArray(string[] input)
        {
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            return numbers;
        }
    }
}
