using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");
            File.WriteAllText("output.txt", "");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt",
                                        $"{i + 1}. {text[i]}{Environment.NewLine}");
            }
        }
    }
}
