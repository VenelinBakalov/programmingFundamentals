using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableinHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberFirst = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(numberFirst);

        }
    }
}
