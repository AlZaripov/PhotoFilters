using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoFilters.BL;

namespace PhotoFilters
{
    public partial class MainForm : Form
    {
        Bitmap bm;
        Photo photo;
        double parameters;

        public MainForm()
        {
            InitializeComponent();

            bm = new Bitmap(@"C:\Users\Александр\source\repos\PhotoFilters\PhotoFilters.BL\Images\Image.jpg");
            var image = new Bitmap(bm, new Size(480, 300));
            photo = Conversion.BitmapToPhoto(image);

            originalPicture.Image = image;

            filterSelector.SelectedIndexChanged += ChangeFilter;
            applyButton.Click += ClickApply;
        }

        private void ClickApply(object sender, EventArgs e)
        {
            var filter = (IFilter)filterSelector.SelectedItem;
            if (filter == null) return;

            if (filterParameters.Text == "")
                parameters = 1;
            else
                parameters = double.Parse(filterParameters.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            resultPicture.Image = Conversion.PhotoToBitmap(filter.ChangeImage(photo, parameters));
        }

        private void ChangeFilter(object sender, EventArgs e)
        {
            var filter = (IFilter)filterSelector.SelectedItem;
        }

        public void AddFilter(IFilter filter)
        {
            filterSelector.Items.Add(filter);
        }
    }
}
