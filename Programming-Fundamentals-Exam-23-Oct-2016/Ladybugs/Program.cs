﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ' };

            int fieldSize = int.Parse(Console.ReadLine());
            Dictionary<long, int> indexes = new Dictionary<long, int>();

            long[] positions = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            foreach (long position in positions)
            {
                if (position >= 0 && position < fieldSize && !indexes.ContainsKey(position))
                {
                indexes.Add(position, 1);
                }
            }

            string[] commandLine = Console.ReadLine().ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (!commandLine[0].Equals("end"))
            {
                long initialPosition = long.Parse(commandLine[0]);
                string direction = commandLine[1];
                long flightLength = long.Parse(commandLine[2]);

                if (initialPosition >= 0 && initialPosition < fieldSize 
                    && indexes.ContainsKey(initialPosition)
                    && indexes[initialPosition] == 1)
                {
                    long finalPosition = 0;

                    switch (direction)
                    {
                        case "right":

                            indexes[initialPosition] = 0;

                            finalPosition = initialPosition + flightLength;

                            while (finalPosition >= 0 && finalPosition < fieldSize)
                            {
                                if (indexes.ContainsKey(finalPosition) && indexes[finalPosition] == 1)
                                {
                                    finalPosition += flightLength;
                                }
                                else
                                {
                                    indexes[finalPosition] = 1;
                                    break;
                                }
                            }

                            break;

                        case "left":

                            indexes[initialPosition] = 0;

                            finalPosition = initialPosition - flightLength;

                            while (finalPosition >= 0 && finalPosition < fieldSize )
                            {
                                if (indexes.ContainsKey(finalPosition) && indexes[finalPosition] == 1)
                                {
                                    finalPosition -= flightLength;
                                }
                                else
                                {
                                    indexes[finalPosition] = 1;
                                    break;
                                }
                            }

                            break;

                        default:
                            break;
                    }
                }

                commandLine = Console.ReadLine().ToLower().Split().ToArray();
            }

            for (int i = 0; i < fieldSize; i++)
            {
                if (indexes.ContainsKey(i))
                {
                    Console.Write($"{indexes[i]} ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
        }
    }
}
