using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object sentence = firstWord + ' ' + secondWord;
            string finalSentence = (string)sentence;
            Console.WriteLine(finalSentence);
        }
    }
}
