﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters_Hardcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[]
        {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

            string input = Console.ReadLine();

            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (input[j].ToString().Contains(alphabet[i]))
                    {
                        Console.WriteLine("{0} -> {1}", input[j], i);
                    }
                }
            }
        }
    }
}