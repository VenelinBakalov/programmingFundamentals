using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", letters[i], (int)letters[i] - 97);
            }
        }
    }
}
