﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class NegativeFilter : BaseFilter
    {  
        public override FilterParameter[] GetParameters()
        {
            return new FilterParameter[] { };
        }
     
        public override Photo ChangeImage(Photo original, double value)
        {
            var photo = new Photo(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    photo[i, j].R = 255 - original[i, j].R;
                    photo[i, j].G = 255 - original[i, j].G;
                    photo[i, j].B = 255 - original[i, j].B;
                }
            }
            return photo;
        }

        public override string ToString()
        {
            return "Negative filter";
        }
    }
}
