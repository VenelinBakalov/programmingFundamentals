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
            int[] numbers = Console.ReadLine().Split().Select(number => int.Parse(number)).ToArray();
            int length = numbers.Length / 4;

            int[] firstRowLeft = numbers
                            .Take(length)
                            .Reverse()
                            .ToArray();

            int[] firstRowRight = numbers
                            .Reverse()
                            .Take(length)
                            .ToArray();

            int[] firstRow = firstRowLeft.Concat(firstRowRight).ToArray();

            int[] secondRow = numbers
                            .Skip(length)
                            .Take(2 * length)
                            .ToArray();

            int[] sum = firstRow.Select((number, index) => number + secondRow[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
