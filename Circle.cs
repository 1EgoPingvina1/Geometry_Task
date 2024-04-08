using System;

namespace Geometry_Task
{
    public class Circle : IShape
    {
        public double radius;

        public Circle()
        {
        }

        public Circle(double radius) 
        {
            this.radius = radius;
        }

        public double CalculateRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("radius most be > 0");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
