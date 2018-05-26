using System;

namespace PrototypeExcericise
{
    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point DeepCopy()
        {
            return new Point(X, Y);
        }

        public override string ToString()
        {
            return $"{nameof(X)}:{X},{nameof(Y)}:{Y}";
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end) {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            return new Line(Start, End);
        }

        public override string ToString()
        {
            return $"{nameof(Start)}:{Start},{nameof(End)}:{End}";
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(3, 4);

            Line a1 = new Line(a, b);
            Line a2 = a1.DeepCopy();

            Console.WriteLine(a2);
            Console.ReadLine();
        }
    }
}