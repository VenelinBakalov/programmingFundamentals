using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = new char[26];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)('a' + i);
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " -> " + Array.IndexOf(arr, word[i]));
            }
        }
    }
}
