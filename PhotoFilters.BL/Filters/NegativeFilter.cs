using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class NegativeFilter : IFilter
    {
        public Photo ChangeImage(Photo original, double value)
        {
            throw new NotImplementedException();
        }

        public FilterParameter[] GetParameters()
        {
            throw new NotImplementedException();
        }
    }
}
