using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 0, Y = 0 };
            Point p2 = new Point() { X = 4, Y = 0 };
            Point p3 = new Point() { X = 4, Y = 4 };
            Console.WriteLine(Area(p1, p2, p3));
        }
        
        static double Area(Point p1, Point p2, Point p3)
        {
            double a = CalculateDistance(p1, p2);
            double b = CalculateDistance(p2, p3);
            double c = CalculateDistance(p3, p1);

            double d = (a + b + c) / 2;
            return Math.Sqrt(d * (d - a) * (d - b) * (d - c));
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)));
        }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
