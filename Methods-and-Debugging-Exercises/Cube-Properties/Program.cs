using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = GetResult(side, parameter);
            PrintResult(result);
        }

        static double GetResult(double side, string parameter)
        {
            switch (parameter)
            {
                case "face": double faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2)); return faceDiagonal;
                case "space": double spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2)); return spaceDiagonal;
                case "volume": double volume = Math.Pow(side, 3); return volume;
                case "area": double area = 6 * Math.Pow(side, 2); return area;
            }
            return 0;
        }

        static void PrintResult(double result)
        {
            Console.WriteLine("{0:f2}", result);
        }
    }
}
