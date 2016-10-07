using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            int stringCounter = 1;
            string key = "";
            int value = 0;

            while (input != "stop")
            {

                if (stringCounter % 2 != 0)
                {
                    if (!resourses.ContainsKey(input))
                    {
                        resourses[input] = 0;
                    }
                    key = input;
                }
                else
                {
                    value = int.Parse(input);
                    resourses[key] += value;
                }

                stringCounter++;
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> pair in resourses)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
