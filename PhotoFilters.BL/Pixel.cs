using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class Pixel 
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = CheckPixelValue(value); }
        }

        private double g;
        public double G
        {
            get { return g; }
            set { g = CheckPixelValue(value); }
        }

        private double b;
        public double B
        {
            get { return b; }
            set { b = CheckPixelValue(value); }
        }

        public Pixel(double R, double G, double B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }
        public Pixel()
        {

        }

        private double CheckPixelValue(double value)
        {
            if (value > 255)
                throw new ArgumentException("Pixel value is not correct");
            return value;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            var pixel = obj as Pixel;
            return (pixel.R == R && pixel.G == G && pixel.B == B);
        }
    } 
}
