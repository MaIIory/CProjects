using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App28_OperatorsOverloading
{
    class Point : IComparable<Point>
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Overloading binary operators
        public static Point operator +(Point pt1, Point pt2)
        {
            return new Point(pt1.X + pt2.X, pt1.Y + pt2.Y);
        }

        public static Point operator -(Point pt1, Point pt2)
        {
            return new Point(pt1.X - pt2.X, pt1.Y - pt2.Y);
        }

        public static Point operator +(int value, Point pt)
        {
            return new Point(pt.X + 1, pt.Y + 1);
        }

        public static Point operator +(Point pt, int value)
        {
            return new Point(pt.X + 1, pt.Y + 1);
        }

        //Overloading Unary operators
        public static Point operator ++(Point pt)
        {
            return new Point(pt.X + 1, pt.Y + 1);
        }

        public static Point operator --(Point pt)
        {
            return new Point(pt.X - 1, pt.Y - 1);
        }

        public override string ToString()
        {
            return "X: " + X + ", Y: " + Y;
        }

        //Overloading Equality Operators
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Point pt1, Point pt2)
        {
            return pt1.Equals(pt2);
        }

        public static bool operator !=(Point pt1, Point pt2)
        {
            return !pt1.Equals(pt2);
        }

        //Overloading Comparison Operators
        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            else if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }

        public static bool operator <(Point p1, Point p2)
        { return (p1.CompareTo(p2) < 0); }

        public static bool operator >(Point p1, Point p2)
        { return (p1.CompareTo(p2) > 0); }

        public static bool operator <=(Point p1, Point p2)
        { return (p1.CompareTo(p2) <= 0); }

        public static bool operator >=(Point p1, Point p2)
        { return (p1.CompareTo(p2) >= 0); }
    }
}
