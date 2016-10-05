using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            bool[] primes = new bool[range];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = false;
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (IsPrime(i))
                {
                    primes[i] = true;
                    
                }
            }


        }

        static bool IsPrime(int number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
