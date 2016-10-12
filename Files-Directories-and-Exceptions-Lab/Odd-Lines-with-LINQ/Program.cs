using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Lines_with_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("Input.txt");

            File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));

        }
    }
}
