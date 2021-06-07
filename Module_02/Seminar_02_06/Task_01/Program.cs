using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point() { }
        public double P
        {
            get
            {
                return
            }
        }
        public double Distance(Point p1, Point p2)
        {

        }
        public Point(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}
