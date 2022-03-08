using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle:Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height 
        {
            get => height;
            set
            {
                if (value == this.Height && value <= 0)
                {
                    throw new ArgumentException("Radius can not be zero or negative");
                }

                height = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value == this.Width && value <= 0)
                {
                    throw new ArgumentException("Radius can not be zero or negative");
                }

                width = value;
            }
        }
        public override double CalculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Height + this.Width);
            return perimeter;
        }
        public override string Draw()
        {
           return $"{base.Draw()} {this.GetType().Name}";
        }
    }
}
