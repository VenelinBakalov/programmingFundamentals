using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circleFirst = ReadCircle();
            Circle circleSecond = ReadCircle();

            if (Intersect(circleFirst, circleSecond))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intersect(Circle circleFirst, Circle circleSecond)
        {
            double distance = CalcDistance(circleFirst.Center, circleSecond.Center);
            if (circleFirst.Radius + circleSecond.Radius >= distance)
            {
                return true;
            }
            return false;
        }

        static double CalcDistance(Point pointFirst, Point pointSecond)
        {
            int deltaX = pointSecond.X - pointFirst.X;
            int deltaY = pointSecond.Y - pointFirst.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        static Circle ReadCircle()
        {
            int[] circleInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle = new Circle(new Point(circleInfo[0], circleInfo[1]), circleInfo[2]);
            return circle;
        }
    }

    class Circle
    {
        public Point Center;
        public int Radius;

        public Circle(Point Center, int Radius)
        {
            this.Center = Center;
            this.Radius = Radius;
        }
    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
