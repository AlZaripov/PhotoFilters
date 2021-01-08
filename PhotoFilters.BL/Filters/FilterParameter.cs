using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoFilters.BL
{
    public class FilterParameter
    {
        public string Name { get; set; }
        public int MinValue { get; }
        public int MaxValue { get; }
    }
}
