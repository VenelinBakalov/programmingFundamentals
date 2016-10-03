using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstArrayAsString = Console.ReadLine();
            string secondArrayAsString = Console.ReadLine();

            int[] firstNumbers = GetArray(firstArrayAsString);
            int[] secondNumbers = GetArray(secondArrayAsString);

            int[] resultArray = new int[GetMaxArray(firstNumbers, secondNumbers)];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstNumbers[i % firstNumbers.Length] + secondNumbers[i % secondNumbers.Length];
            }

            foreach (var number in resultArray)
            {
                Console.Write(number + " ");
            }
           

        }

        static int[] GetArray(string arrayAsString)
        {
            string[] firstArray = arrayAsString.Split(' ');
            int[] firstNumbers = new int[firstArray.Length];
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                firstNumbers[i] = int.Parse(firstArray[i]);
            }

            return firstNumbers;
        }

        static int GetMaxArray(int[] firstNumbers, int[] secondNumbers)
        {
            int maxArray = Math.Max(firstNumbers.Length, secondNumbers.Length);
            return maxArray;
        }
    }
}
