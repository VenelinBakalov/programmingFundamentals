using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task_New
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            Dictionary<string, long> resourses = new Dictionary<string, long>();

            while (key != "stop")
            {
                long value = long.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(key))
                {
                    resourses.Add(key, 0);
                }

                resourses[key] += value;

                key = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> pair in resourses)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
