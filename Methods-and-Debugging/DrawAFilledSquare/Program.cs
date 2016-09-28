using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSquare();
        }

        static void PrintSquare()
        {
            int input = int.Parse(Console.ReadLine());
            PrintEnd(input);
            for (int i = 0; i < input - 2; i++)
            {
            PrintMiddle(input);
            }
            PrintEnd(input);
        }

        static void PrintEnd(int input)
        {
            Console.WriteLine(new string('-', 2 * input));
        }

        static void PrintMiddle(int input)
        {
            Console.Write('-');
            for (int i = 0; i < input - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
