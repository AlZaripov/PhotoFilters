using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFilters.BL.Test
{
    public abstract class BaseFilterTest
    {
        public Photo originalPicture { get; internal set; }
        public Photo resultPicture { get; internal set; }

        public BaseFilterTest()
        {
            originalPicture = new Photo(1, 1);
            resultPicture = new Photo(originalPicture.Width, originalPicture.Height);
        }
    }
}
