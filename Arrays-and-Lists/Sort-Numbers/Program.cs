using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<double> numbers = new List<double>();

            foreach (string number in input)
            {
                numbers.Add(double.Parse(number));
            }

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
