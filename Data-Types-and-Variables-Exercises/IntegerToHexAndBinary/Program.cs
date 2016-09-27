using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberHexadecimal = Convert.ToString(number, 16).ToUpper();
            string numberBinary = Convert.ToString(number, 2).ToUpper();
            Console.WriteLine(numberHexadecimal);
            Console.WriteLine(numberBinary);
        }
    }
}
