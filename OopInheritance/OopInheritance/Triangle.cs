using System;

namespace OopInheritance
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.P1 = p1 ?? new Point(0, 0);
            this.P2 = p2 ?? new Point(0, 0);
            this.P3 = p3 ?? new Point(0, 0);
        }

        public Point P1 { get; }

        public Point P2 { get; }

        public Point P3 { get; }

        public override double Area
        {
            get
            {
                // see: https://www.mathopenref.com/coordtrianglearea.html
                double area = Math.Abs(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y)) / 2;
                return Math.Round(area, 2);
            }
        }

        public override Point[] Points
        {
            get
            {
                return new Point[] { this.P1, this.P2, this.P3 };
            }
        }

        public override void Rotate(double angleDegrees)
        {
            Console.WriteLine("Preparing to rotate triangle");
            base.Rotate(angleDegrees);
            Console.WriteLine("Finished to rotate triangle");
        }
    }
}
