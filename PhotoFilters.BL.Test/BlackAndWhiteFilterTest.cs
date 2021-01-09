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

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(0, 0, 0)));
        }

        [TestMethod]
        public void CheckLightPixel()
        {
            originalPicture[0, 0] = new Pixel(200, 200, 200);
            resultPicture = new BlackAndWhiteFilter().ChangeImage(originalPicture, 100);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(255, 255, 255)));
        }
    }
}
