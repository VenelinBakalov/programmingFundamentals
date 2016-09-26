using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                int digitsSum = 0;
                int number = i;
                while (number != 0)
                {
                    digitsSum += number % 10;
                    number /= 10;
                }
                bool isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
