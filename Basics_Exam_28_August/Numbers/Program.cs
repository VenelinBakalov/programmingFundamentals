using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;
            int numberToWrite = 0;

            for (int rows = 0; rows < firstDigit + secondDigit; rows++)
            {
                for (int cols = 0; cols < firstDigit + thirdDigit; cols++)
                {
                    if (number % 5 == 0)
                    {
                        numberToWrite = number - firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        numberToWrite = number - secondDigit;
                    }
                    else
                    {
                        numberToWrite = number + thirdDigit;
                    }
                    Console.Write(numberToWrite + " ");
                    number = numberToWrite;
                }
                Console.WriteLine();
            }
        }
    }
}
