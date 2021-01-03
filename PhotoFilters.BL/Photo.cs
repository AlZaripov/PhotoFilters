using System;

namespace PhotoFilters.BL
{
    public class Photo
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Pixel[,] pixels { get; set; }

        public Photo(int width, int height)
        {
            Width = width;
            Height = height;
            pixels = new Pixel[width, height];

            for(int i=0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    pixels[i, j] = new Pixel();
                }
            }
        }

        public Pixel this[int x, int y] 
        {
            get { return pixels[x, y]; }
            set { pixels[x, y] = value; }
        }

    }
}
