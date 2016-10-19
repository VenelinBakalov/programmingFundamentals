using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\s([0-9A-Za-z]+(-*|_*|\.*)[0-9a-zA-Z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";

            Regex regexCheck = new Regex(pattern);

            MatchCollection matches = regexCheck.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
            
        }
    }
}
