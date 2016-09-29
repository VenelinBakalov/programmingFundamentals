using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            PrintPrimeNumbers(startNumber, endNumber);
        }

        static void PrintPrimeNumbers(int startNumber, int endNumber)
        {
            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
            {
                bool isPrime = IsPrime(currentNumber);
                if (isPrime)
                {
                    Console.Write(currentNumber);
                    for (int i = currentNumber + 1; i <= endNumber; i++)
                    {
                        isPrime = IsPrime(i);
                        if (isPrime)
                        {
                            Console.Write(", " + i);
                        }
                    }
                    break;
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int number)
        {
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
