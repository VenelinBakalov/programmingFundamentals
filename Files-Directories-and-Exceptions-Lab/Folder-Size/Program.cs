using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fInfo = new FileInfo(file);
                sum += fInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
