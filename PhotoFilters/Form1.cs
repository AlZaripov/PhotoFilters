using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

            filterSelector.SelectedIndexChanged += ClickChangeFilter;
            applyButton.Click += ClickApply;
            OpenFileButton.Click += ClickOpen;
            SaveFileButton.Click += ClickSave;
        }

        private void ClickSave(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                resultPicture.Image.Save(dlg.FileName+".jpg");
            }
        }

        private void ClickOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Графические файлы|*.jpg|Все файлы |*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(dlg.FileName);
                var image = new Bitmap(bm, new Size(480, 300));
                photo = Conversion.BitmapToPhoto(image);
                originalPicture.Image = image;
            }
        }

        private void ClickApply(object sender, EventArgs e)
        {
            var filter = (IFilter)filterSelector.SelectedItem;
            if (filter == null) return;

            if (double.TryParse(parameters.Text.Replace(',', '.'), out double result))
                if (result > 999)
                {
                    result = 999;
                    parameters.Text = result.ToString();
                }
                
            resultPicture.Image = Conversion.PhotoToBitmap(filter.ChangeImage(photo, result));
        }

        private void ClickChangeFilter(object sender, EventArgs e)
        {
            var filter = (IFilter)filterSelector.SelectedItem;
            Controls.Remove(parametersLabel);
            Controls.Remove(parameters);

            for (int i = 0; i < filter.GetParameters().Length; i++)
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
