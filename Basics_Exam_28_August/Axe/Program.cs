using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int width = 5 * count;
            int leftColumn = 3 * count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftColumn), new string('-', i), 
                    new string('-', width - leftColumn - 2 - i));
            }
            for (int i = 0; i < count / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftColumn), new string('-', count - 1), 
                    new string('-',count - 1));
            }
            for (int i = 0; i < count / 2; i++)
            {
                if (i == (count / 2) - 1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftColumn - i), new string('*', width - leftColumn + i - count -1 + i),
                    new string('-', count - 1 - i));
                }
                else
                {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftColumn - i), new string('-', width - leftColumn + i - count - 1 + i),
                    new string('-', count - 1 - i));
                }
            }

        }
    }
}
