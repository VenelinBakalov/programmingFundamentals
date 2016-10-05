using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(number => int.Parse(number)).ToList();

            List<int> numbersReordered = numbers
                                            .OrderByDescending(number => number)
                                            .Take(3)
                                            .ToList();

            Console.WriteLine(string.Join(" ", numbersReordered));
        }
    }
}
