using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class BlackAndWhiteFilter : BaseFilter
    {
        public override FilterParameter[] GetParameters()
        {
            return new FilterParameter[]
            {
                new FilterParameter() { Name = "Separator, (%)" }
            };
        }

        public override Photo ChangeImage(Photo original, double value)
        {
            double coefficient = value / 100;
            var photo = new Photo(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    double color = original[i, j].R + original[i, j].G + original[i, j].B;
                    if (color > 255 / 2 / coefficient * 3)
                        photo[i, j] = new Pixel(255, 255, 255);
                    else
                        photo[i, j] = new Pixel(0, 0, 0);
                }
            }
            return photo;
        }

        public override string ToString()
        {
            return "B&W filter";
        }
    }
}
