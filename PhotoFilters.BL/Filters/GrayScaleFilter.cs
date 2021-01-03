using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class GrayScaleFilter
    {
        public int Coefficient { get; set; }

        public override string ToString()
        {
            return "Оттенки серого";
        }

        public Photo ChangeImage(Photo original, double coefficient)
        {
            var photo = new Photo(original.Width, original.Height);
            for(int i = 0; i < original.Width; i++)
            {
                for(int j = 0; j < original.Height; j++)
                {
                    var grayCoefficient = (original[i, j].R + original[i, j].G + original[i, j].B) / 3;
                    photo[i, j] = new Pixel(grayCoefficient, grayCoefficient, grayCoefficient);
                }
            }
            return photo;
        }

    }
}
