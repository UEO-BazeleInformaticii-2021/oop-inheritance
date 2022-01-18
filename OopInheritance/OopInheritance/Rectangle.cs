using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public class Rectangle : Shape
    {
        private Rectangle(
            Point topLeft,
            Point topRight,
            Point bottomRight,
            Point bottomLeft,
            int width,
            int height)
        {
            TopLeft = topLeft;
            TopRight = topRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;

            Height = height;
            Width = width;
        }

        public Rectangle(
            Point topLeft,
            int width,
            int height)
            : this(topLeft,
                    new Point(topLeft.X + width, topLeft.Y),
                    new Point(topLeft.X + width, topLeft.Y + height),
                    new Point(topLeft.X, topLeft.Y + height),
                    width,
                    height)
        {
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomLeft { get; }

        public Point BottomRight { get; }

        public int Width { get; }

        public int Height { get; }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public override Point[] Points
        {
            get
            {
                return new Point[] {
                    TopLeft,
                    TopRight,
                    BottomRight,
                    BottomLeft
                };
            }
        }

        public override void Rotate(double angleDegrees)
        {
            Console.WriteLine("Preparing to rotate rectangle");
            base.Rotate(angleDegrees);
            Console.WriteLine("Finished to rotate rectangle");
        }
    }
}
