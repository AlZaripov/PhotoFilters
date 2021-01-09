using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class NegativeFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void GetNegativePixel()
        {
            originalPicture[0, 0] = new Pixel(100, 100, 100);
            resultPicture = new NegativeFilter().ChangeImage(originalPicture, 100);

            Assert.IsTrue(resultPicture[0, 0].Equals(new Pixel(155, 155, 155)));
        }
    }
}
