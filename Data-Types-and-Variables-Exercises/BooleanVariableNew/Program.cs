using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariableNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(word);

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
