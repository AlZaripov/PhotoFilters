using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class BrightnessFilter : IFilter
    {
        public FilterParameter Parameters { get; set; }

        public override string ToString()
        {
            return "Brightness filter";
        }

        public Photo ChangeImage(Photo original, double value)
        {
            double coefficient = value / 100;
            var photo = new Photo(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    photo[i, j].R = LimitPixelValue(original[i, j].R * coefficient);
                    photo[i, j].G = LimitPixelValue(original[i, j].G * coefficient);
                    photo[i, j].B = LimitPixelValue(original[i, j].B * coefficient);
                }
            }
            return photo;
        }

        public FilterParameter[] GetParameters()
        {
            return new FilterParameter[]
            {
                new FilterParameter() {Name = "Brightness, (%)" }
            };
        }

        private double LimitPixelValue(double value)
        {
            if (value < 0) return 0;
            if (value > 255) return 255;
            return value;
        }
    }

}

