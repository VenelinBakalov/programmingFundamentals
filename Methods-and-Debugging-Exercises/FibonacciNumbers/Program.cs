using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int fibonacciNumber = GetFibonacciNumber(count);
            PrintNumber(fibonacciNumber);
        }

        static int GetFibonacciNumber(int count)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int fibonacciNumber = 1;
            for (int i = 0; i < count; i++)
            {

                fibonacciNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibonacciNumber;
            }
            return fibonacciNumber;
        }

        static void PrintNumber(int fibonacciNumber)
        {
            Console.WriteLine(fibonacciNumber);
        }
    }
}
