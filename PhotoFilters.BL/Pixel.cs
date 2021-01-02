using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class Pixel
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Pixel(int R, int G, int B)
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
