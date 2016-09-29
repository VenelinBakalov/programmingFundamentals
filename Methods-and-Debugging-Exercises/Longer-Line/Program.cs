using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetDistanceBetweennTwoPoints(x1, y1, x2, y2);
            double secondLineLength = GetDistanceBetweennTwoPoints(x3, y3, x4, y4);

            if (firstLineLength >= secondLineLength)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }

        }

        private static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double distanceTOCenterA = GetDistanceBetweennTwoPoints(x1, y1, 0, 0);
            double distanceToCenterB = GetDistanceBetweennTwoPoints(x2, y2, 0, 0);
            if (distanceTOCenterA <= distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);

            }
        }

        static double GetDistanceBetweennTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
