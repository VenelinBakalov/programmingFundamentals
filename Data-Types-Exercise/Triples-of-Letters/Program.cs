using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int first = 'a'; first < 'a' + count; first++)
            {
                for (int second = 'a'; second < 'a' + count; second++)
                {
                    for (int third = 'a'; third < 'a' +count; third++)
                    {
                        Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                    }
                }
            }
        }
    }
}
