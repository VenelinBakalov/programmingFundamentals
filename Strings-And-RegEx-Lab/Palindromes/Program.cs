using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', ',', '.', '?', '!' };

            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string reversed = new string(words[i].Reverse().ToArray());

                if (words[i].Equals(reversed))
                {
                    palindromes.Add(reversed);
                }
            }

            List<string> ordered = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", ordered));

        }
    }
}
