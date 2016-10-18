using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];

            int result = GetMultipliedSumOfChars(firstString, secondString);

            Console.WriteLine(result);
        }

        private static int GetMultipliedSumOfChars(string firstString, string secondString)
        {
            int sum = 0;

            if (firstString.Length >= secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }

                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }

                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }

            return sum;
        }
    }
}
