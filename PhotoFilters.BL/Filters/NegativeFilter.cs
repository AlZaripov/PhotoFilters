using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class NegativeFilter : IFilter
    {
        public override Photo ChangeImage(Photo original, double value)
        {
            throw new NotImplementedException();
        }

        public override FilterParameter[] GetParameters()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
