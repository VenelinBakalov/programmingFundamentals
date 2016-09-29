using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int divider = 2; divider <= Math.Sqrt(number); divider++)
            {
                if (number % divider == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
