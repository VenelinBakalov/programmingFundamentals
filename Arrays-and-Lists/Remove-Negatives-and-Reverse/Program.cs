using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            List<int> list = new List<int>();

            for (int i = 0; i < items.Length; i++)
            {
                list.Add(int.Parse(items[i]));
            }

            List<int> rearangedList = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] >= 0)
                {
                    rearangedList.Add(list[i]);
                }
            }

            if (rearangedList.Count > 0)
            {
                foreach (var item in rearangedList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
