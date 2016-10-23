using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] delimiters = new char[] { ' ', '@' };

            Dictionary<string, string> nameAndId = new Dictionary<string, string>();
            Dictionary<string, List<string>> eventAndNames = new Dictionary<string, List<string>>();


            string[] input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (!input[0].Equals("Time"))
            {

                string id = input[0];
                string eventName = input[1].Substring(1);
                string symbol = input[1].Substring(0, 1);

                if (symbol == "#")
                {

                    InsertNameAndId(nameAndId, id, eventName, eventAndNames);
                    string[] names = input.Skip(2).ToArray();

                    if (nameAndId.ContainsValue(eventName))
                    {
                        InsertNames(eventAndNames, names, eventName);
                    }

                }

                input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();


            }

            Dictionary<string, List<string>> final = new Dictionary<string, List<string>>();

            foreach (var item in eventAndNames)
            {
                final.Add(item.Key, item.Value.OrderBy(x => x).ToList());
            }

            foreach (var item in final.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
                foreach (var itaem in item.Value)
                {
                    Console.WriteLine($"@{itaem}");
                }
            }
        }

        private static void InsertNames(Dictionary<string, List<string>> eventAndNames, string[] names, string eventName)
        {
            foreach (string name in names)
            {
                if (!eventAndNames[eventName].Contains(name))
                {
                    eventAndNames[eventName].Add(name);
                }
            }
        }

        private static void InsertNameAndId(Dictionary<string, string> nameAndId, string id, string eventName, Dictionary<string, List<string>> eventAndNames)
        {
            if (!nameAndId.ContainsKey(id))
            {
                nameAndId.Add(id, eventName);
                eventAndNames.Add(eventName, new List<string>());
            }
        }

        private static void InsertId(Dictionary<string, Dictionary<string, List<string>>> events, string id, string eventName)
        {
            if (!events.ContainsKey(id))
            {
                events.Add(id, new Dictionary<string, List<string>>());
                events[id].Add(eventName, new List<string>());
            }
        }
    }
}
