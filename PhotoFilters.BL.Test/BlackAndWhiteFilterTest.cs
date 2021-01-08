using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class BlackAndWhiteFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void CheckDarkPixel()
        {
            originalPicture[0, 0] = new Pixel(10, 10, 10);
            resultPicture = new BlackAndWhiteFilter().ChangeImage(originalPicture, 100);

            Assert.AreEqual(10, originalPicture[0, 0].R);
            Assert.AreEqual(0, resultPicture[0, 0].R);
        }

        [TestMethod]
        public void CheckLightPixel()
        {
            originalPicture[0, 0] = new Pixel(200, 200, 200);
            resultPicture = new BlackAndWhiteFilter().ChangeImage(originalPicture, 100);

            Assert.AreEqual(200, originalPicture[0, 0].R);
            Assert.AreEqual(255, resultPicture[0, 0].R);
        }
    }
}
