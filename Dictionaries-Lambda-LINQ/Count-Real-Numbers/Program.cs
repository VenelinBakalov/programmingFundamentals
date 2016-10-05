using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (string numberString in numbers)
            {
                double number = double.Parse(numberString);
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count[number] = 1;
                }
            }

            foreach (KeyValuePair<double, int> pair in count)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
