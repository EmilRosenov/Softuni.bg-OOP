using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        { get=>this.length;
            set
            {
                ThrowIfInvalidSide(value, nameof(Length));
                this.length = value;
            } 
        
        }
        public double Width
        {
            get => this.width;
            set
            {
                ThrowIfInvalidSide(value, nameof(Width));
                this.width = value;
            }

        }
        public double Height
        {
            get => this.height;
            set
            {
                ThrowIfInvalidSide(value, nameof(Height));
                this.height = value;
            }

        }
        public double SurfaceArea()
        {
            return 2*(Length*Width) + 2*(Length*Height) +  2*(Width*Height);
        }
        public double LateralSurfaceArea()
        {
            return  2 * Length * Height + 2 * Width * Height;
        }
        public double Volume()
        {
            return Length*Width*Height;
        }

        private void ThrowIfInvalidSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
