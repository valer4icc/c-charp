using System;

namespace GeoFigures
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius turi būti teigiamas skaičius.");
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}