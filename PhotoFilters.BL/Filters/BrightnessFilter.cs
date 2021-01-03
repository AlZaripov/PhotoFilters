using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class BrightnessFilter
    {
        public int Coefficient { get; set; }

        public override string ToString()
        {
            return "Изменение яркости";
        }

        public Photo ChangeImage(Photo original, double coefficient)
        {
            var photo = new Photo(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    photo[i, j].R = original[i, j].R * coefficient;
                    photo[i, j].G = original[i, j].G * coefficient;
                    photo[i, j].B = original[i, j].B * coefficient;
                }
            }
            return photo;
        }
    }
}
