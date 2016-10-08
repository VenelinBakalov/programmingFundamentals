using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int reversed = 0;
                while (numbers[i] > 0)
                {
                    int lastDigit = numbers[i] % 10;
                    reversed = reversed * 10 + lastDigit;
                    numbers[i] /= 10;
                }
                sum += reversed;
            }

            Console.WriteLine(sum);
        }
    }
}
