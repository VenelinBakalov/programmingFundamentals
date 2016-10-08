using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers_New
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string number = numbers[i];
                string reversedNumbersAsString = StringReverse(number);
                int reversedNumber = int.Parse(reversedNumbersAsString);
                reversedNumbers.Add(reversedNumber);
            }

            int sum = reversedNumbers.Sum();
            Console.WriteLine(sum);

        }

        private static string StringReverse(string number)
        {
            char[] array = number.ToCharArray();
            char[] reversedArray = array.Reverse().ToArray();
            string reversedString = string.Join("", reversedArray);
            return reversedString;
        }
    }
}
