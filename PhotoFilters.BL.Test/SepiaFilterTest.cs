using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class SepiaFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void GetSepiaPixel()
        {
            // 0.393 * 100 + 0.769 * 100 + 0.189 * 100 = 135.10000000000002
            // 0.349 * 100 + 0.686 * 100 + 0.168 * 100 = 120.3
            // 0.272 * 100 + 0.534 * 100 + 0.131 * 100 = B = 93.700000000000017

            originalPicture[0, 0] = new Pixel(100, 100, 100);
            resultPicture = new SepiaFilter().ChangeImage(originalPicture, 100);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(135.10000000000002, 120.3, 93.700000000000017)));
        }
    }
}
