using System;
using System.Collections.Generic;
using System.Text;

namespace PointsInLife
{
    class Point
    {
       private double x;
       private double y;
       private double z;

        public double X { get => x; set { x = value; } }
        public double Y{ get => y; set { y = value; } }
        public double Z{ get => z; set { z = value; } }


        public Point(double x = 0, double y = 0, double z = 0)
        {
            this.x = x;
            this.y =y;
            this.z = z;
        }


        public static double distanceBetweenTwoDots(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2) + Math.Pow((b.Z - a.Z), 2));
        }

        public static void straightLineEquation(Point a, Point b)
        {
            Console.WriteLine(" x = {0}t + {1};", b.X - a.X, a.X);
            Console.WriteLine(" y = {0}t + {1};", b.Y - a.Y, a.Y);
            Console.WriteLine(" z = {0}t + {1};", b.Z - a.Z, a.Z);
        }


        public static Point vector(Point a, Point b)
        {
            return new Point(b.X - a.X, b.Y - a.Y, b.Z - a.Z);
        }



        public static void planeEquation(Point a, Point b, Point c)
        {
            Point m1 = vector(a,b);
            Point m2 = vector(a,c);

            Console.WriteLine("A{0} + B{1} + C{2} + {3} = 0",
                m1.Y*m2.Z - m1.Z*m2.Y,
                m1.Z*m2.Y - m1.Y*m2.Z,
                m1.Y*m2.X - m1.X*m2.Y,
                (m1.Y * m2.Z - m1.Z * m2.Y)*a.X + (m1.Z * m2.Y - m1.Y * m2.Z)*a.Y + (m1.Y * m2.X - m1.X * m2.Y)*a.Z
                );

        }

        public static double distanceToOrigin(Point a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        public static Point operator+(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static double operator*(Point a, Point b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static Point vectorMultiplication(Point a, Point b)
        {
            return new Point(a.Y * b.Z - a.Z * b.Y,
                 a.Z * b.Y - a.Y * b.Z,
                 a.Y * b.X - a.X * b.Y
                 );
        }

        public void show()
        {
            Console.WriteLine("({0}, {1}, {2})", this.x, this.y, z);
        }
    }
}
