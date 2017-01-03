using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = "(\\D+)(\\d+)";

            StringBuilder output = new StringBuilder();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string symbols = match.Groups[1].ToString();
                int count = int.Parse(match.Groups[2].ToString());

                for (int i = 0; i < count; i++)
                {
                    output.Append(symbols);
                }
            }

            int uniqueSymbols = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(output);
        }
    }
}
