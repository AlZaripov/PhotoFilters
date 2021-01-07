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

        Label parametersLabel;
        TextBox parameters = new TextBox();


        public MainForm()
        {
            InitializeComponent();

            bm = new Bitmap(@"C:\Users\Александр\source\repos\PhotoFilters\PhotoFilters.BL\Images\DefaultImage.jpg");
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

            double modifyValue = 1;
            if(parameters.Text != "")
                modifyValue = double.Parse(parameters.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            resultPicture.Image = Conversion.PhotoToBitmap(filter.ChangeImage(photo, modifyValue));
        }

        private void ChangeFilter(object sender, EventArgs e)
        {
            var filter = (IFilter)filterSelector.SelectedItem;
            Controls.Remove(parametersLabel);
            Controls.Remove(parameters);

            for(int i = 0; i<filter.GetParameters().Length; i++)
            {
                parametersLabel = new Label();
                parametersLabel.Location = new Point(filterSelector.Location.X, filterSelector.Location.Y + 50);
                parametersLabel.Size = new Size(150, 20);
                parametersLabel.Text = filter.GetParameters()[i].Name;
                parametersLabel.Font = new Font("Calibri", 10);
                Controls.Add(parametersLabel);

                parameters = new TextBox();
                parameters.Text = 100.ToString();
                parameters.Location = new Point(filterSelector.Location.X + 200, filterSelector.Location.Y + 50);
                parameters.Size = new Size(40, 20);
                parameters.TextAlign = HorizontalAlignment.Center;
                parameters.Font = new Font("Calibri", 10);
                Controls.Add(parameters);
            }          
        }

        public void AddFilter(IFilter filter)
        {
            filterSelector.Items.Add(filter);
        }
    }
}
