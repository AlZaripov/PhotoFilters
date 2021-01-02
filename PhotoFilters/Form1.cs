using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoFilters.BL;

namespace PhotoFilters
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(@"C:\Users\Александр\source\repos\PhotoFilters\PhotoFilters.BL\Image.jpg");
            var photo = BitmapToPhoto(img);

            PictureBox original = new PictureBox();
            original.Location = new Point(0,0);
            original.Size = new Size(img.Width, img.Height);
            original.Image = img;
            Controls.Add(original);

            PictureBox result = new PictureBox();
            result.Location = new Point(0, original.Height + 10);
            result.Size = new Size(photo.Width, photo.Height);
            result.Image = PhotoToBitmap(photo);
            Controls.Add(result);


        }

        private Photo BitmapToPhoto(Bitmap bm)
        {
            var photo = new Photo(bm.Width, bm.Height);

            for(int i =0; i < bm.Width; i++)
            {
                for(int j=0; j<bm.Height; j++)
                {
                    photo.pixels[i, j].R = bm.GetPixel(i, j).R;
                    photo.pixels[i, j].G = bm.GetPixel(i, j).G;
                    photo.pixels[i, j].B = bm.GetPixel(i, j).B;
                }
            }
            return photo;
        }

        private Bitmap PhotoToBitmap(Photo photo)
        {
            Bitmap bm = new Bitmap(photo.Width, photo.Height);

            for (int i = 0; i < photo.Width; i++)
            {
                for (int j = 0; j < photo.Height; j++)
                {
                    bm.SetPixel(i, j, Color.FromArgb(photo.pixels[i,j].R, photo.pixels[i,j].G, photo.pixels[i,j].B));
                }
            }

            return bm;
        }
    }
}
