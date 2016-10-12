using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, 
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount.Add(word, 0);
            }

            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            File.WriteAllText("output.txt", "");

            foreach (KeyValuePair<string, int> count in wordCount.OrderByDescending(w => w.Value))
            {
                File.AppendAllText("output.txt", ($"{count.Key} - {count.Value}{Environment.NewLine}"));
            }
        }
    }
}
