using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',', ':', ';', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ');

            List<string> lowercaseWords = new List<string>();
            List<string> mixedcaseWords = new List<string>();
            List<string> uppercaseWords = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int lowercase = 0;
                int uppercase = 0;
                int symbols = 0;
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] >= 97 && input[i][j] <= 122)
                    {
                        lowercase++;
                    }
                    else if (input[i][j] >= 65 && input[i][j] <= 90)
                    {
                        uppercase++;
                    }
                    else
                    {
                        symbols++;
                    }
                }
                if (lowercase == 0 && uppercase > 0 && symbols == 0)
                {
                    uppercaseWords.Add(input[i]);
                }
                else if (lowercase > 0 && uppercase == 0 && symbols == 0)
                {
                    lowercaseWords.Add(input[i]);
                }
                else if (lowercase >= 0 && uppercase >= 0 && symbols >= 0)
                {
                    mixedcaseWords.Add(input[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedcaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseWords));
        }
    }
}
