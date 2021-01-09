using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class BrightnessFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void GetDarkPixel()
        {
            originalPicture[0, 0] = new Pixel(10, 10, 10);
            resultPicture = new BrightnessFilter().ChangeImage(originalPicture, 10);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(1, 1, 1)));
        }

        [TestMethod]
        public void GetLightPixel()
        {
            originalPicture[0, 0] = new Pixel(100, 100, 100);
            resultPicture = new BrightnessFilter().ChangeImage(originalPicture, 200);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(200, 200, 200)));
        }

        [TestMethod]
        public void GetWhitePixel()
        {
            originalPicture[0, 0] = new Pixel(200, 200, 200);
            resultPicture = new BrightnessFilter().ChangeImage(originalPicture, 500);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(255, 255, 255)));
        }

    }
}
