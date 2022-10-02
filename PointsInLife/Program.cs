using System;

namespace PointsInLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Point x = new Point(1, 2, 3);
            x.show();
            Point y = new Point(3, 5, 2);
            Point z = Point.vectorMultiplication(x,y);
            z.show();
            Console.WriteLine(x * y);
        }
    }
}
