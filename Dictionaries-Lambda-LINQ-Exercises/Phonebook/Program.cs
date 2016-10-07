using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entryForPhonebook = Console.ReadLine().Split();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (entryForPhonebook[0] != "END")
            {
                if (entryForPhonebook[0] == "A")
                {
                    phonebook[entryForPhonebook[1]] = entryForPhonebook[2];
                }
                else if (entryForPhonebook[0] == "S")
                {
                    if (phonebook.ContainsKey(entryForPhonebook[1]))
                    {
                        Console.WriteLine($"{entryForPhonebook[1]} -> {phonebook[entryForPhonebook[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {entryForPhonebook[1]} does not exist.");
                    }
                }
                entryForPhonebook = Console.ReadLine().Split();
            }
        }
    }
}
