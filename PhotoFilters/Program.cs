using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoFilters.BL;

namespace PhotoFilters
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            mainForm.AddFilter(new GrayScaleFilter());
            mainForm.AddFilter(new BrightnessFilter());
            mainForm.AddFilter(new NegativeFilter());
            mainForm.AddFilter(new BlackAndWhiteFilter());
            mainForm.AddFilter(new SepiaFilter());
            mainForm.AddFilter(new MirrorFilter());
            
            Application.Run(mainForm);
        }
    }
}
