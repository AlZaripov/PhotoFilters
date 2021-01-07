using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class SepiaFilter : BaseFilter
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
                    var tr = 0.393 * original[i, j].R + 0.769 * original[i, j].G + 0.189 * original[i, j].B;
                    var tg = 0.349 * original[i, j].R + 0.686 * original[i, j].G + 0.168 * original[i, j].B;
                    var tb = 0.272 * original[i, j].R + 0.534 * original[i, j].G + 0.131 * original[i, j].B;

                    if (tr > 255) photo[i, j].R = 255; else photo[i, j].R = tr;
                    if (tg > 255) photo[i, j].G = 255; else photo[i, j].G = tg;
                    if (tb > 255) photo[i, j].B = 255; else photo[i, j].B = tb;
                }
            }
            return photo;
        }


        public override string ToString()
        {
            return "Sepia filter";
        }
    }
}
