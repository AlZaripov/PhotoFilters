using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class GrayScaleFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void GetGrayscalePixel()
        {
            originalPicture[0, 0] = new Pixel(10, 20, 30);
            resultPicture = new GrayScaleFilter().ChangeImage(originalPicture, 100);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(20, 20, 20)));
        }
    }
}
