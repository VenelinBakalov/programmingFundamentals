using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string pattern = @"<a.*?href.*?(""\S*"")>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(input, pattern, replace);

                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}
