using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public interface IFilter
    {
        string ToString();
        Photo ChangeImage(Photo original, double coefficient);
    }
}
