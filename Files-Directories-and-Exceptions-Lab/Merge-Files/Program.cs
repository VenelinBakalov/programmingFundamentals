using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstText = File.ReadAllLines("FileOne.txt");
            string[] secondText = File.ReadAllLines("FileTwo.txt");
            File.WriteAllText("Output.txt", "");

            for (int i = 0; i < firstText.Length; i++)
            {
                File.AppendAllText("Output.txt", firstText[i] + Environment.NewLine + secondText[i] + Environment.NewLine);
            }
        }
    }
}
