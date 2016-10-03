using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            double[] numbers = new double[items.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(items[i]);
            }

            int[] roundedNums = new int[items.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} -> {roundedNums[i]}");
            }
        }
    }
}
