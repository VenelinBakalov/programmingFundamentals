using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<int> numbers = new List<int>();

            foreach (string number in input)
            {
                numbers.Add(int.Parse(number));
            }

            numbers.Sort();

            int position = 0;

            while (position < numbers.Count)
            {
                int number = numbers[position];
                int count = 1;
                while (position + count < numbers.Count && numbers[position + count] == number)
                {
                    count++;
                }
                position += count;
                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}

