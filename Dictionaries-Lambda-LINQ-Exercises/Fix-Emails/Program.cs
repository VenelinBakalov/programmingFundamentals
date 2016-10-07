using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> mailList = new Dictionary<string, string>();

            int counter = 1;
            string key = "";

            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    mailList[input] = "";
                    key = input;
                }
                else
                {
                    mailList[key] = input;
                }

                counter++;
                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, string> pair in mailList)
            {
                if (!pair.Value.ToLower().EndsWith("uk") && !pair.Value.ToLower().EndsWith("us"))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
