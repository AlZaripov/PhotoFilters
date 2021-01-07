using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class MirrorFilter : BaseFilter
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
                    photo[photo.Width - i - 1, j] = original[i, j];
                }
            }
            return photo;
        }

        public override string ToString()
        {
            return "Mirror filter";
        }
    }
}
