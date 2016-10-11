using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message_New
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random randomNumber = new Random();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int phraseIndex = randomNumber.Next(0, phrases.Length);
                int eventsIndex = randomNumber.Next(0, events.Length);
                int authorIndex = randomNumber.Next(0, author.Length);
                int citiesIndex = randomNumber.Next(0, cities.Length);
                Console.WriteLine("{0} {1} {2} - {3}",
                                    phrases[phraseIndex],
                                    events[eventsIndex],
                                    author[authorIndex],
                                    cities[citiesIndex]);
            }
        }
    }
}
