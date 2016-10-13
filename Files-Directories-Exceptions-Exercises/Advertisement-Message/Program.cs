using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            const string phrasesFilePath = @"..\..\RandomMessages\Phrases.txt";
            const string eventsPath = @"..\..\RandomMessages\Events.txt";
            const string authorsPath = @"..\..\RandomMessages\Authors.txt";
            const string citiesPath = @"..\..\RandomMessages\Cities.txt";


            const string outputFilePath = @"output.txt";
            const string inputFilePath = @"input.txt";

            string[] phrases = File.ReadAllLines(phrasesFilePath);
            string[] events = File.ReadAllLines(eventsPath);
            string[] authors = File.ReadAllLines(authorsPath);
            string[] cities = File.ReadAllLines(citiesPath);

            Random random = new Random();

            int messageCount = int.Parse(File.ReadAllText(inputFilePath));

            for (int i = 0; i < messageCount; i++)
            {
                string randomPhrase = phrases[random.Next(phrases.Length)];
                string randomEvent = events[random.Next(events.Length)];
                string randomAuthor = authors[random.Next(authors.Length)];
                string randomCity = cities[random.Next(cities.Length)];

                string output = string.Format($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}\r\n");
                File.AppendAllText(outputFilePath, output);

            }

        }
    }
}
