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
            var photo = Conversion.BitmapToPhoto(img);

            PictureBox original = new PictureBox();
            original.Location = new Point(0,0);
            original.Size = new Size(img.Width, img.Height);
            original.Image = img;
            Controls.Add(original);

            PictureBox result = new PictureBox();
            result.Location = new Point(0, original.Height + 10);
            result.Size = new Size(photo.Width, photo.Height);
            result.Image = Conversion.PhotoToBitmap(photo);
            Controls.Add(result);
        }     
    }
}
