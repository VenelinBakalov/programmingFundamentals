using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            int[] numbers = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }

            for (int indexA = 1; indexA < numbers.Length; indexA++)
            {
                for (int indexB = 0; indexB < indexA; indexB++)
                {
                    if (numbers[indexA] == numbers[indexA-1] + numbers[indexB])
                    {
                        Console.WriteLine("{0} + {1} == {2}", numbers[indexA-1], numbers[indexB], numbers[indexA]);
                    }
                }
            }
        }
    }
}
