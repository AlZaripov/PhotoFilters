using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace PhotoFilters.BL
{
    public static class Conversion
    {
        public static Photo BitmapToPhoto(Bitmap bm)
        {
            var photo = new Photo(bm.Width, bm.Height);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    photo[i, j].R = bm.GetPixel(i, j).R;
                    photo[i, j].G = bm.GetPixel(i, j).G;
                    photo[i, j].B = bm.GetPixel(i, j).B;
                }
            }
            return photo;
        }

        public static Bitmap PhotoToBitmap(Photo photo)
        {
            Bitmap bm = new Bitmap(photo.Width, photo.Height);

            for (int i = 0; i < photo.Width; i++)
                for (int j = 0; j < photo.Height; j++)
                    bm.SetPixel(i, j, Color.FromArgb(photo[i, j].R, photo[i, j].G, photo[i, j].B));
            return bm;
        }
    }
}
