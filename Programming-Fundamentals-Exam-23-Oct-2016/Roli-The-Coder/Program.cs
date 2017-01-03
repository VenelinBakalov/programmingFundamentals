using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] delimiters = new char[] { ' ', '@' };

            Dictionary<int, string> nameAndId = new Dictionary<int, string>();
            Dictionary<string, List<string>> eventAndNames = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {
                string[] inputCommand = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

                int id = int.Parse(inputCommand[0]);
                //     string eventName = input[1].Substring(1);
                string symbol = inputCommand[1].Substring(0, 1);

                if (symbol == "#")
                {
                    string eventName = inputCommand[1].Substring(1);
                    InsertNameAndId(nameAndId, id, eventName, eventAndNames);
                    string[] names = inputCommand.Skip(2).ToArray();

                    if (nameAndId.ContainsKey(id) && nameAndId[id].Equals(eventName))
                    {
                        InsertNames(eventAndNames, names, eventName);
                    }

                }

                input = Console.ReadLine();

            }

            //        Dictionary<string, List<string>> final = new Dictionary<string, List<string>>();

            //    foreach (var item in eventAndNames)
            //    {
            //        final.Add(item.Key, item.Value.OrderBy(x => x).ToList());
            //    }

            foreach (var eventName in eventAndNames.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventName.Key} - {eventName.Value.Count}");
                foreach (var guestName in eventName.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine($"@{guestName}");
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

        private static void InsertNameAndId(Dictionary<int, string> nameAndId, int id, string eventName, Dictionary<string, List<string>> eventAndNames)
        {
            if (!nameAndId.ContainsKey(id))
            {
                nameAndId.Add(id, eventName);
                eventAndNames.Add(eventName, new List<string>());
            }
        }
    }
}