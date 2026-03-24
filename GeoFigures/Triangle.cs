using System;

namespace GeoFigures
{
    public class Triangle
    {
        private double triangleBase;
        private double height;

        public double Base
        {
            get { return triangleBase; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Base turi būti teigiamas skaičius.");
                triangleBase = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height turi būti teigiamas skaičius.");
                height = value;
            }
        }

        public Triangle(double triangleBase, double height)
        {
            Base = triangleBase;
            Height = height;
        }

        public double GetArea()
        {
            return Base * Height / 2;
        }

        public double GetPerimeter()
        {
            double hypotenuse = Math.Sqrt(Base * Base + Height * Height);
            return Base + Height + hypotenuse;
        }
    }
}