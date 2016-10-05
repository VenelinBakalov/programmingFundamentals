using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
                {'.', ',', ':', ';', '(', ')', '[', ']', '\\', '/', '\'', '\"', '!', '?', ' '};

            string[] words = Console.ReadLine()
                                .ToLower()
                                .Split(separators)
                                .Where(word => word != "")
                                .Distinct()
                                .Where(word => word.Length < 5)
                                .OrderBy(word => word)
                                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
