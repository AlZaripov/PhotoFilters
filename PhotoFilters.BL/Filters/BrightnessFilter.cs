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
            var photo = new Photo(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    photo[i, j].R = original[i, j].R * value;
                    photo[i, j].G = original[i, j].G * value;
                    photo[i, j].B = original[i, j].B * value;
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
    }

}

