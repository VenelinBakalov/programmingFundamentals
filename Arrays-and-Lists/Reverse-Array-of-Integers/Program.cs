using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] integers = new int[number];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = integers.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ",integers[i]);
            }
            Console.WriteLine();
        }
    }
}
