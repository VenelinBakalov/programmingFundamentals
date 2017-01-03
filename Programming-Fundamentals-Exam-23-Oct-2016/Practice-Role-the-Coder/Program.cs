using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Role_the_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ' };

            Dictionary<int, string> eventIdAndName = new Dictionary<int, string>();
            Dictionary<string, List<string>> eventNameandParticipants = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {
                string[] commandLine = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

                int eventId = int.Parse(commandLine[0]);

                if (commandLine[1].IndexOf("#").Equals(0))
                {
                    string eventName = commandLine[1].Substring(1);
                    InsertIdAndName(eventIdAndName, eventId, eventName, eventNameandParticipants);
                    string[] participants = commandLine.Skip(2).ToArray();
                    if (eventIdAndName.ContainsKey(eventId) && eventIdAndName[eventId].Equals(eventName))
                    {
                        InsertParticipants(eventNameandParticipants, eventName, participants);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> pair in eventNameandParticipants.OrderByDescending(e => e.Value.Count)
                .ThenBy(e => e.Key))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value.Count}");
                foreach (string name in pair.Value.OrderBy(p => p))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }

        private static void InsertParticipants(Dictionary<string, List<string>> eventNameandParticipants, string eventName, string[] participants)
        {
            foreach (string name in participants)
            {
                if (!eventNameandParticipants[eventName].Contains(name))
                {
                    eventNameandParticipants[eventName].Add(name);
                }
            }
        }

        private static void InsertIdAndName(Dictionary<int, string> eventIdAndName, int eventId, string eventName, Dictionary<string, List<string>> eventNameandParticipants)
        {
            if (!eventIdAndName.ContainsKey(eventId))
            {
                eventIdAndName.Add(eventId, eventName);
                eventNameandParticipants.Add(eventName, new List<string>());
            }
        }
    }
}
