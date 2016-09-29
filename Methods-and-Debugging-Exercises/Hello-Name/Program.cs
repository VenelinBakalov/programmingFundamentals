using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        static void PrintHello (string name)
        {
            string helloMessage = "Hello, " + name + '!';
            Console.WriteLine(helloMessage);
        }
    }
}
