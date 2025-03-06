using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Point
    {
        private double x;
        private double y;
        private double z;
        private double e;
        private static int count;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public double E
        {
            get { return e; }
            set { e = value; }
        }
        public static int Count
        {
            get { return count; }
            set { count = value; }
        }

        public Point()
        {
            X = 1.0;
            Y = 1.0;
            Z = 1.0;
            E = 1.0;

            Count++;
        }
        static Point()
        {
            Count = 0;
        }
        public Point(double x, double y, double z, double e)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.E = e;
            Count++;
        }
        public override string ToString()
        {
            return $"x= {x} y= {y} z={z} e={e}\n{count}";

        }
    }
}