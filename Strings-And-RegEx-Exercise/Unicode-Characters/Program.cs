using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string unicode = GetUnicode(input);
            Console.WriteLine(unicode);
        }

        private static string GetUnicode(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.AppendFormat("\\u{0:x4}", (uint)c);
            }
            string unicode = sb.ToString();
            return unicode;
        }
    }
}
