using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public abstract class IFilter
    {
        public abstract FilterParameter[] GetParameters();
        public abstract override string ToString();
        public abstract Photo ChangeImage(Photo original, double value);
    }
}
