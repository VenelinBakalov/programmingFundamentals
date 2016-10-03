using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            List<int> results = new List<int>();


            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] singleArrayAsString = input[i].Split(' ');

                for (int j = 0; j < singleArrayAsString.Length; j++)
                {
                    if (singleArrayAsString[j] != "")
                    {
                    results.Add(int.Parse(singleArrayAsString[j]));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
