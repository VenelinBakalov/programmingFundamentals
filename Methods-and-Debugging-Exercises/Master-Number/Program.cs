using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endNumber; i++)
            {
                if (IsPalindrome(i) && IsSumOfDigitsIsDivisibleBySeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberAsString = number.ToString();
            for (int i = 0; i <= numberAsString.Length - 1; i++)
            {
                if (numberAsString[i] != numberAsString[numberAsString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;


            /*string mirrorNumber = "";
            for (int i = numberAsString.Length-1; i >= 0; i--)
            {
                mirrorNumber += numberAsString[i];
            }
            if (mirrorNumber == numberAsString)
            {
                return true;
            }
            return false;*/
        }

        static bool IsSumOfDigitsIsDivisibleBySeven(int number)
        {
            int sumOfDigits = 0;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ContainsEvenDigit(int number)
        {
            string numberAsString = number.ToString();
            for (int i = 0; i <= numberAsString.Length - 1; i++)
            {
                if (numberAsString[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
            /*while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;*/
        }
    }
}
