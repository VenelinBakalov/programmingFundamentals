using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            int[] numbers = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }
            bool empty = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int n = 0; n < j; n++)
                    {
                        if (numbers[i] == numbers[j] + numbers[n])
                        {
                            Console.WriteLine($"{numbers[n]} + {numbers[j]} == {numbers[i]}");
                            empty = false;
                        }
                        else if (numbers[j] == numbers[i] + numbers[n])
                        {
                            Console.WriteLine($"{numbers[n]} + {numbers[i]} == {numbers[j]}");
                            empty = false;
                        }
                        else if (numbers[n] == numbers[i] + numbers[j])
                        {
                            Console.WriteLine($"{numbers[j]} + {numbers[i]} == {numbers[n]}");
                            empty = false;
                        }
                        else if (numbers[n] == numbers[i] + numbers[n])
                        {
                            Console.WriteLine($"{numbers[n]} + {numbers[i]} == {numbers[n]}");
                            empty = false;
                        }
                    }
                }
            }

            if (empty)
            {
                Console.WriteLine("No");
            }
        }
    }
}
