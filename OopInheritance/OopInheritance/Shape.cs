
namespace OopInheritance
{
    public abstract class Shape
    {
        public abstract double Area
        {
            get;
        }

        public abstract Point[] Points
        {
            get;
        }

        public virtual void Rotate(double angleDegrees)
        {
            foreach (Point p in Points)
            {
                p.ApplyRotationTransform(angleDegrees);
            }
        }
    }
}
