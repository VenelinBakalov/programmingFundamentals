using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<double> numbersList = new List<double>();

            for (int i = 0; i < input.Length; i++)
            {
                numbersList.Add(double.Parse(input[i]));
            }

            int counter = 0;

            while (counter < numbersList.Count - 1)
            {
                if (numbersList[counter] == numbersList[counter + 1])
                {
                    numbersList[counter] += numbersList[counter + 1];
                    numbersList.RemoveAt(counter + 1);
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
