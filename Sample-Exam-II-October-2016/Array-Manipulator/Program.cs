using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine().ToLower();

            while (!command.Equals("end"))
            {
                string[] commandArgs = command.Split().ToArray();
                switch (commandArgs[0])
                {
                    case "exchange":
                        Exchange(commandArgs, numbers);
                        break;

                    case "max":
                        PrintMax(commandArgs, numbers);
                        break;
                    case "min":
                        PrintMin(commandArgs, numbers);
                        break;
                    case "first":
                        PrintFirstElements(commandArgs, numbers);
                        break;
                    case "last":
                        PrintLastElements(commandArgs, numbers);
                        break;
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void PrintLastElements(string[] commandArgs, List<int> numbers)
        {
            int count = int.Parse(commandArgs[1]);

            if (count > numbers.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                string type = commandArgs[2];
                int remainder = type == "even" ? 0 : 1;

                int[] elements = numbers.Where(x => Math.Abs(x) % 2 == remainder).Reverse().Take(count).Reverse().ToArray();
                if (elements.Length.Equals(0))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine("[" + string.Join(", ", elements) + "]");
                }
            }
        }
        private static void PrintFirstElements(string[] commandArgs, List<int> numbers)
        {
            int count = int.Parse(commandArgs[1]);

            if (count > numbers.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                string type = commandArgs[2];
                int remainder = type == "even" ? 0 : 1;
                int[] elements = numbers.Where(x => Math.Abs(x) % 2 == remainder).Take(count).ToArray();
                if (elements.Length.Equals(0))
                {
                    Console.WriteLine("[]");

                }
                else
                {
                    Console.WriteLine("[" + string.Join(", ", elements) + "]");
                }
            }
        }

        private static void PrintMin(string[] commandArgs, List<int> numbers)
        {
            string evenOrOdd = commandArgs[1];
            if (evenOrOdd.Equals("even"))
            {
                try
                {
                    int min = numbers.Where(x => Math.Abs(x) % 2 == 0).Min();
                    int minIndex = numbers.LastIndexOf(min);
                    Console.WriteLine(minIndex);
                }
                catch (Exception)
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (evenOrOdd.Equals("odd"))
            {
                try
                {
                    int min = numbers.Where(x => Math.Abs(x) % 2 == 1).Min();
                    int minIndex = numbers.LastIndexOf(min);
                    Console.WriteLine(minIndex);
                }
                catch (Exception)
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void PrintMax(string[] commandArgs, List<int> numbers)
        {
            string evenOrOdd = commandArgs[1];
            if (evenOrOdd.Equals("even"))
            {
                try
                {
                    int max = numbers.Where(x => Math.Abs(x) % 2 == 0).Max();
                    int maxIndex = numbers.LastIndexOf(max);
                    Console.WriteLine(maxIndex);
                }
                catch (Exception)
                {
                    Console.WriteLine("No matches");
                }

            }
            else if (evenOrOdd.Equals("odd"))
            {
                try
                {
                    int max = numbers.Where(x => Math.Abs(x) % 2 == 1).Max();
                    int maxIndex = numbers.LastIndexOf(max);
                    Console.WriteLine(maxIndex);
                }
                catch (Exception)
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void Exchange(string[] commandArgs, List<int> numbers)
        {
            int index = int.Parse(commandArgs[1]);
            if (index < 0 || index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                List<int> firstGroup = numbers.Take(index+1).ToList();
                numbers.RemoveRange(0, index + 1);
                numbers.AddRange(firstGroup);
            }
        }
    }
}
