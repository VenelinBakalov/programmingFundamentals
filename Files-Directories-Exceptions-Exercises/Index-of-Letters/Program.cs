using System;
using System.IO;
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
            string letters = File.ReadAllText("Input.txt");
            File.WriteAllText("Output.txt", "");

            for (int i = 0; i < letters.Length; i++)
            {
                File.AppendAllText("Output.txt", $"{letters[i]} -> {letters[i] - 'a'}{Environment.NewLine}");
            }
        }
    }
}
