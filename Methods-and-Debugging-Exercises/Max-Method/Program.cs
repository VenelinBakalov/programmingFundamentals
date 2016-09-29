using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int firstMax = GetMax(firstNumber, secondNumber);
            int maxNumber = GetMax(firstMax, thirdNumber);

            PrintMax(maxNumber);
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = Math.Max(firstNumber, secondNumber);
            return maxNumber;
        }

        static void PrintMax(int maxNumber)
        {
            Console.WriteLine(maxNumber);
        }
    }
}
