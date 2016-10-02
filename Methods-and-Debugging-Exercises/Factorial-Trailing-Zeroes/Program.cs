using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(number);
            int zeroes = GetZeroes(factorial);
            PrintResult(zeroes);
        }

        static BigInteger GetFactorial (int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int GetZeroes (BigInteger factorial)
        {
            int zeroes = 0;
            while (factorial % 10 == 0)
            {
                zeroes++;
                factorial /= 10;
            }
            return zeroes;
        }

        static void PrintResult(int zeroes)
        {
            Console.WriteLine(zeroes);
        }
    }
}
