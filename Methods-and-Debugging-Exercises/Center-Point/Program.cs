using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());

            PrintCloserPoint(firstPointX, firstPointY, secondPointX, secondPointY);
        }


        static void PrintCloserPoint(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distanceForX = Math.Abs(firstPointX) + Math.Abs(firstPointY);
            double distatnceForY = Math.Abs(secondPointX) + Math.Abs(secondPointY);
            if (distanceForX <= distatnceForY)
            {
                Console.WriteLine("({0}, {1})", firstPointX, firstPointY);
            }
            else
            {
                Console.WriteLine("({0}, {1})", secondPointX, secondPointY);
            }
        }
    }
}
