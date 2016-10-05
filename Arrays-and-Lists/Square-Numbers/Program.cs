using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
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

            List<int> squares = new List<int>();

            foreach (int number in numbers)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    squares.Add(number);
                }
            }

            squares.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
