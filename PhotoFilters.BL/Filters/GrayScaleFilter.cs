﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class GrayScaleFilter : BaseFilter
    {
        public override FilterParameter[] GetParameters()
        {
            return new FilterParameter[] { };
        }

        public override Photo ChangeImage(Photo original, double value)
        {
            var photo = new Photo(original.Width, original.Height);
            for(int i = 0; i < original.Width; i++)
            {
                for(int j = 0; j < original.Height; j++)
                {
                    var grayCoefficient = (original[i,j].R + original[i,j].G + original[i,j].B) / 3;
                    photo[i,j] = new Pixel(grayCoefficient, grayCoefficient, grayCoefficient);
                }
            }
            return photo;
        }

        public override string ToString()
        {
            return "Grayscale filter";
        }
    }
}
