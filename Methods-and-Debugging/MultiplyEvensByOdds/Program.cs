using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiple = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(multiple);

        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            int multiple = sumOdds * sumEvens;
            return multiple;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumEvens = 0;
            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEvens += lastDigit;
                }
                number /= 10;
            }
            return sumEvens;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOdds = 0;
            while (Math.Abs(number) >0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdds += lastDigit;
                }
                number /= 10;
            }
            return sumOdds;
        }
    }
}
