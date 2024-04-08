using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Task
{
    public class Triangle : IShape
    {
        public double side1, side2, side3;

        public Triangle()
        {
        }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateRadius(double radius)
        {
            return 0;
        }

        public double CalculateArea(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Lengths of sides must be greater than 0");

            double S = (side1 + side2 + side3) / 2;
            return Math.Sqrt(S * (S - side1) * (S * side2) * (S * side3));
        }

        public bool IsRightTriangle(double side1, double side2,double side3) 
        {
            if (Math.Pow(side1, 2) == (Math.Pow(side2, 2) + Math.Pow(side3, 2)) ||
                Math.Pow(side2, 2) == (Math.Pow(side1, 2) + Math.Pow(side3, 2)) ||
                Math.Pow(side3, 2) == (Math.Pow(side1, 2) + Math.Pow(side2, 2)))
            {
                return true;
            }
            else
                return false;
        }
    }
}
