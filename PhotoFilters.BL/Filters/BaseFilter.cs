using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public abstract class BaseFilter
    {
        public abstract FilterParameter[] GetParameters();
        public abstract Photo ChangeImage(Photo original, double value);
        public abstract override string ToString();
    }
}
