using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputAsArray = input.Split(' ');

            for (int i = 0; i < inputAsArray.Length / 2; i++)
            {
                SwapElements(inputAsArray, i, inputAsArray.Length - 1 - i);
            }

            Console.WriteLine(string.Join(" ", inputAsArray));
        }

        static void SwapElements(string[] arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }
    }
}
