using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = $@"(({word}[^a-zA-Z0-9]|(\w+[^a-zA-Z0-9!\.\?!]*[^a-zA-Z0-9]))+{word}([^a-zA-Z0-9]\w+[^a-zA-Z0-9!\.\?!]*)+)(\.|!|\?)";

            Regex regex = new Regex(pattern);
            MatchCollection collection = regex.Matches(text);

            foreach (Match sentence in collection)
            {
                Console.WriteLine(sentence.Groups[1]);
            }
        }
    }
}
