using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class Pixel
    {
        private double r;
        private double g;
        private double b;

        public double R 
        {
            get { return r; }
            set 
            {
                if (value > 255)
                    r = 255;
                r = value;
            }
        }

        public double G
        {
            get { return g; }
            set
            {
                if (value > 255)
                    g = 255;
                g = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value > 255)
                    b = 255;
                b = value;
            }
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
    }
}
