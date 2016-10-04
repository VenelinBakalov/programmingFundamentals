using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[];...........
            for (int i = 0; i < length; i++)
            {
                for (int j = i - 1; j >= 0 && j >= i-k ; j--)
                {
                    numbers[i] += numbers[j];
                }
            }
        }
    }
}
