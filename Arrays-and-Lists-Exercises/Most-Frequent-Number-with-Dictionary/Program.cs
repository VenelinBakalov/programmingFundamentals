using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number_with_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (string number in input)
            {
                if (!count.ContainsKey(number))
                {
                    count.Add(number, 0);
                }
                count[number]++;
            }

            string result = count.OrderByDescending(num => num.Value).FirstOrDefault().Key;

            Console.WriteLine(result);

        }
    }
}
