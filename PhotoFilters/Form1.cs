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
        Photo photo;
        Label parametersLabel;
        TextBox parameters = new TextBox();

        Bitmap defaultImage = new Bitmap(Properties.Resources.DefaultImage);
        Bitmap resultImage;

        public MainForm()
        {
            InitializeComponent();
            SetOriginalPicture(defaultImage);

            filterSelector.SelectedIndexChanged += ClickChangeFilter;
            applyButton.Click += ClickApply;
            OpenFileButton.Click += ClickOpen;
            SaveFileButton.Click += ClickSave;
        }

        private void ClickSave(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
               resultImage.Save(dlg.FileName+".jpg");
        }

        private void ClickOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Графические файлы|*.jpg|Все файлы |*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
                SetOriginalPicture(dlg.FileName);
        }

        private void ClickApply(object sender, EventArgs e)
        {
            var filter = (BaseFilter)filterSelector.SelectedItem;
            if (filter == null) return;

            if (double.TryParse(parameters.Text.Replace(',', '.'), out double result))
                if (result > 999)
                {
                    result = 999;
                    parameters.Text = result.ToString();
                }
            
            resultImage = new Bitmap(Conversion.PhotoToBitmap(filter.ChangeImage(photo, result)));
            resultPicture.Image = new Bitmap(resultImage, new Size(480, 300));
        }

        private void ClickChangeFilter(object sender, EventArgs e)
        {
            var filter = (BaseFilter)filterSelector.SelectedItem;
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

        public void AddFilter(BaseFilter filter)
        {
            filterSelector.Items.Add(filter);
        }

        public void SetOriginalPicture(Bitmap bitmap)
        {
            var sizedOriginalPicture = new Bitmap(bitmap, new Size(480, 300));
            originalPicture.Image = sizedOriginalPicture;
            photo = Conversion.BitmapToPhoto(bitmap);
        }

        public void SetOriginalPicture(string filePath)
        {
            var bm = new Bitmap(filePath);
            var image = new Bitmap(bm, new Size(480, 300));
            photo = Conversion.BitmapToPhoto(bm);
            originalPicture.Image = image;
        }
    }
}
