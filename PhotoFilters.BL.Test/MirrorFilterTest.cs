using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoFilters.BL;

namespace PhotoFilters.BL.Test
{
    [TestClass]
    public class MirrorFilterTest : BaseFilterTest
    {
        [TestMethod]
        public void GetMirrorPixel()
        {
            var photo = new Photo(2, 2);
            photo[0, 0] = new Pixel(0, 0, 0);
            photo[0, 1] = new Pixel(10, 10, 10);
            photo[1, 0] = new Pixel(10, 10, 10);
            photo[1, 1] = new Pixel(100, 100, 100);
            var result = new MirrorFilter().ChangeImage(photo, 1);

            Assert.IsTrue(result[0, 0].Equals(photo[1, 0]));
            Assert.IsTrue(result[0, 1].Equals(photo[1, 1]));
        }
    }
}
