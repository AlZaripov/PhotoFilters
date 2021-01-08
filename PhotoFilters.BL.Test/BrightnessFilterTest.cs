using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class BrightnessFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void WithoutLightPixel()
        {
            originalPicture[0, 0] = new Pixel(10, 10, 10);
            resultPicture = new BrightnessFilter().ChangeImage(originalPicture, 10);

            Assert.AreEqual(10, originalPicture[0, 0].R);
            Assert.AreEqual(1, resultPicture[0, 0].R);
        }

        [TestMethod]
        public void OverLightPixel()
        {
            originalPicture[0, 0] = new Pixel(200, 200, 200);
            resultPicture = new BrightnessFilter().ChangeImage(originalPicture, 500);

            Assert.AreEqual(200, originalPicture[0, 0].R);
            Assert.AreEqual(255, resultPicture[0, 0].R);
        }

    }
}
